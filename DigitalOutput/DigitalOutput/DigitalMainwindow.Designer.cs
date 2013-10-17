﻿namespace DigitalOutput
{
    partial class DigitalMainwindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.label_Buffer = new System.Windows.Forms.Label();
            this.button_Synchronize = new System.Windows.Forms.Button();
            this.groupBox_Buffer = new System.Windows.Forms.GroupBox();
            this.groupBox_Stats = new System.Windows.Forms.GroupBox();
            this.groupBox_Network = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Network = new System.Windows.Forms.CheckBox();
            this.label_Server = new System.Windows.Forms.Label();
            this.textBox_Ip4 = new System.Windows.Forms.TextBox();
            this.textBox_Ip3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Ip2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Ip1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPanel.SuspendLayout();
            this.groupBox_Buffer.SuspendLayout();
            this.groupBox_Network.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.tabPage1);
            this.TabPanel.Location = new System.Drawing.Point(12, 146);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(1260, 789);
            this.TabPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1252, 763);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(1193, 30);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(1193, 59);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 2;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(1193, 88);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(1193, 117);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 4;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // label_Buffer
            // 
            this.label_Buffer.AutoSize = true;
            this.label_Buffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(20)))), ((int)(((byte)(94)))));
            this.label_Buffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buffer.Location = new System.Drawing.Point(7, 18);
            this.label_Buffer.MaximumSize = new System.Drawing.Size(74, 24);
            this.label_Buffer.MinimumSize = new System.Drawing.Size(74, 24);
            this.label_Buffer.Name = "label_Buffer";
            this.label_Buffer.Size = new System.Drawing.Size(74, 24);
            this.label_Buffer.TabIndex = 5;
            this.label_Buffer.Text = "Synced";
            // 
            // button_Synchronize
            // 
            this.button_Synchronize.Location = new System.Drawing.Point(6, 47);
            this.button_Synchronize.Name = "button_Synchronize";
            this.button_Synchronize.Size = new System.Drawing.Size(75, 23);
            this.button_Synchronize.TabIndex = 6;
            this.button_Synchronize.Text = "Synchronize";
            this.button_Synchronize.UseVisualStyleBackColor = true;
            this.button_Synchronize.Click += new System.EventHandler(this.button_Synchronize_Click);
            // 
            // groupBox_Buffer
            // 
            this.groupBox_Buffer.Controls.Add(this.label_Buffer);
            this.groupBox_Buffer.Controls.Add(this.button_Synchronize);
            this.groupBox_Buffer.Location = new System.Drawing.Point(1100, 12);
            this.groupBox_Buffer.Name = "groupBox_Buffer";
            this.groupBox_Buffer.Size = new System.Drawing.Size(87, 128);
            this.groupBox_Buffer.TabIndex = 7;
            this.groupBox_Buffer.TabStop = false;
            this.groupBox_Buffer.Text = "Buffer";
            // 
            // groupBox_Stats
            // 
            this.groupBox_Stats.Location = new System.Drawing.Point(894, 12);
            this.groupBox_Stats.Name = "groupBox_Stats";
            this.groupBox_Stats.Size = new System.Drawing.Size(200, 128);
            this.groupBox_Stats.TabIndex = 8;
            this.groupBox_Stats.TabStop = false;
            this.groupBox_Stats.Text = "Statistics";
            // 
            // groupBox_Network
            // 
            this.groupBox_Network.Controls.Add(this.label3);
            this.groupBox_Network.Controls.Add(this.checkBox_Network);
            this.groupBox_Network.Controls.Add(this.label_Server);
            this.groupBox_Network.Controls.Add(this.textBox_Ip4);
            this.groupBox_Network.Controls.Add(this.textBox_Ip3);
            this.groupBox_Network.Controls.Add(this.label4);
            this.groupBox_Network.Controls.Add(this.textBox_Ip2);
            this.groupBox_Network.Controls.Add(this.label2);
            this.groupBox_Network.Controls.Add(this.textBox_Ip1);
            this.groupBox_Network.Controls.Add(this.label1);
            this.groupBox_Network.Location = new System.Drawing.Point(688, 12);
            this.groupBox_Network.Name = "groupBox_Network";
            this.groupBox_Network.Size = new System.Drawing.Size(200, 128);
            this.groupBox_Network.TabIndex = 9;
            this.groupBox_Network.TabStop = false;
            this.groupBox_Network.Text = "Network";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(20)))), ((int)(((byte)(94)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(110, 30);
            this.label3.MinimumSize = new System.Drawing.Size(110, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_Network
            // 
            this.checkBox_Network.AutoSize = true;
            this.checkBox_Network.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Network.Location = new System.Drawing.Point(6, 25);
            this.checkBox_Network.Name = "checkBox_Network";
            this.checkBox_Network.Size = new System.Drawing.Size(90, 17);
            this.checkBox_Network.TabIndex = 11;
            this.checkBox_Network.Text = "Network:       ";
            this.checkBox_Network.UseVisualStyleBackColor = true;
            // 
            // label_Server
            // 
            this.label_Server.AutoSize = true;
            this.label_Server.Location = new System.Drawing.Point(6, 52);
            this.label_Server.Name = "label_Server";
            this.label_Server.Size = new System.Drawing.Size(54, 13);
            this.label_Server.TabIndex = 10;
            this.label_Server.Text = "Server IP:";
            // 
            // textBox_Ip4
            // 
            this.textBox_Ip4.Enabled = false;
            this.textBox_Ip4.Location = new System.Drawing.Point(172, 47);
            this.textBox_Ip4.MaxLength = 3;
            this.textBox_Ip4.Name = "textBox_Ip4";
            this.textBox_Ip4.Size = new System.Drawing.Size(24, 20);
            this.textBox_Ip4.TabIndex = 9;
            // 
            // textBox_Ip3
            // 
            this.textBox_Ip3.Enabled = false;
            this.textBox_Ip3.Location = new System.Drawing.Point(142, 47);
            this.textBox_Ip3.MaxLength = 3;
            this.textBox_Ip3.Name = "textBox_Ip3";
            this.textBox_Ip3.Size = new System.Drawing.Size(24, 20);
            this.textBox_Ip3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = ".";
            // 
            // textBox_Ip2
            // 
            this.textBox_Ip2.Enabled = false;
            this.textBox_Ip2.Location = new System.Drawing.Point(112, 47);
            this.textBox_Ip2.MaxLength = 3;
            this.textBox_Ip2.Name = "textBox_Ip2";
            this.textBox_Ip2.Size = new System.Drawing.Size(24, 20);
            this.textBox_Ip2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // textBox_Ip1
            // 
            this.textBox_Ip1.Enabled = false;
            this.textBox_Ip1.Location = new System.Drawing.Point(82, 47);
            this.textBox_Ip1.MaxLength = 3;
            this.textBox_Ip1.Name = "textBox_Ip1";
            this.textBox_Ip1.Size = new System.Drawing.Size(24, 20);
            this.textBox_Ip1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // DigitalMainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1006);
            this.Controls.Add(this.groupBox_Network);
            this.Controls.Add(this.groupBox_Stats);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox_Buffer);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.TabPanel);
            this.Name = "DigitalMainwindow";
            this.Text = "DigitalOutput";
            this.TabPanel.ResumeLayout(false);
            this.groupBox_Buffer.ResumeLayout(false);
            this.groupBox_Buffer.PerformLayout();
            this.groupBox_Network.ResumeLayout(false);
            this.groupBox_Network.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Label label_Buffer;
        private System.Windows.Forms.Button button_Synchronize;
        private System.Windows.Forms.GroupBox groupBox_Buffer;
        private System.Windows.Forms.GroupBox groupBox_Stats;
        private System.Windows.Forms.GroupBox groupBox_Network;
        private System.Windows.Forms.TextBox textBox_Ip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ip4;
        private System.Windows.Forms.TextBox textBox_Ip3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Ip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_Network;
        private System.Windows.Forms.Label label_Server;
        private System.Windows.Forms.Label label3;
    }
}
