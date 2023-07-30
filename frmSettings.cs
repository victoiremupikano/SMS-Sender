using MySql.Data.MySqlClient;
using SMS_Sender.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Sender
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void picModifier_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Voulez-vous vraiment modifier les paramètres ?", "Paramètres", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtIp.Text) || string.IsNullOrEmpty(txtMode.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtport.Text) || string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtdatabase.Text))
                {
                    MessageBox.Show("Il y a des champs obligatoire à remplir avant modification ? ", "Paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Settings.Default.ip = txtIp.Text;
                    Settings.Default.username = txtusername.Text;
                    Settings.Default.password = txtpassword.Text;
                    Settings.Default.database = txtdatabase.Text;
                    Settings.Default.port = txtport.Text;
                    Settings.Default.mode = txtMode.Text;

                    //enregistrement 
                    Settings.Default.Save();

                    MessageBox.Show("Successfull, l'application va rédemarrer", "Paramètres", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
        }

        private void frmParametres_Load(object sender, EventArgs e)
        {
            // instaciation des valeurs par defaut du server
            txtIp.Text = Settings.Default.ip;
            txtdatabase.Text = Settings.Default.database;
            txtusername.Text = Settings.Default.username;
            txtpassword.Text = Settings.Default.password;
            txtport.Text = Settings.Default.port;
            txtMode.Text = Settings.Default.mode;

            // instaciation des valeurs par defaut de la bs
            txtTable.Text = Settings.Default.table;

            txtChamp1.Text = Settings.Default.champ1;
            txtChamp2.Text = Settings.Default.champ2;
            txtChamp3.Text = Settings.Default.champ3;
            txtChamp4.Text = Settings.Default.champ4;
            txtChamp5.Text = Settings.Default.champ5;
        }

        private void picTester_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIp.Text) || string.IsNullOrEmpty(txtMode.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtport.Text) || string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtdatabase.Text))
            {
                MessageBox.Show("Il y a des champs obligatoire à remplir avant modification ? ", "Paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection();

                    string connection_string = "server=" + txtIp.Text + "; port=" + txtport.Text + "; user=" + txtusername.Text + "; password=" + txtpassword.Text + "; database=" + txtdatabase.Text + "";

                    conn = new MySqlConnection(connection_string);

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        MessageBox.Show("Connexion établie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Connexion échouer", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Connexion échouer " + Ex.Message, "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void picSaveBD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment modifier les paramètres ?", "Paramètres", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtTable.Text) || string.IsNullOrEmpty(txtChamp1.Text) || string.IsNullOrEmpty(txtChamp2.Text) || string.IsNullOrEmpty(txtChamp3.Text) || string.IsNullOrEmpty(txtChamp4.Text) || string.IsNullOrEmpty(txtChamp5.Text))
                {
                    MessageBox.Show("Il y a des champs obligatoire à remplir avant modification ? ", "Paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Settings.Default.table = txtTable.Text;

                    Settings.Default.champ1 = txtChamp1.Text;
                    Settings.Default.champ2 = txtChamp2.Text;
                    Settings.Default.champ3 = txtChamp3.Text;
                    Settings.Default.champ4 = txtChamp4.Text;
                    Settings.Default.champ5 = txtChamp5.Text;

                    //enregistrement 
                    Settings.Default.Save();

                    MessageBox.Show("Successfull, l'application va rédemarrer", "Paramètres", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
        }

        private void picTestedBD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTable.Text) || string.IsNullOrEmpty(txtChamp1.Text) || string.IsNullOrEmpty(txtChamp2.Text) || string.IsNullOrEmpty(txtChamp3.Text) || string.IsNullOrEmpty(txtChamp4.Text) || string.IsNullOrEmpty(txtChamp5.Text))
            {
                MessageBox.Show("Il y a des champs obligatoire à remplir avant modification ? ", "Paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection();

                    string connection_string = "server=" + txtIp.Text + "; port=" + txtport.Text + "; user=" + txtusername.Text + "; password=" + txtpassword.Text + "; database=" + txtdatabase.Text + "";

                    conn = new MySqlConnection(connection_string);

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        MessageBox.Show("Connexion établie à la base de données", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //datatable
                        DataTable dt = new DataTable();

                        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM " + txtTable.Text + ";", conn);
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Il y a des données dans la table", "Accès à la table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Il y a pas des données dans la table", "Accès à la table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Connexion échouer", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Connexion échouer " + Ex.Message, "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
