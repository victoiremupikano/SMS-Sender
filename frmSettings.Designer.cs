namespace SMS_Sender
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.lblSave = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.tabControlParametres = new System.Windows.Forms.TabControl();
            this.tbServeur = new System.Windows.Forms.TabPage();
            this.picTester = new System.Windows.Forms.PictureBox();
            this.picModifier = new System.Windows.Forms.PictureBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.lbldatabase = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.tbDataBase = new System.Windows.Forms.TabPage();
            this.picTestedBD = new System.Windows.Forms.PictureBox();
            this.picSaveBD = new System.Windows.Forms.PictureBox();
            this.lblGuido = new System.Windows.Forms.Label();
            this.txtChamp5 = new System.Windows.Forms.TextBox();
            this.lblChamp5 = new System.Windows.Forms.Label();
            this.txtChamp4 = new System.Windows.Forms.TextBox();
            this.lblChamp4 = new System.Windows.Forms.Label();
            this.txtChamp3 = new System.Windows.Forms.TextBox();
            this.lblChamp3 = new System.Windows.Forms.Label();
            this.txtChamp2 = new System.Windows.Forms.TextBox();
            this.lblChamp2 = new System.Windows.Forms.Label();
            this.txtChamp1 = new System.Windows.Forms.TextBox();
            this.lblChamp1 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.pnlBordGauche = new System.Windows.Forms.Panel();
            this.pnlBaodDroit = new System.Windows.Forms.Panel();
            this.tabControlParametres.SuspendLayout();
            this.tbServeur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModifier)).BeginInit();
            this.tbDataBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTestedBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveBD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(57, 209);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(57, 13);
            this.lblSave.TabIndex = 94;
            this.lblSave.Text = "Enregistrer";
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Location = new System.Drawing.Point(157, 209);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(37, 13);
            this.lblTry.TabIndex = 93;
            this.lblTry.Text = "Tester";
            // 
            // txtMode
            // 
            this.txtMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMode.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMode.Location = new System.Drawing.Point(233, 149);
            this.txtMode.MaxLength = 30;
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(224, 22);
            this.txtMode.TabIndex = 13;
            this.txtMode.UseSystemPasswordChar = true;
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(230, 132);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(37, 13);
            this.lblMode.TabIndex = 12;
            this.lblMode.Text = "Mode:";
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.Location = new System.Drawing.Point(6, 46);
            this.txtIp.MaxLength = 15;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(209, 22);
            this.txtIp.TabIndex = 11;
            this.txtIp.UseSystemPasswordChar = true;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(3, 28);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(19, 13);
            this.lblIp.TabIndex = 10;
            this.lblIp.Text = "Ip:";
            // 
            // tabControlParametres
            // 
            this.tabControlParametres.Controls.Add(this.tbServeur);
            this.tabControlParametres.Controls.Add(this.tbDataBase);
            this.tabControlParametres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlParametres.Location = new System.Drawing.Point(3, 0);
            this.tabControlParametres.Name = "tabControlParametres";
            this.tabControlParametres.SelectedIndex = 0;
            this.tabControlParametres.Size = new System.Drawing.Size(474, 483);
            this.tabControlParametres.TabIndex = 90;
            // 
            // tbServeur
            // 
            this.tbServeur.BackColor = System.Drawing.SystemColors.Control;
            this.tbServeur.Controls.Add(this.lblSave);
            this.tbServeur.Controls.Add(this.txtMode);
            this.tbServeur.Controls.Add(this.lblTry);
            this.tbServeur.Controls.Add(this.lblMode);
            this.tbServeur.Controls.Add(this.picTester);
            this.tbServeur.Controls.Add(this.picModifier);
            this.tbServeur.Controls.Add(this.txtIp);
            this.tbServeur.Controls.Add(this.lblIp);
            this.tbServeur.Controls.Add(this.txtdatabase);
            this.tbServeur.Controls.Add(this.lbldatabase);
            this.tbServeur.Controls.Add(this.txtpassword);
            this.tbServeur.Controls.Add(this.lblpassword);
            this.tbServeur.Controls.Add(this.txtusername);
            this.tbServeur.Controls.Add(this.lblUsername);
            this.tbServeur.Controls.Add(this.txtport);
            this.tbServeur.Controls.Add(this.lblport);
            this.tbServeur.Location = new System.Drawing.Point(4, 22);
            this.tbServeur.Name = "tbServeur";
            this.tbServeur.Padding = new System.Windows.Forms.Padding(3);
            this.tbServeur.Size = new System.Drawing.Size(466, 457);
            this.tbServeur.TabIndex = 0;
            this.tbServeur.Text = "Serveur";
            // 
            // picTester
            // 
            this.picTester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTester.Image = global::SMS_Sender.Properties.Resources.Refresh_24x24;
            this.picTester.Location = new System.Drawing.Point(120, 209);
            this.picTester.Name = "picTester";
            this.picTester.Size = new System.Drawing.Size(31, 33);
            this.picTester.TabIndex = 92;
            this.picTester.TabStop = false;
            this.picTester.Click += new System.EventHandler(this.picTester_Click);
            // 
            // picModifier
            // 
            this.picModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picModifier.Image = global::SMS_Sender.Properties.Resources.Edit_24x24;
            this.picModifier.Location = new System.Drawing.Point(20, 209);
            this.picModifier.Name = "picModifier";
            this.picModifier.Size = new System.Drawing.Size(31, 33);
            this.picModifier.TabIndex = 91;
            this.picModifier.TabStop = false;
            this.picModifier.Click += new System.EventHandler(this.picModifier_Click);
            // 
            // txtdatabase
            // 
            this.txtdatabase.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtdatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatabase.Location = new System.Drawing.Point(6, 150);
            this.txtdatabase.MaxLength = 15;
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(209, 22);
            this.txtdatabase.TabIndex = 9;
            this.txtdatabase.UseSystemPasswordChar = true;
            // 
            // lbldatabase
            // 
            this.lbldatabase.AutoSize = true;
            this.lbldatabase.Location = new System.Drawing.Point(3, 132);
            this.lbldatabase.Name = "lbldatabase";
            this.lbldatabase.Size = new System.Drawing.Size(56, 13);
            this.lbldatabase.TabIndex = 8;
            this.lbldatabase.Text = "Database:";
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(233, 98);
            this.txtpassword.MaxLength = 30;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(224, 22);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(230, 81);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(56, 13);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtusername.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(233, 46);
            this.txtusername.MaxLength = 15;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(224, 22);
            this.txtusername.TabIndex = 5;
            this.txtusername.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(230, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "User-Name:";
            // 
            // txtport
            // 
            this.txtport.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtport.Location = new System.Drawing.Point(6, 98);
            this.txtport.MaxLength = 5;
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(209, 22);
            this.txtport.TabIndex = 3;
            this.txtport.UseSystemPasswordChar = true;
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(3, 79);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(29, 13);
            this.lblport.TabIndex = 2;
            this.lblport.Text = "Port:";
            // 
            // tbDataBase
            // 
            this.tbDataBase.BackColor = System.Drawing.SystemColors.Control;
            this.tbDataBase.Controls.Add(this.picTestedBD);
            this.tbDataBase.Controls.Add(this.picSaveBD);
            this.tbDataBase.Controls.Add(this.lblGuido);
            this.tbDataBase.Controls.Add(this.txtChamp5);
            this.tbDataBase.Controls.Add(this.lblChamp5);
            this.tbDataBase.Controls.Add(this.txtChamp4);
            this.tbDataBase.Controls.Add(this.lblChamp4);
            this.tbDataBase.Controls.Add(this.txtChamp3);
            this.tbDataBase.Controls.Add(this.lblChamp3);
            this.tbDataBase.Controls.Add(this.txtChamp2);
            this.tbDataBase.Controls.Add(this.lblChamp2);
            this.tbDataBase.Controls.Add(this.txtChamp1);
            this.tbDataBase.Controls.Add(this.lblChamp1);
            this.tbDataBase.Controls.Add(this.txtTable);
            this.tbDataBase.Controls.Add(this.lblTable);
            this.tbDataBase.Location = new System.Drawing.Point(4, 22);
            this.tbDataBase.Name = "tbDataBase";
            this.tbDataBase.Padding = new System.Windows.Forms.Padding(3);
            this.tbDataBase.Size = new System.Drawing.Size(466, 457);
            this.tbDataBase.TabIndex = 1;
            this.tbDataBase.Text = "Base de données";
            // 
            // picTestedBD
            // 
            this.picTestedBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTestedBD.Image = global::SMS_Sender.Properties.Resources.Refresh_24x24;
            this.picTestedBD.Location = new System.Drawing.Point(324, 132);
            this.picTestedBD.Name = "picTestedBD";
            this.picTestedBD.Size = new System.Drawing.Size(31, 33);
            this.picTestedBD.TabIndex = 122;
            this.picTestedBD.TabStop = false;
            this.picTestedBD.Click += new System.EventHandler(this.picTestedBD_Click);
            // 
            // picSaveBD
            // 
            this.picSaveBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSaveBD.Image = global::SMS_Sender.Properties.Resources.Edit_24x24;
            this.picSaveBD.Location = new System.Drawing.Point(324, 93);
            this.picSaveBD.Name = "picSaveBD";
            this.picSaveBD.Size = new System.Drawing.Size(31, 33);
            this.picSaveBD.TabIndex = 121;
            this.picSaveBD.TabStop = false;
            this.picSaveBD.Click += new System.EventHandler(this.picSaveBD_Click);
            // 
            // lblGuido
            // 
            this.lblGuido.Location = new System.Drawing.Point(6, 9);
            this.lblGuido.Name = "lblGuido";
            this.lblGuido.Size = new System.Drawing.Size(443, 69);
            this.lblGuido.TabIndex = 120;
            this.lblGuido.Text = "Configuration des 5 champs dont l\'application a besion, entre autre l\'id, le nom," +
    " le numero de téléphone et aussi le numero de référence, le type de réseau. En f" +
    "in renseigner le nom de la table";
            this.lblGuido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChamp5
            // 
            this.txtChamp5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtChamp5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChamp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChamp5.Location = new System.Drawing.Point(88, 233);
            this.txtChamp5.MaxLength = 15;
            this.txtChamp5.Name = "txtChamp5";
            this.txtChamp5.Size = new System.Drawing.Size(221, 22);
            this.txtChamp5.TabIndex = 119;
            this.txtChamp5.UseSystemPasswordChar = true;
            // 
            // lblChamp5
            // 
            this.lblChamp5.AutoSize = true;
            this.lblChamp5.Location = new System.Drawing.Point(19, 237);
            this.lblChamp5.Name = "lblChamp5";
            this.lblChamp5.Size = new System.Drawing.Size(55, 13);
            this.lblChamp5.TabIndex = 118;
            this.lblChamp5.Text = "Champ 5 :";
            // 
            // txtChamp4
            // 
            this.txtChamp4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtChamp4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChamp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChamp4.Location = new System.Drawing.Point(88, 205);
            this.txtChamp4.MaxLength = 15;
            this.txtChamp4.Name = "txtChamp4";
            this.txtChamp4.Size = new System.Drawing.Size(221, 22);
            this.txtChamp4.TabIndex = 117;
            this.txtChamp4.UseSystemPasswordChar = true;
            // 
            // lblChamp4
            // 
            this.lblChamp4.AutoSize = true;
            this.lblChamp4.Location = new System.Drawing.Point(19, 209);
            this.lblChamp4.Name = "lblChamp4";
            this.lblChamp4.Size = new System.Drawing.Size(55, 13);
            this.lblChamp4.TabIndex = 116;
            this.lblChamp4.Text = "Champ 4 :";
            // 
            // txtChamp3
            // 
            this.txtChamp3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtChamp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChamp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChamp3.Location = new System.Drawing.Point(88, 177);
            this.txtChamp3.MaxLength = 15;
            this.txtChamp3.Name = "txtChamp3";
            this.txtChamp3.Size = new System.Drawing.Size(221, 22);
            this.txtChamp3.TabIndex = 115;
            this.txtChamp3.UseSystemPasswordChar = true;
            // 
            // lblChamp3
            // 
            this.lblChamp3.AutoSize = true;
            this.lblChamp3.Location = new System.Drawing.Point(19, 181);
            this.lblChamp3.Name = "lblChamp3";
            this.lblChamp3.Size = new System.Drawing.Size(55, 13);
            this.lblChamp3.TabIndex = 114;
            this.lblChamp3.Text = "Champ 3 :";
            // 
            // txtChamp2
            // 
            this.txtChamp2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtChamp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChamp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChamp2.Location = new System.Drawing.Point(88, 149);
            this.txtChamp2.MaxLength = 15;
            this.txtChamp2.Name = "txtChamp2";
            this.txtChamp2.Size = new System.Drawing.Size(221, 22);
            this.txtChamp2.TabIndex = 113;
            this.txtChamp2.UseSystemPasswordChar = true;
            // 
            // lblChamp2
            // 
            this.lblChamp2.AutoSize = true;
            this.lblChamp2.Location = new System.Drawing.Point(19, 153);
            this.lblChamp2.Name = "lblChamp2";
            this.lblChamp2.Size = new System.Drawing.Size(55, 13);
            this.lblChamp2.TabIndex = 112;
            this.lblChamp2.Text = "Champ 2 :";
            // 
            // txtChamp1
            // 
            this.txtChamp1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtChamp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChamp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChamp1.Location = new System.Drawing.Point(88, 121);
            this.txtChamp1.MaxLength = 15;
            this.txtChamp1.Name = "txtChamp1";
            this.txtChamp1.Size = new System.Drawing.Size(221, 22);
            this.txtChamp1.TabIndex = 111;
            this.txtChamp1.UseSystemPasswordChar = true;
            // 
            // lblChamp1
            // 
            this.lblChamp1.AutoSize = true;
            this.lblChamp1.Location = new System.Drawing.Point(19, 125);
            this.lblChamp1.Name = "lblChamp1";
            this.lblChamp1.Size = new System.Drawing.Size(55, 13);
            this.lblChamp1.TabIndex = 110;
            this.lblChamp1.Text = "Champ 1 :";
            // 
            // txtTable
            // 
            this.txtTable.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTable.Location = new System.Drawing.Point(88, 93);
            this.txtTable.MaxLength = 15;
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(221, 22);
            this.txtTable.TabIndex = 109;
            this.txtTable.UseSystemPasswordChar = true;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(19, 97);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(40, 13);
            this.lblTable.TabIndex = 108;
            this.lblTable.Text = "Table :";
            // 
            // pnlBordGauche
            // 
            this.pnlBordGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBordGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBordGauche.Location = new System.Drawing.Point(0, 0);
            this.pnlBordGauche.Name = "pnlBordGauche";
            this.pnlBordGauche.Size = new System.Drawing.Size(3, 483);
            this.pnlBordGauche.TabIndex = 88;
            // 
            // pnlBaodDroit
            // 
            this.pnlBaodDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBaodDroit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBaodDroit.Location = new System.Drawing.Point(477, 0);
            this.pnlBaodDroit.Name = "pnlBaodDroit";
            this.pnlBaodDroit.Size = new System.Drawing.Size(3, 483);
            this.pnlBaodDroit.TabIndex = 89;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(480, 483);
            this.Controls.Add(this.tabControlParametres);
            this.Controls.Add(this.pnlBordGauche);
            this.Controls.Add(this.pnlBaodDroit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Paramètres de connexion";
            this.Load += new System.EventHandler(this.frmParametres_Load);
            this.tabControlParametres.ResumeLayout(false);
            this.tbServeur.ResumeLayout(false);
            this.tbServeur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModifier)).EndInit();
            this.tbDataBase.ResumeLayout(false);
            this.tbDataBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTestedBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.PictureBox picTester;
        private System.Windows.Forms.PictureBox picModifier;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TabControl tabControlParametres;
        private System.Windows.Forms.TabPage tbServeur;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label lbldatabase;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.Panel pnlBordGauche;
        private System.Windows.Forms.Panel pnlBaodDroit;
        private System.Windows.Forms.TabPage tbDataBase;
        private System.Windows.Forms.PictureBox picTestedBD;
        private System.Windows.Forms.PictureBox picSaveBD;
        private System.Windows.Forms.Label lblGuido;
        private System.Windows.Forms.TextBox txtChamp5;
        private System.Windows.Forms.Label lblChamp5;
        private System.Windows.Forms.TextBox txtChamp4;
        private System.Windows.Forms.Label lblChamp4;
        private System.Windows.Forms.TextBox txtChamp3;
        private System.Windows.Forms.Label lblChamp3;
        private System.Windows.Forms.TextBox txtChamp2;
        private System.Windows.Forms.Label lblChamp2;
        private System.Windows.Forms.TextBox txtChamp1;
        private System.Windows.Forms.Label lblChamp1;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label lblTable;
    }
}