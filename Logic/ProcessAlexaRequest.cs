using Alexa.Models;

namespace Alexa.Logic{
    public class ProcessAlexaRequests{
        public AlexaResponse processLaunchRequest(AlexaRequest request){
            return new AlexaResponse();
        }
        public AlexaResponse processIntentRequest(AlexaRequest request){
            AlexaResponse alexaRsp = new AlexaResponse();

        }
        public AlexaResponse processSessionEndRequest(AlexaRequest request)
        {
            return new AlexaResponse();
        }
        public AlexaResponse processcanFulfillIntentRequest(AlexaRequest request)
        {

        }
    }
}