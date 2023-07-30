using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Sender.GSM
{
    class gsm_conect
    {
        public static bool IsConnected { get; set; } = false;
        public static string gsm_name { get; set; }
        public static string port { get; set; }

        public static SerialPort gsmPort = new SerialPort();
        public static ComboBox cbo;

        public static ComboBox ModemConnected()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                if ((string)queryObj["Status"] == "OK")
                {
                    cbo.Items.Add(queryObj["AttachedTo"] + "-" + System.Convert.ToString(queryObj["Description"]));
                }
            }
            return cbo;
        }
        public static void Disconnect()
        {
            if (gsmPort != null || GSM.gsm_conect.IsConnected || gsmPort.IsOpen)
            {
                gsmPort.Close();
                gsmPort.Dispose();
                GSM.gsm_conect.IsConnected = false;
            }
        }
        public static void Connect()
        {
            if (gsmPort == null || !GSM.gsm_conect.IsConnected || !gsmPort.IsOpen)
            {
                try
                {
                    gsmPort.PortName = port;
                    gsmPort.BaudRate = 9600;
                    gsmPort.Parity = Parity.None;
                    gsmPort.DataBits = 8;
                    gsmPort.StopBits = StopBits.One;
                    gsmPort.Handshake = Handshake.RequestToSend;
                    gsmPort.DtrEnable = true;    // Data-terminal-ready
                    gsmPort.RtsEnable = true;    // Request-to-send
                    gsmPort.NewLine = Environment.NewLine;
                    gsmPort.Open();
                    GSM.gsm_conect.IsConnected = true;
                }
                catch (Exception)
                {
                    GSM.gsm_conect.IsConnected = false;
                }
            }
        }
    }
}
