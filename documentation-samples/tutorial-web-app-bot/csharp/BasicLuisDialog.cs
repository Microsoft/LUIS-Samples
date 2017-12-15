using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Microsoft.Bot.Sample.LuisBot
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-luis
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {
        public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(
            ConfigurationManager.AppSettings["LuisAppId"], 
            ConfigurationManager.AppSettings["LuisAPIKey"], 
            domain: ConfigurationManager.AppSettings["LuisAPIHostName"])))
        {
        }
        
        // CONSTANTS        
        // Entity
        public const string Entity_Device = "HomeAutomation.Device";
        public const string Entity_Room = "HomeAutomation.Room";
        public const string Entity_Operation = "HomeAutomation.Operation";

        // Intents
        public const string Intent_TurnOn = "HomeAutomation.TurnOn";
        public const string Intent_TurnOff = "HomeAutomation.TurnOff";
        public const string Intent_None = "None";

        // Round score
        public string score(Double? value)
        {
            if (value != null)
            {
                return Math.Round(value.Value, 2).ToString();
            }
            else
            {
                return "0";
            }
        }
        // Entities found in result
        public string BotEntityRecognition(string intentName, LuisResult result)
        {
            IList<EntityRecommendation> listOfEntitiesFound = result.Entities;
            StringBuilder entityResults = new StringBuilder();

            foreach (EntityRecommendation item in listOfEntitiesFound)
            {
                // Query: Turn on the [light]
                // item.Type = "HomeAutomation.Device"
                // item.Entity = "light"
                entityResults.Append(item.Type.Replace("HomeAutomation.","") + "=" + item.Entity + ",");
            }
            // remove last comma
            entityResults.Remove(entityResults.Length - 1, 1);

            return entityResults.ToString();
        }

        [LuisIntent(Intent_None)]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisResult(context, result);
        }
        
        [LuisIntent(Intent_TurnOn)]
        public async Task OnIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisResult(context, result);
        }
        
        [LuisIntent(Intent_TurnOff)]
        public async Task OffIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisResult(context, result);
        }    
        
        private async Task ShowLuisResult(IDialogContext context, LuisResult result) 
        {
            string entities = this.BotEntityRecognition(Intent_TurnOff, result);
            await context.PostAsync($"**Query**: {result.Query}, **Intent**: {result.Intents[0].Intent}, **Score**: {score(result.Intents[0].Score)}. **Entities**: {entities}");
            context.Wait(MessageReceived);
        }
    }
}