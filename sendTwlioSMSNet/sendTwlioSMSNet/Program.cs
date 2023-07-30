using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace sendTwlioSMSNet
{
    public class Program
    {
        public static Dictionary<string, string> callback;

        public static void Main()
        {
            try
            {
                // Find your Account SID and Auth Token at twilio.com/console
                // and set the environment variables. See http://twil.io/secure
                string accountSid = Environment.GetEnvironmentVariable(Twilio.var_account_sid);
                string authToken = Environment.GetEnvironmentVariable(Twilio.var_auth_token);

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: Twilio.message,
                    from: new global::Twilio.Types.PhoneNumber(Twilio.var_number),
                    to: new global::Twilio.Types.PhoneNumber(Twilio.numero)
                );

                //Console.WriteLine(response);
                // add more code here to manipulate reponse string.
                callback = new Dictionary<string, string> {
                    { "id", Twilio.id },
                    { "nom", Twilio.nom },
                    { "numero", Twilio.numero },
                    { "message", Twilio.message },
                    { "statut", "Succes/Erreur : " + message.Sid }
                };
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                    { "id", Twilio.id },
                    { "nom", Twilio.nom },
                    { "numero", Twilio.numero },
                    { "message", Twilio.message },
                    { "statut", "Erreur : " + ex.Message }
                };
            }
            
        }
    }
}
