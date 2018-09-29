using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alexa.Models;
using Newtonsoft;
using Alexa.Logic;
using alexa_challenge.Helpers;
using Newtonsoft.Json.Linq;

namespace alexa_challenge.Controllers
{

[Route("api/[controller]")]
[ApiController]
public class AlexaEcashController : Controller
{
    private ProcessAlexaRequests processor = new ProcessAlexaRequests();
    public IActionResult PostAlexaRequest([FromBody] JToken req){
        AlexaResponse response=new AlexaResponse();
        try{
                string alexaReq = req.ToString();
            AlexaRequest alexaRequest=Newtonsoft.Json.JsonConvert.DeserializeObject<AlexaRequest>(alexaReq);
                if (alexaRequest.request.type == null)
                {
                   response= processor.processcanFulfillIntentRequest(alexaRequest);
                }
                else if (string.Compare(alexaRequest.request.type, IntentTypes.INTENT_REQUEST, true) == 0)
                {
                    response = processor.processIntentRequest(alexaRequest);
                }

                else if(string.Compare(alexaRequest.request.type,IntentTypes.SESSION_ENDED_REQUEST, true) == 0)
                {
                    response = processor.processSessionEndRequest(alexaRequest);
                }

                else if(string.Compare(alexaRequest.request.type, IntentTypes.SESSION_ENDED_REQUEST, true) == 0)
                {
                    response = processor.processLaunchRequest(alexaRequest);
                }
                return Ok(response);
        }
        catch(Exception ex){
                Response rsp = new Response() { outputSpeech= new OutputSpeech() { type = TextType.PLAIN_TEXT, text = "oops and error occurred. Please try again later" } };
                response.response.shouldEndSession = true;
                return Ok(response);
        }
    }
 }
}