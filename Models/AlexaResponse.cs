using System.Collections.Generic;

namespace Alexa.Models{

    public class AlexaResponse{
        public string Version {get;set;}
        public Response response {get;set;}
        public Dictionary<string, object> sessionAttributes{get;set;}
    }
}