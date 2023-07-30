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
    public partial class frmPhoneNumberManager : Form
    {
        connect cn = new connect();

        //on creer un liste
        public ListBox lst { set; get; }
        public string id_oper { set; get; }
        List<string> lists_phone_number = new List<string>();

        public frmPhoneNumberManager()
        {
            InitializeComponent();
        }

        private void transfert()
        {
            try
            {
                id_oper = dgvPhoneNumber.CurrentRow.Cells[0].Value.ToString();
                txtNom.Text = dgvPhoneNumber.CurrentRow.Cells[1].Value.ToString();
                cboReseau.Text = dgvPhoneNumber.CurrentRow.Cells[2].Value.ToString();
                txtNumero.Text = dgvPhoneNumber.CurrentRow.Cells[3].Value.ToString();
                txtNumeroRef.Text = dgvPhoneNumber.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                //On ne fait rien
            }

        }

        /// <summary>
        /// Commdande d'insertion, update, delete et loard
        /// </summary>
        private void enregistrer()
        {
            try
            {
                //ici nous allons crée des command qui sont tres important
                string sql = $"insert into {Settings.Default.table} ({ Settings.Default.champ2 }, { Settings.Default.champ3 }, { Settings.Default.champ4 }, { Settings.Default.champ5 }) values (@nom, @reseau, @num, @ref);";
                MySqlCommand cmd = new MySqlCommand(sql, cn.conn);
                cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@reseau", cboReseau.Text);
                cmd.Parameters.AddWithValue("@num", txtNumero.Text);
                cmd.Parameters.AddWithValue("@ref", txtNumeroRef.Text);

                cmd.ExecuteNonQuery(); //execution de la requette

                MessageBox.Show("Succès", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //recharge les donnees
                Charger();

                btnAjouter.Enabled = false; //on desactive
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Impossible d'enregistrer " + Ex.ToString(), "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimer()
        {
            try
            {

                //on va devoir verifier s'il y a un element selectionner dans la base de données
                if (dgvPhoneNumber.SelectedRows.Count > 0)
                {

                    string id = this.dgvPhoneNumber.CurrentRow.Cells[0].Value.ToString();
                    // on ecrit la commande pour supprimmer de la table Tb_Categories tout ayant pour id = "ex..."
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM {Settings.Default.table} WHERE {Settings.Default.champ1} = @id", cn.conn);
                    cmd.Parameters.AddWithValue("@id", id_oper);
                    cmd.ExecuteNonQuery(); // execution de la requette

                    int index = this.dgvPhoneNumber.CurrentRow.Index;
                    this.dgvPhoneNumber.Rows.RemoveAt(index);

                    MessageBox.Show("Succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Impossible de supprimer " + Ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modifier()
        {
            try
            {
                string sql = $"update {Settings.Default.table} set {Settings.Default.champ2} = @nom, {Settings.Default.champ3} = @reseau, {Settings.Default.champ4} = @num, {Settings.Default.champ5} = @ref where {Settings.Default.champ1} = @id;";
                //ici nous allons crée des command qui sont tres important
                MySqlCommand cmd = new MySqlCommand(sql, cn.conn);
                cmd.Parameters.AddWithValue("@id", id_oper);
                cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@reseau", cboReseau.Text);
                cmd.Parameters.AddWithValue("@num", txtNumero.Text);
                cmd.Parameters.AddWithValue("@ref", txtNumeroRef.Text);

                cmd.ExecuteNonQuery(); //execution de la requette

                MessageBox.Show("Succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //recharge les donnees
                Charger();

                btnAjouter.Enabled = false; //on desactive
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Impossible d'enregistrer " + Ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Charger()
        {
            try
            {
                //on vide la dgv
                dgvPhoneNumber.Rows.Clear();
                MySqlDataReader dr;
                var command = new MySqlCommand($"SELECT * FROM {Settings.Default.table};", cn.conn);
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    dgvPhoneNumber.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
                dr.Close();

                btnAjouter.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erruer de chargement des données " + Ex.Message, "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Recherche via plusieurs attributs 
        /// </summary>
        private void research(string param)
        {
            //on va devor vider d'abord la dataTable
            try
            {
                string sql = $"select * from {Settings.Default.table} where {Settings.Default.champ2} like '%{param}%' or {Settings.Default.champ3} like '%{param}%' or {Settings.Default.champ4} like '%{param}%' or {Settings.Default.champ5} like '%{param}%';";
                MySqlCommand cmd = new MySqlCommand(sql, cn.conn);
                //on vide la dgv
                dgvPhoneNumber.Rows.Clear();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvPhoneNumber.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
                dr.Close();

                btnAjouter.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erruer de chargement des données " + Ex.Message, "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            research(txtSearch.Text);
        }

        private void frmNumero_Load(object sender, EventArgs e)
        {
            Charger();
            txtNumero.Text = "+243";
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            Charger();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            enregistrer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir modifier ?", "Modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                modifier();
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ?", "Suppresion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                supprimer();
            }
        }

        private void btnNewArriv_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtNumero.Clear();
            txtNumeroRef.Clear();

            txtNumero.Text = "+243";

            btnAjouter.Enabled = true;
        }  

        private void dgvPhoneNumber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            transfert();
        }

        private void dgvPhoneNumber_SelectionChanged(object sender, EventArgs e)
        {
            transfert();
        }

        private void btnRecupNumber_Click(object sender, EventArgs e)
        {
            if (dgvPhoneNumber.Rows.Count > 0 && dgvPhoneNumber.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dr in dgvPhoneNumber.Rows)
                {
                    if (dr.Selected)
                    {
                        lst.Items.Add(dr.Cells[3].Value.ToString());
                    }
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }      
    }
}
