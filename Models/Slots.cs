using System.Collections.Generic;

namespace Alexa.Models{

    public class Slots{
        public string name {get;set;}
        public string value{get;set;}
        public string confirmationStatus {get;set;}
    }
    public class Intent{
        public string name{get;set;}
        public string confirmationStatus {get;set;}
        public Dictionary<string, Slots> slots{get;set;}
    }
}