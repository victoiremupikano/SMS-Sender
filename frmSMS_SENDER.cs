using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using SMS_Sender.Properties;
using System.Diagnostics;

namespace SMS_Sender
{
    public partial class frmSMS_SENDER : Form
    {
        GSM.gsm gsm = new GSM.gsm();

        public frmSMS_SENDER()
        {
            InitializeComponent();
        }

        private void ModemsConnected()
        {
            cboModemsConnected.Items.Clear(); // on vide le combobox pour y mettre les modems connecter sur l'ordinateur
            GSM.gsm_conect.cbo = cboModemsConnected;
            cboModemsConnected = GSM.gsm_conect.ModemConnected();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ModemsConnected();
            loard_twilio_settings();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            ModemsConnected();
        }

        private void btnDeconnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboModemsConnected.Text) || string.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("Erreur, veiller choisir le modem sur lesquel vous connecter ?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnConnexion.Text == "Connecter")
                {
                    GSM.gsm_conect.Disconnect();
                    btnConnexion.Text = "Deconnecter";
                }
                else
                {
                    GSM.gsm_conect.Connect();
                    btnConnexion.Text = "Connecter";
                }
            }
        }
               
        private void btnContact_Click(object sender, EventArgs e)
        {
            openFileDialogContact.FileName = "";

            if (openFileDialogContact.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialogContact.FileName);

                //on vide la liste
                liste_contact.Items.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    liste_contact.Items.Add(line);
                }
                //on ferme
                reader.Close();
            }
        }

        private void btnUnAller_Click(object sender, EventArgs e)
        {
            if (liste_contact.SelectedItems.Count < 1)
            {
                //
            }
            else
            {
                liste_receptif.Items.Add(liste_contact.SelectedItem);
                liste_contact.Items.Remove(liste_contact.SelectedItem);
            }
        }

        private void btmTousAller_Click(object sender, EventArgs e)
        {
            if (liste_contact.Items.Count > 0)
            {
                int i = 0;

                while (i < liste_contact.Items.Count)
                {
                    liste_receptif.Items.Add(liste_contact.Items[i]);

                    i = i + 1;
                }
               
                liste_contact.Items.Clear();
            }
        }

        private void btnTousRetour_Click(object sender, EventArgs e)
        {
            if (liste_receptif.Items.Count > 0)
            {
                int i = 0;

                while (i < liste_receptif.Items.Count)
                {
                    liste_contact.Items.Add(liste_receptif.Items[i]);

                    i = i + 1;
                }

                liste_receptif.Items.Clear();
            }
        }

        private void btnUnRetour_Click(object sender, EventArgs e)
        {
            if (liste_receptif.SelectedItems.Count < 1)
            {
                //
            }
            else
            {
                liste_contact.Items.Add(liste_receptif.SelectedItem);
                liste_receptif.Items.Remove(liste_receptif.SelectedItem);
            }
        }

        private void cbo_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pour faciliter on crée des variables
            string port_byVal = cboModemsConnected.Text;
            //separtion de val text et entier
            var port = port_byVal.Split('-');
            //stockage de valeur separer
            string part1 = port[0];
            string part2 = port[1];
            txtPort.Text = part1;

            GSM.gsm_conect.gsm_name = cboModemsConnected.Text;
            GSM.gsm_conect.port = txtPort.Text;
        }

        private void liste_receptif_Click(object sender, EventArgs e)
        {
            try
            {
                if (liste_receptif.Items.Count > 0)
                {
                    txtPhoneNumber.Text = liste_receptif.SelectedItem.ToString();
                }
            }
            catch (Exception)
            {
                //on ne fait rien
            }
        }

        private void frmSMS_SENDER_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void paramètresDeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }

        private void numèroDeTéléphoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmPhoneNumberManager frm = new frmPhoneNumberManager())
            {
                //on vide la list
                liste_contact.Items.Clear();
                //on passe la list
                frm.lst = liste_contact;

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {                  
                    //on la recharge
                    liste_contact = frm.lst;
                }
            }
        }

        private void liste_contact_DoubleClick(object sender, EventArgs e)
        {
            if (liste_contact.SelectedItems.Count < 1)
            {
                //
            }
            else
            {
                liste_receptif.Items.Add(liste_contact.SelectedItem);
                liste_contact.Items.Remove(liste_contact.SelectedItem);
            }
        }

        /// <summary>
        /// Envoi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void account()
        {
            sendTwlioSMSNet.Twilio.var_account_sid = Settings.Default.AccountSid_API;
            sendTwlioSMSNet.Twilio.var_auth_token = Settings.Default.AuthToken_API;
            sendTwlioSMSNet.Twilio.var_number = Settings.Default.Number_API;
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (rbGSM.Checked == true)
            {
                if (liste_receptif.Items.Count < 1 || string.IsNullOrEmpty(txtMessage.Text))
                {
                    MessageBox.Show("Erreur, veiller remplir tous les chasmps pour demarrer l'envoie des messages ?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Etes-vous sûr de vouloir demarrer l'envoie", "Dialogue", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        int i = 0;
                        btnEnvoyer.Enabled = false;

                        while (i < liste_receptif.Items.Count)
                        {
                            string number = txtPhoneNumber.Text = liste_receptif.Items[i].ToString();
                            string message = txtMessage.Text;

                            Dictionary<string, string> fields = new Dictionary<string, string>{
                                {"numero", number},
                                {"message", message},
                            };
                            gsm.send(fields);

                            //on inscrit le callback dans la dgv
                            txtConsole.AppendText("Numero :" + gsm.callback["numero"].ToString() + " ; Message :" + gsm.callback["message"].ToString() + "=> Statut :" + gsm.callback["statut"].ToString() + " à " + DateTime.Now.ToString());

                            i = i + 1;
                        }
                    }
                    //Eneabled
                    btnEnvoyer.Enabled = true;
                }
            }
            else if (rbAPI.Checked == true)
            {
                if (MessageBox.Show("Etes-vous sûr de vouloir demarrer l'envoie", "Dialogue", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int i = 0;
                    btnEnvoyer.Enabled = false;

                    //on passe les identifiants
                    account();
                    ////
                    ///
                    while (i < liste_receptif.Items.Count)
                    {
                        string number = txtPhoneNumber.Text = liste_receptif.Items[i].ToString();
                        string message = txtMessage.Text;

                        sendTwlioSMSNet.Twilio.numero = number;
                        sendTwlioSMSNet.Twilio.message = message;
                                                
                        sendTwlioSMSNet.Program.Main();//on cree une instnce l'app console

                        //on inscrit le callback
                        txtConsole.AppendText("Numero :" + sendTwlioSMSNet.Program.callback["numero"].ToString() + " ; Message :" + sendTwlioSMSNet.Program.callback["message"].ToString() + "=> Statut :" + sendTwlioSMSNet.Program.callback["statut"].ToString() + " à " + DateTime.Now.ToString());

                        i = i + 1;
                    }
                }
                //Eneabled
                btnEnvoyer.Enabled = true;
            }
            else { }
        }

        private void effacerLaConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }

        private void loard_twilio_settings()
        {
            txtAccountSID.Text = Settings.Default.AccountSid_API;
            txtAuthToken.Text = Settings.Default.AuthToken_API;
            txtNumber.Text = Settings.Default.Number_API;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment modifier les paramètres ?", "Dialogue", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtAccountSID.Text) || string.IsNullOrEmpty(txtAuthToken.Text) || string.IsNullOrEmpty(txtNumber.Text))
                {
                    MessageBox.Show("Il y a des champs obligatoire à remplir avant modification ?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Settings.Default.AccountSid_API = txtAccountSID.Text;
                    Settings.Default.AuthToken_API = txtAuthToken.Text;
                    Settings.Default.Number_API = txtNumber.Text;

                    //enregistrement 
                    Settings.Default.Save();
                    MessageBox.Show("Successfull, l'application va rédemarrer", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
        }

        private void btnChoisirDb_Click(object sender, EventArgs e)
        {
            using (frmPhoneNumberManager frm = new frmPhoneNumberManager())
            {
                //TRF  de la liste vide
                frm.lst = liste_contact;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        //RCP de la liste remplis
                        this.liste_contact = frm.lst;
                    }
                    catch (Exception)
                    { }
                }
            }
        }

        private void aproposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
