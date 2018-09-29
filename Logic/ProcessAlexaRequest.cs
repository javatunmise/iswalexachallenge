using Alexa.Models;
using alexa_challenge.Helpers;

namespace Alexa.Logic{
    public class ProcessAlexaRequests{
        public AlexaResponse processLaunchRequest(AlexaRequest request){
            AlexaResponse response = new AlexaResponse();
            response.Version = "1.0";
            response.response = new Response() { outputSpeech = new OutputSpeech() { text = "<speak><s> Hello!</s> what can i do for you today?</speak>", type = "SSML" }, };
            response.response.reprompt = new Reprompt() { outputSpeech = new OutputSpeech() { text = "Here are the services I can provide for you: E-cash balance enquiry, Transfer on E-Cash and PayCode generation. Enter an appropriate command to proceed", type="PlainText" } };
            response.response.shouldEndSession = false;
            return response;
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