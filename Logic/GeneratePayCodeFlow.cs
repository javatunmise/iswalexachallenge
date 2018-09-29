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


        public string GeneratePayCode()
        {
            return "";
        }

        public AlexaResponse ProcessPayCode(AlexaRequest alexaReq) {
            return new AlexaResponse();
        }
    }
}
