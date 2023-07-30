namespace SMS_Sender
{
    partial class frmSMS_SENDER
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSMS_SENDER));
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.gpConfigMODEM = new System.Windows.Forms.GroupBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.cboModemsConnected = new System.Windows.Forms.ComboBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gpListeContact = new System.Windows.Forms.GroupBox();
            this.btnChoisirDb = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.liste_contact = new System.Windows.Forms.ListBox();
            this.openFileDialogContact = new System.Windows.Forms.OpenFileDialog();
            this.liste_receptif = new System.Windows.Forms.ListBox();
            this.gpValidContact = new System.Windows.Forms.GroupBox();
            this.btnUnAller = new System.Windows.Forms.Button();
            this.btnTousRetour = new System.Windows.Forms.Button();
            this.btnUnRetour = new System.Windows.Forms.Button();
            this.btmTousAller = new System.Windows.Forms.Button();
            this.menuStripBar = new System.Windows.Forms.MenuStrip();
            this.numèroDeTéléphoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresDeConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aproposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.gpConfigServer = new System.Windows.Forms.GroupBox();
            this.gpAPI = new System.Windows.Forms.GroupBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountSID = new System.Windows.Forms.TextBox();
            this.gpConfigContacts = new System.Windows.Forms.GroupBox();
            this.gpConfigMessage = new System.Windows.Forms.GroupBox();
            this.gpConsole = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.contextMenuStripCosole = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.effacerLaConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbGSM = new System.Windows.Forms.RadioButton();
            this.rbAPI = new System.Windows.Forms.RadioButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNbrSMS_Envoyer = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripSubBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpConfigMODEM.SuspendLayout();
            this.gpListeContact.SuspendLayout();
            this.gpValidContact.SuspendLayout();
            this.menuStripBar.SuspendLayout();
            this.gpConfigServer.SuspendLayout();
            this.gpAPI.SuspendLayout();
            this.gpConfigContacts.SuspendLayout();
            this.gpConfigMessage.SuspendLayout();
            this.gpConsole.SuspendLayout();
            this.contextMenuStripCosole.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStripSubBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPhoneNumber.Location = new System.Drawing.Point(44, 44);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(92, 21);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMessage.Location = new System.Drawing.Point(8, 66);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(503, 116);
            this.txtMessage.TabIndex = 1;
            // 
            // gpConfigMODEM
            // 
            this.gpConfigMODEM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpConfigMODEM.Controls.Add(this.btnConnexion);
            this.gpConfigMODEM.Controls.Add(this.btnConnection);
            this.gpConfigMODEM.Controls.Add(this.label2);
            this.gpConfigMODEM.Controls.Add(this.lblPort);
            this.gpConfigMODEM.Controls.Add(this.txtPort);
            this.gpConfigMODEM.Controls.Add(this.cboModemsConnected);
            this.gpConfigMODEM.Location = new System.Drawing.Point(3, 18);
            this.gpConfigMODEM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConfigMODEM.Name = "gpConfigMODEM";
            this.gpConfigMODEM.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConfigMODEM.Size = new System.Drawing.Size(328, 352);
            this.gpConfigMODEM.TabIndex = 5;
            this.gpConfigMODEM.TabStop = false;
            this.gpConfigMODEM.Text = "MODEM";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(159, 82);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(95, 23);
            this.btnConnexion.TabIndex = 10;
            this.btnConnexion.Text = "Deconnecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnDeconnection_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(159, 53);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(95, 23);
            this.btnConnection.TabIndex = 9;
            this.btnConnection.Text = "Actualiser";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port :";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(9, 26);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(57, 16);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Modem :";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPort.Location = new System.Drawing.Point(71, 55);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(82, 21);
            this.txtPort.TabIndex = 7;
            // 
            // cboModemsConnected
            // 
            this.cboModemsConnected.BackColor = System.Drawing.SystemColors.Control;
            this.cboModemsConnected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModemsConnected.FormattingEnabled = true;
            this.cboModemsConnected.Location = new System.Drawing.Point(71, 21);
            this.cboModemsConnected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboModemsConnected.Name = "cboModemsConnected";
            this.cboModemsConnected.Size = new System.Drawing.Size(234, 24);
            this.cboModemsConnected.TabIndex = 4;
            this.cboModemsConnected.SelectedIndexChanged += new System.EventHandler(this.cbo_port_SelectedIndexChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 48);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(26, 16);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "N° :";
            // 
            // gpListeContact
            // 
            this.gpListeContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpListeContact.Controls.Add(this.btnChoisirDb);
            this.gpListeContact.Controls.Add(this.btnContact);
            this.gpListeContact.Controls.Add(this.liste_contact);
            this.gpListeContact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListeContact.Location = new System.Drawing.Point(203, 23);
            this.gpListeContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpListeContact.Name = "gpListeContact";
            this.gpListeContact.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpListeContact.Size = new System.Drawing.Size(148, 324);
            this.gpListeContact.TabIndex = 7;
            this.gpListeContact.TabStop = false;
            this.gpListeContact.Text = "Liste des contacts";
            // 
            // btnChoisirDb
            // 
            this.btnChoisirDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoisirDb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnChoisirDb.Location = new System.Drawing.Point(10, 54);
            this.btnChoisirDb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChoisirDb.Name = "btnChoisirDb";
            this.btnChoisirDb.Size = new System.Drawing.Size(132, 28);
            this.btnChoisirDb.TabIndex = 1;
            this.btnChoisirDb.Text = "Choisir dans la Db";
            this.btnChoisirDb.UseVisualStyleBackColor = false;
            this.btnChoisirDb.Click += new System.EventHandler(this.btnChoisirDb_Click);
            // 
            // btnContact
            // 
            this.btnContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContact.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnContact.Location = new System.Drawing.Point(10, 22);
            this.btnContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(132, 28);
            this.btnContact.TabIndex = 0;
            this.btnContact.Text = "Charger un fichier";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // liste_contact
            // 
            this.liste_contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liste_contact.BackColor = System.Drawing.SystemColors.MenuBar;
            this.liste_contact.FormattingEnabled = true;
            this.liste_contact.ItemHeight = 16;
            this.liste_contact.Location = new System.Drawing.Point(10, 90);
            this.liste_contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.liste_contact.Name = "liste_contact";
            this.liste_contact.Size = new System.Drawing.Size(132, 212);
            this.liste_contact.TabIndex = 0;
            this.liste_contact.DoubleClick += new System.EventHandler(this.liste_contact_DoubleClick);
            // 
            // openFileDialogContact
            // 
            this.openFileDialogContact.FileName = "openFileDialog1";
            // 
            // liste_receptif
            // 
            this.liste_receptif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liste_receptif.BackColor = System.Drawing.SystemColors.MenuBar;
            this.liste_receptif.FormattingEnabled = true;
            this.liste_receptif.ItemHeight = 16;
            this.liste_receptif.Location = new System.Drawing.Point(10, 90);
            this.liste_receptif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.liste_receptif.Name = "liste_receptif";
            this.liste_receptif.Size = new System.Drawing.Size(132, 212);
            this.liste_receptif.TabIndex = 8;
            this.liste_receptif.Click += new System.EventHandler(this.liste_receptif_Click);
            // 
            // gpValidContact
            // 
            this.gpValidContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpValidContact.Controls.Add(this.liste_receptif);
            this.gpValidContact.Controls.Add(this.txtPhoneNumber);
            this.gpValidContact.Controls.Add(this.lblPhoneNumber);
            this.gpValidContact.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gpValidContact.Location = new System.Drawing.Point(8, 23);
            this.gpValidContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpValidContact.Name = "gpValidContact";
            this.gpValidContact.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpValidContact.Size = new System.Drawing.Size(148, 324);
            this.gpValidContact.TabIndex = 9;
            this.gpValidContact.TabStop = false;
            this.gpValidContact.Text = "Contact réceptif";
            // 
            // btnUnAller
            // 
            this.btnUnAller.Location = new System.Drawing.Point(164, 130);
            this.btnUnAller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnAller.Name = "btnUnAller";
            this.btnUnAller.Size = new System.Drawing.Size(31, 28);
            this.btnUnAller.TabIndex = 10;
            this.btnUnAller.Text = "<";
            this.btnUnAller.UseVisualStyleBackColor = true;
            this.btnUnAller.Click += new System.EventHandler(this.btnUnAller_Click);
            // 
            // btnTousRetour
            // 
            this.btnTousRetour.Location = new System.Drawing.Point(164, 251);
            this.btnTousRetour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTousRetour.Name = "btnTousRetour";
            this.btnTousRetour.Size = new System.Drawing.Size(31, 28);
            this.btnTousRetour.TabIndex = 11;
            this.btnTousRetour.Text = ">>";
            this.btnTousRetour.UseVisualStyleBackColor = true;
            this.btnTousRetour.Click += new System.EventHandler(this.btnTousRetour_Click);
            // 
            // btnUnRetour
            // 
            this.btnUnRetour.Location = new System.Drawing.Point(164, 215);
            this.btnUnRetour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnRetour.Name = "btnUnRetour";
            this.btnUnRetour.Size = new System.Drawing.Size(31, 28);
            this.btnUnRetour.TabIndex = 12;
            this.btnUnRetour.Text = ">";
            this.btnUnRetour.UseVisualStyleBackColor = true;
            this.btnUnRetour.Click += new System.EventHandler(this.btnUnRetour_Click);
            // 
            // btmTousAller
            // 
            this.btmTousAller.Location = new System.Drawing.Point(164, 162);
            this.btmTousAller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btmTousAller.Name = "btmTousAller";
            this.btmTousAller.Size = new System.Drawing.Size(31, 28);
            this.btmTousAller.TabIndex = 13;
            this.btmTousAller.Text = "<<";
            this.btmTousAller.UseVisualStyleBackColor = true;
            this.btmTousAller.Click += new System.EventHandler(this.btmTousAller_Click);
            // 
            // menuStripBar
            // 
            this.menuStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numèroDeTéléphoneToolStripMenuItem,
            this.paramètresDeConnectionToolStripMenuItem,
            this.aproposToolStripMenuItem});
            this.menuStripBar.Location = new System.Drawing.Point(0, 0);
            this.menuStripBar.Name = "menuStripBar";
            this.menuStripBar.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripBar.Size = new System.Drawing.Size(904, 24);
            this.menuStripBar.TabIndex = 14;
            this.menuStripBar.Text = "menuStrip1";
            // 
            // numèroDeTéléphoneToolStripMenuItem
            // 
            this.numèroDeTéléphoneToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.numèroDeTéléphoneToolStripMenuItem.Name = "numèroDeTéléphoneToolStripMenuItem";
            this.numèroDeTéléphoneToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.numèroDeTéléphoneToolStripMenuItem.Text = "Numéro de téléphone";
            this.numèroDeTéléphoneToolStripMenuItem.Click += new System.EventHandler(this.numèroDeTéléphoneToolStripMenuItem_Click);
            // 
            // paramètresDeConnectionToolStripMenuItem
            // 
            this.paramètresDeConnectionToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.paramètresDeConnectionToolStripMenuItem.Name = "paramètresDeConnectionToolStripMenuItem";
            this.paramètresDeConnectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.paramètresDeConnectionToolStripMenuItem.Text = "Paramètres";
            this.paramètresDeConnectionToolStripMenuItem.Click += new System.EventHandler(this.paramètresDeConnectionToolStripMenuItem_Click);
            // 
            // aproposToolStripMenuItem
            // 
            this.aproposToolStripMenuItem.Name = "aproposToolStripMenuItem";
            this.aproposToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.aproposToolStripMenuItem.Text = "Apropos";
            this.aproposToolStripMenuItem.Click += new System.EventHandler(this.aproposToolStripMenuItem_Click);
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnvoyer.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEnvoyer.BackgroundImage = global::SMS_Sender.Properties.Resources.messenger;
            this.btnEnvoyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.ForeColor = System.Drawing.Color.Black;
            this.btnEnvoyer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvoyer.Location = new System.Drawing.Point(305, 22);
            this.btnEnvoyer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(206, 30);
            this.btnEnvoyer.TabIndex = 0;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // gpConfigServer
            // 
            this.gpConfigServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpConfigServer.Controls.Add(this.gpAPI);
            this.gpConfigServer.Controls.Add(this.gpConfigMODEM);
            this.gpConfigServer.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gpConfigServer.Location = new System.Drawing.Point(6, 7);
            this.gpConfigServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConfigServer.Name = "gpConfigServer";
            this.gpConfigServer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConfigServer.Size = new System.Drawing.Size(884, 374);
            this.gpConfigServer.TabIndex = 17;
            this.gpConfigServer.TabStop = false;
            this.gpConfigServer.Text = "Configuration";
            // 
            // gpAPI
            // 
            this.gpAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpAPI.Controls.Add(this.btnEnregistrer);
            this.gpAPI.Controls.Add(this.label4);
            this.gpAPI.Controls.Add(this.txtNumber);
            this.gpAPI.Controls.Add(this.label3);
            this.gpAPI.Controls.Add(this.txtAuthToken);
            this.gpAPI.Controls.Add(this.label1);
            this.gpAPI.Controls.Add(this.txtAccountSID);
            this.gpAPI.Location = new System.Drawing.Point(337, 18);
            this.gpAPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpAPI.Name = "gpAPI";
            this.gpAPI.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpAPI.Size = new System.Drawing.Size(541, 352);
            this.gpAPI.TabIndex = 6;
            this.gpAPI.TabStop = false;
            this.gpAPI.Text = "API TWILIO";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnregistrer.Location = new System.Drawing.Point(246, 197);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(95, 23);
            this.btnEnregistrer.TabIndex = 11;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number :";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(34, 161);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(501, 21);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Auth Token :";
            // 
            // txtAuthToken
            // 
            this.txtAuthToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthToken.Location = new System.Drawing.Point(34, 109);
            this.txtAuthToken.Name = "txtAuthToken";
            this.txtAuthToken.Size = new System.Drawing.Size(501, 21);
            this.txtAuthToken.TabIndex = 2;
            this.txtAuthToken.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account SID :";
            // 
            // txtAccountSID
            // 
            this.txtAccountSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountSID.Location = new System.Drawing.Point(34, 60);
            this.txtAccountSID.Name = "txtAccountSID";
            this.txtAccountSID.Size = new System.Drawing.Size(501, 21);
            this.txtAccountSID.TabIndex = 0;
            this.txtAccountSID.UseSystemPasswordChar = true;
            // 
            // gpConfigContacts
            // 
            this.gpConfigContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpConfigContacts.Controls.Add(this.gpValidContact);
            this.gpConfigContacts.Controls.Add(this.gpListeContact);
            this.gpConfigContacts.Controls.Add(this.btnUnRetour);
            this.gpConfigContacts.Controls.Add(this.btnUnAller);
            this.gpConfigContacts.Controls.Add(this.btmTousAller);
            this.gpConfigContacts.Controls.Add(this.btnTousRetour);
            this.gpConfigContacts.Location = new System.Drawing.Point(6, 7);
            this.gpConfigContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConfigContacts.Name = "gpConfigContacts";
            this.gpConfigContacts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConfigContacts.Size = new System.Drawing.Size(359, 355);
            this.gpConfigContacts.TabIndex = 18;
            this.gpConfigContacts.TabStop = false;
            this.gpConfigContacts.Text = "Gerer les contacts";
            // 
            // gpConfigMessage
            // 
            this.gpConfigMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpConfigMessage.Controls.Add(this.btnEnvoyer);
            this.gpConfigMessage.Controls.Add(this.txtMessage);
            this.gpConfigMessage.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gpConfigMessage.Location = new System.Drawing.Point(371, 169);
            this.gpConfigMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConfigMessage.Name = "gpConfigMessage";
            this.gpConfigMessage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConfigMessage.Size = new System.Drawing.Size(517, 190);
            this.gpConfigMessage.TabIndex = 19;
            this.gpConfigMessage.TabStop = false;
            this.gpConfigMessage.Text = "Message";
            // 
            // gpConsole
            // 
            this.gpConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpConsole.Controls.Add(this.txtConsole);
            this.gpConsole.Location = new System.Drawing.Point(371, 34);
            this.gpConsole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConsole.Name = "gpConsole";
            this.gpConsole.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpConsole.Size = new System.Drawing.Size(511, 131);
            this.gpConsole.TabIndex = 21;
            this.gpConsole.TabStop = false;
            this.gpConsole.Text = "Console";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.ContextMenuStrip = this.contextMenuStripCosole;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtConsole.Location = new System.Drawing.Point(3, 18);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsole.MaxLength = 9999999;
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(505, 109);
            this.txtConsole.TabIndex = 1;
            // 
            // contextMenuStripCosole
            // 
            this.contextMenuStripCosole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effacerLaConsoleToolStripMenuItem});
            this.contextMenuStripCosole.Name = "contextMenuStripCosole";
            this.contextMenuStripCosole.Size = new System.Drawing.Size(167, 26);
            // 
            // effacerLaConsoleToolStripMenuItem
            // 
            this.effacerLaConsoleToolStripMenuItem.Name = "effacerLaConsoleToolStripMenuItem";
            this.effacerLaConsoleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.effacerLaConsoleToolStripMenuItem.Text = "Effacer la console";
            this.effacerLaConsoleToolStripMenuItem.Click += new System.EventHandler(this.effacerLaConsoleToolStripMenuItem_Click);
            // 
            // rbGSM
            // 
            this.rbGSM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbGSM.AutoSize = true;
            this.rbGSM.Checked = true;
            this.rbGSM.Location = new System.Drawing.Point(607, 7);
            this.rbGSM.Name = "rbGSM";
            this.rbGSM.Size = new System.Drawing.Size(154, 20);
            this.rbGSM.TabIndex = 22;
            this.rbGSM.TabStop = true;
            this.rbGSM.Text = "Interface GSM MODEM";
            this.rbGSM.UseVisualStyleBackColor = true;
            // 
            // rbAPI
            // 
            this.rbAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAPI.AutoSize = true;
            this.rbAPI.Location = new System.Drawing.Point(767, 7);
            this.rbAPI.Name = "rbAPI";
            this.rbAPI.Size = new System.Drawing.Size(115, 20);
            this.rbAPI.TabIndex = 23;
            this.rbAPI.Text = "Interface TWILIO";
            this.rbAPI.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(904, 417);
            this.tabControlMain.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.gpConfigServer);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configurations";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.gpConfigContacts);
            this.tabPage2.Controls.Add(this.gpConsole);
            this.tabPage2.Controls.Add(this.gpConfigMessage);
            this.tabPage2.Controls.Add(this.rbAPI);
            this.tabPage2.Controls.Add(this.rbGSM);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Message";
            // 
            // lblNbrSMS_Envoyer
            // 
            this.lblNbrSMS_Envoyer.Name = "lblNbrSMS_Envoyer";
            this.lblNbrSMS_Envoyer.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStripSubBar
            // 
            this.statusStripSubBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNbrSMS_Envoyer,
            this.toolStripStatusLabel1});
            this.statusStripSubBar.Location = new System.Drawing.Point(0, 441);
            this.statusStripSubBar.Name = "statusStripSubBar";
            this.statusStripSubBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripSubBar.Size = new System.Drawing.Size(904, 22);
            this.statusStripSubBar.TabIndex = 16;
            this.statusStripSubBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Sms sender";
            // 
            // frmSMS_SENDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 463);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripSubBar);
            this.Controls.Add(this.menuStripBar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripBar;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSMS_SENDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSMS_SENDER_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gpConfigMODEM.ResumeLayout(false);
            this.gpConfigMODEM.PerformLayout();
            this.gpListeContact.ResumeLayout(false);
            this.gpValidContact.ResumeLayout(false);
            this.gpValidContact.PerformLayout();
            this.menuStripBar.ResumeLayout(false);
            this.menuStripBar.PerformLayout();
            this.gpConfigServer.ResumeLayout(false);
            this.gpAPI.ResumeLayout(false);
            this.gpAPI.PerformLayout();
            this.gpConfigContacts.ResumeLayout(false);
            this.gpConfigMessage.ResumeLayout(false);
            this.gpConfigMessage.PerformLayout();
            this.gpConsole.ResumeLayout(false);
            this.gpConsole.PerformLayout();
            this.contextMenuStripCosole.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStripSubBar.ResumeLayout(false);
            this.statusStripSubBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.GroupBox gpConfigMODEM;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ComboBox cboModemsConnected;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox gpListeContact;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.OpenFileDialog openFileDialogContact;
        private System.Windows.Forms.ListBox liste_receptif;
        private System.Windows.Forms.GroupBox gpValidContact;
        private System.Windows.Forms.Button btnUnAller;
        private System.Windows.Forms.Button btnTousRetour;
        private System.Windows.Forms.Button btnUnRetour;
        private System.Windows.Forms.Button btmTousAller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.MenuStrip menuStripBar;
        private System.Windows.Forms.ToolStripMenuItem paramètresDeConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numèroDeTéléphoneToolStripMenuItem;
        public System.Windows.Forms.ListBox liste_contact;
        private System.Windows.Forms.GroupBox gpConfigServer;
        private System.Windows.Forms.GroupBox gpConfigContacts;
        private System.Windows.Forms.GroupBox gpConfigMessage;
        private System.Windows.Forms.GroupBox gpConsole;
        private System.Windows.Forms.TextBox txtConsole;
        public System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RadioButton rbGSM;
        private System.Windows.Forms.RadioButton rbAPI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCosole;
        private System.Windows.Forms.ToolStripMenuItem effacerLaConsoleToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.GroupBox gpAPI;
        private System.Windows.Forms.ToolStripStatusLabel lblNbrSMS_Envoyer;
        private System.Windows.Forms.StatusStrip statusStripSubBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountSID;
        private System.Windows.Forms.Button btnChoisirDb;
        private System.Windows.Forms.ToolStripMenuItem aproposToolStripMenuItem;
    }
}

