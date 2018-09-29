using Alexa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alexa_challenge.Helpers
{
    public class OutputMsgMaps
    {
        public static Dictionary<string, OutputSpeech> speechMap = new Dictionary<string, OutputSpeech>() {
            {Converters.BALANCE_ENQUIRY_SPEECH,new OutputSpeech(){type="Plain Text" }        }
        };
    }
}
