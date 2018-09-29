using Alexa.Models;
using alexa_challenge.Helpers;

namespace Alexa.Logic{
    public class ProcessAlexaRequests{
        public AlexaResponse processLaunchRequest(AlexaRequest request){
            return new AlexaResponse();
        }
        public AlexaResponse processIntentRequest(AlexaRequest request){
            string intentName = request?.request?.intent?.name;
            if (!string.IsNullOrEmpty(intentName))
            {
                switch (intentName)
                {
                    case IntentNames.BALANCE_ENQUIRY:
                        break;
                    case IntentNames.TRANSFER_INTENT:
                        break;
                    case IntentNames.PAYCODE_INTENT:
                        break;
                    default:
                        break;
                }
            }
            AlexaResponse alexaRsp = new AlexaResponse();
            Response rsp = new Response() { outputSpeech = new OutputSpeech() { text = "Processing intent request", type = TextType.PLAIN_TEXT }, shouldEndSession=false, reprompt=new Reprompt() { outputSpeech=new OutputSpeech() { text="Do you wish to try again",type
            =TextType.PLAIN_TEXT} } };

            return alexaRsp;

        }
        public AlexaResponse processSessionEndRequest(AlexaRequest request)
        {
            return new AlexaResponse();
        }
        public AlexaResponse processcanFulfillIntentRequest(AlexaRequest request)
        {
            return new AlexaResponse();
        }
    }
}