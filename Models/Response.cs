using System.Collections.Generic;

namespace Alexa.Models{
    public class Response{
        public bool shouldEndSession{get;set;}
        public OutputSpeech outputSpeech {get;set;}
        public Card card {get;set;}
        public Reprompt reprompt { get; set; }

    }

     public class OutputSpeech{
        public string type {get;set;}
        public string text {get;set;}
        public string ssml {get;set;}
    }
    public class Card{
        public string type {get;set;}
        public string title {get;set;}
        public string content {get;set;}
    }
    public class Reprompt{
        public OutputSpeech outputSpeech{get;set;} 
    }

}