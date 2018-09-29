namespace Alexa.Models{
    public class AlexaRequest{
        public string version{get;set;}
        public Session session {get;set;}
        public Context context {get;set;}
        public Request request{get;set;}
    }
    
    public class Session{
        public bool isNew {get;set;}
        public string sessionId{get;set;}
        public Application application{get;set;}
        public Attributes attributes{get;set;}
        public User user {get;set;}
    }
    public class System {
        public string apiAccessToken {get;set;}
    }
    public class Context{
        public System system {get;set;}
    } 
     public class Application{
        public string applicationId {get;set;}
    }

    public class User{
        public string userId{get;set;}
        public string accessToken {get;set;}
        public string permissions {get;set;}
    }
}