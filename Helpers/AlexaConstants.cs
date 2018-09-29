﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alexa_challenge.Helpers
{
    public static class AlexaConstants
    {
    }
    public static class IntentTypes
    {
        public const string LAUNCH_REQUEST = "LaunchRequest";
        public const string INTENT_REQUEST = "IntentRequest";
        public const string SESSION_ENDED_REQUEST = "SessionEndedRequest";
    }
    public static class TextType
    {
        public const string PLAIN_TEXT = "Plaintext";
        public const string SSML = "SSML";
    }
}
