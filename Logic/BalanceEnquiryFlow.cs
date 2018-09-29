using Alexa.Models;
using alexa_challenge.Data;
using alexa_challenge.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alexa_challenge.Logic
{
    public class BalanceEnquiryFlow
    {
        public AlexaResponse GetBalance(AlexaRequest alexaReq)
        {
            AlexaResponse alexaResp = new AlexaResponse();
            OutputSpeech outSpeech = new OutputSpeech();
            Dictionary<string, object> sessionAttr = new Dictionary<string, object>();
            try
            {
                string deviceId = alexaReq?.session?.user.userId;
                if (string.IsNullOrEmpty(deviceId))
                {

                }
                //get user details from DB
                UserDetails user = DataLogic.GetUserDetails(deviceId);
                if (user == null)
                {

                }
                List<UserBankAccount> accounts = TransactionProcessor.GetBalance(user.PhoneNumber);
                if (accounts == null)
                {

                }
                else if (accounts.Count == 0)
                {

                }
                else if (accounts.Count == 1)
                {

                }
                else
                {
                    int number = accounts.Count;
                    string numWord = Converters.numberWordsMap.ContainsKey(number) ? Converters.numberWordsMap[number] : number.ToString();
                    string text = $"{numWord} accounts found. and the balances are ";
                    for (int i=0;i<accounts.Count;i++)
                    {

                    }
                }
            }
            catch(Exception ex)
            {

            }
            return alexaResp;

        }
    }
}
