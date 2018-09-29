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
            OutputSpeech speech = OutputMsgMaps.speechMap[Converters.BALANCE_ENQUIRY_SPEECH];
            Dictionary<string, object> sessionAttr = alexaReq?.session?.attributes;
            if (sessionAttr == null)
            {
                sessionAttr= new Dictionary<string, object>();
            }
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

                    speech.text = $"<speak><s><emphasis level=\"moderate\">yay!</emphasis></s> <say-as interpret-as=\"cardinal\"> {accounts[0].AccountBalance} </ say -as> naira is left in your account</ speak > ";

                    if (sessionAttr.ContainsKey(SessionAttributes.BALANCE)) {
                        sessionAttr[SessionAttributes.BALANCE] = accounts[0].AccountBalance;
                    }
                    else { sessionAttr.Add(SessionAttributes.BALANCE, accounts[0].AccountBalance); }

                    if (sessionAttr.ContainsKey(SessionAttributes.ACCOUNT_NUMBER))
                    {
                        sessionAttr[SessionAttributes.PHONE_NUMBER] = accounts[0].PhoneNumber;
                    }
                    else
                    {
                        sessionAttr.Add(SessionAttributes.PHONE_NUMBER, accounts[0].PhoneNumber);
                    }
                    if (sessionAttr.ContainsKey(SessionAttributes.ACCOUNT_NUMBER))
                    {
                        sessionAttr[SessionAttributes.ACCOUNT_NUMBER]= accounts[0].AccountNumber;
                    }
                    else {
                        sessionAttr.Add(SessionAttributes.ACCOUNT_NUMBER, accounts[0].AccountNumber);
                    }
                    
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
