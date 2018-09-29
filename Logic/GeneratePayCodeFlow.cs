using Alexa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alexa_challenge.Logic
{
    public class GeneratePayCodeFlow
    {
        public const string AMOUNT = "Amount";
        public const string PAYCODE_PIN = "Pin";
        public const string ECASH_PIN = "Ecash Pin";
        public const string PAYCODE_CHANNEL = "Paycode Channel";
        //


        public string GeneratePayCode(string amount, string pin, string eCashPin, string paycodeChannel)
        {
            int[] vals = new int[] { 1, 4, 4, 6, 3, 4, 3, 2, 3, 6, 5, 9, 8,7,1,8 };
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {

            }
            return "";
        }

        public AlexaResponse ProcessPayCode(AlexaRequest alexaReq) {
            var slots = alexaReq?.request?.slots;
            if (slots != null)
            {
                
            }
            return new AlexaResponse();
        }
    }
}
