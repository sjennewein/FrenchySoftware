﻿namespace DigitalOutput.Model
{
    public class ModelFabric
    {
        public static ModelCard GenerateCard()
        {
            const int channels = 32;
            const int steps = 15;
            const int patterns = 5;
            

            //initialize card
            var newCard = new ModelCard
                {Patterns = new ModelPattern[patterns], ChannelDescription = new string[channels]};

            //initialize channel descriptions
            for (int iChannels = 0; iChannels < channels; iChannels++)
            {
                newCard.ChannelDescription[iChannels] = "";
            }

            //initialize steps
            for (int iPattern = 0; iPattern < patterns; iPattern++)
            {
                var newPattern = new ModelPattern(){Steps = new ModelStep[steps]};
                newPattern.Name = "Pattern" + iPattern;
                
                for (int iSteps = 0; iSteps < steps; iSteps++)
                {
                    var newStep = new ModelStep(){Channels =  new ModelData[channels]};
                    newPattern.Steps[iSteps] = newStep;

                    for (int iChannels = 0; iChannels < channels; iChannels++)
                    {
                        newStep.Channels[iChannels] = new ModelData(){Type = DataType.Data};
                    }
                }
                newCard.Patterns[iPattern] = newPattern;
            }

            return newCard;
        }
    }
}