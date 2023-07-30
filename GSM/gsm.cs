using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMS_Sender.GSM
{
    class gsm
    {
        public Dictionary<string, string> callback;
        private SerialPort gsmPort = null;

        public gsm()
        {
            gsmPort = new SerialPort();
            gsmPort = GSM.gsm_conect.gsmPort;
        }

        public void send(Dictionary<string, string> args)
        {
            try
            {
                gsmPort.WriteLine("AT+CMGF=1"); // Set mode to Text(1) or PDU(0)
                Thread.Sleep(1000);
                gsmPort.WriteLine($"AT+CMGS=\"{args["numero"]}\"");
                Thread.Sleep(1000);
                gsmPort.WriteLine(args["message"] + char.ConvertFromUtf32(26));
                Thread.Sleep(5000);

                string response = gsmPort.ReadExisting();

                if (response.EndsWith("\r\nOK\r\n") && response.Contains("+CMGS:")) // IF CMGS IS MISSING IT MEANS THE MESSAGE WAS NOT SENT!
                {
                    // Console.WriteLine(response);
                    // add more code here to manipulate reponse string.
                    callback = new Dictionary<string, string> {
                        { "numero", args["numero"] },
                        { "message", args["message"] },
                        { "statut", "Envoyé" + response }
                    };
                }
                else
                {
                    // add more code here to handle error.
                    //Console.WriteLine(response);
                    callback = new Dictionary<string, string> {
                        { "numero", args["numero"] },
                        { "message", args["message"] },
                        { "statut", "Erreur probable" + response }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                    { "numero", args["numero"] },
                    { "message", args["message"] },
                    { "statut", "Non envoyé" + ex.Message }
                };
            }
        }
    }
}
