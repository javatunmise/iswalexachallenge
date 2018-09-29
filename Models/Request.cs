using System.Collections.Generic;

namespace Alexa.Models{
    public class Request{
        public string type {get;set;}
        public string requestId {get;set;}
        public string timestamp {get;set;}
        public string locale {get;set;}
        //canFulfill request
        public CanFulfillIntentRequest canfulfill {get;set;}
        public Dictionary<string,Slots> slots{get;set;}

        //intentRequest
        public string dialogState {get;set;}
        public Intent intent{get;set;}

        //lunchRequest
        public string reason{get;set;}
        public Error error{get;set;}
    }
    public class LunchRequest:Request{
        
    }
    public class CanFulfillIntentRequest:Request {
        
    }
    public class IntentRequest: Request{
        
    }
    public class SessionEndedRequest:Request{
       
    }
    public class Error{
        public string type{get;set;}
        public string message{get;set;}
    }
    
}