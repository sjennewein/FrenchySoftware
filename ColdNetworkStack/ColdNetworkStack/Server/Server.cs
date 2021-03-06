﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ColdNetworkStack.Server
{
    public class Server
    {
        private readonly List<ClientProtocol> _clientTalks = new List<ClientProtocol>();
        private readonly TcpListener _listener;
        private readonly AutoResetEvent _myClientGate = new AutoResetEvent(false);
        private readonly List<String> _registeredClients = new List<string>();
        
        public int Cycles = 0;
        
        public string TriggerData = "";
        private long _readyClients;
        private long _startedClients;
        private bool _serverRun = true;
        private bool _masterIsReady = false;

        public List<String> RegisteredClients { get { return _registeredClients; } } 

        public Server(IPAddress ip, int port)
        {
            _listener = new TcpListener(ip, port);
            new Thread(Listen).Start();
        }

        private void Listen()
        {
            _listener.Start();
            while (_serverRun)
            {
                try
                {
                    _listener.BeginAcceptTcpClient(ListenCallback, _listener);
                }
                catch
                {
                    break;
                }
                _myClientGate.WaitOne();
            }
            _listener.Stop();
        }

        public void Stop()
        {
            _serverRun = false;
            foreach (var clientProtocol in _clientTalks)
            {
                clientProtocol.Stop();
                clientProtocol.StopTriggerMode();
            }
            _myClientGate.Set();
        }

        public void MasterIsReady()
        {
            _masterIsReady = true;
            ClientReady();
        }

        public void MasterHasFinished()
        {
            _masterIsReady = false;
            RegisteredClients.Clear();
        }

        public void RegisterClient(string name)
        {
            _registeredClients.Add(name);
            TriggerEvent(ClientsChanged);
        }

        public void UnregisterClient(string name)
        {
            _registeredClients.Remove(name);
            TriggerEvent(ClientsChanged);
        }

        private void ListenCallback(IAsyncResult result)
        {
            var listener = (TcpListener) result.AsyncState;
            TcpClient client;
            //catch exception when the server is closed
            try
            {
                client = listener.EndAcceptTcpClient(result);
            }
            catch (Exception)
            {
                //when something happens just return and do nothing
                return;
            }
            finally
            {
                _myClientGate.Set();
            }

            client.NoDelay = true;
            client.Client.NoDelay = true;

            var clientTalk = new ClientProtocol(this);
            _clientTalks.Add(clientTalk);

            clientTalk.StartCommunication(client);

            _clientTalks.Remove(clientTalk);
            client.Close();
        }
       /// <summary>
       /// Each client calls that function to signal that it finished the run
       /// </summary>
        public void ClientReady()
        {
            Interlocked.Add(ref _readyClients, 1);

            if (!_masterIsReady)
                return;

            if (Interlocked.Read(ref _readyClients) == _registeredClients.Count)
            {
                Interlocked.Exchange(ref _readyClients, 0);
                StartNextRun();                
            }
        }

        /// <summary>
        /// Each client calls this function after having started its hardware again and is
        /// ready for a hardware trigger
        /// </summary>
        public void ClientStarted()
        {
            Interlocked.Add(ref _startedClients, 1);            
            if(Interlocked.Read(ref _startedClients) == _registeredClients.Count)
            {
                Interlocked.Exchange(ref _startedClients, 0);                
                TriggerEvent(AllClientsAreLaunched);
            }
        }

        public void ClientFinished()
        {
            Interlocked.Exchange(ref _readyClients, 0);
        }

        public void StopTrigger()
        {
            foreach (ClientProtocol client in _clientTalks)
                client.StopTriggerMode();
        }

        private void StartNextRun()
        {
            foreach (ClientProtocol client in _clientTalks)
                client.SendTrigger();
            //call ClientStarted once for the apd itself
            ClientStarted();
        }

        private void TriggerEvent(EventHandler newEvent, EventArgs e = null)
        {
            EventHandler triggerEvent = newEvent;
            if (triggerEvent != null)
                triggerEvent(this, new EventArgs());
        }

        public event EventHandler AllClientsAreReady;
        public event EventHandler AllClientsAreLaunched;
        public event EventHandler ClientsChanged;
    }
}