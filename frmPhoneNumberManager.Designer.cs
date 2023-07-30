namespace SMS_Sender
{
    partial class frmPhoneNumberManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhoneNumberManager));
            this.dgvPhoneNumber = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reseau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnCharger = new System.Windows.Forms.Button();
            this.btnNewArriv = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNoms = new System.Windows.Forms.Label();
            this.lblReseau = new System.Windows.Forms.Label();
            this.btnRecupNumber = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.cboReseau = new System.Windows.Forms.ComboBox();
            this.lblNumRef = new System.Windows.Forms.Label();
            this.txtNumeroRef = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhoneNumber
            // 
            this.dgvPhoneNumber.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvPhoneNumber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhoneNumber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhoneNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneNumber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.noms,
            this.reseau,
            this.numero,
            this.reference});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhoneNumber.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhoneNumber.Location = new System.Drawing.Point(15, 101);
            this.dgvPhoneNumber.Name = "dgvPhoneNumber";
            this.dgvPhoneNumber.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhoneNumber.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvPhoneNumber.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPhoneNumber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhoneNumber.Size = new System.Drawing.Size(856, 244);
            this.dgvPhoneNumber.TabIndex = 12;
            this.dgvPhoneNumber.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhoneNumber_CellClick);
            this.dgvPhoneNumber.SelectionChanged += new System.EventHandler(this.dgvPhoneNumber_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 70;
            // 
            // noms
            // 
            this.noms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noms.DataPropertyName = "noms";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.noms.DefaultCellStyle = dataGridViewCellStyle4;
            this.noms.HeaderText = "Noms";
            this.noms.Name = "noms";
            this.noms.ReadOnly = true;
            // 
            // reseau
            // 
            this.reseau.DataPropertyName = "reseau";
            this.reseau.HeaderText = "Réseau";
            this.reseau.Name = "reseau";
            this.reseau.ReadOnly = true;
            this.reseau.Width = 250;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numero.DefaultCellStyle = dataGridViewCellStyle5;
            this.numero.HeaderText = "Numéro";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 200;
            // 
            // reference
            // 
            this.reference.DataPropertyName = "reference";
            this.reference.HeaderText = "Réference";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            this.reference.Width = 200;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(624, 394);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(50, 26);
            this.btnAjouter.TabIndex = 144;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.Color.Black;
            this.btnSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupp.Location = new System.Drawing.Point(808, 394);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(63, 26);
            this.btnSupp.TabIndex = 143;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnCharger
            // 
            this.btnCharger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCharger.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCharger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharger.ForeColor = System.Drawing.Color.Black;
            this.btnCharger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCharger.Location = new System.Drawing.Point(554, 394);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(64, 26);
            this.btnCharger.TabIndex = 145;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = false;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // btnNewArriv
            // 
            this.btnNewArriv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewArriv.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnNewArriv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewArriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewArriv.ForeColor = System.Drawing.Color.Black;
            this.btnNewArriv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewArriv.Location = new System.Drawing.Point(680, 394);
            this.btnNewArriv.Name = "btnNewArriv";
            this.btnNewArriv.Size = new System.Drawing.Size(61, 26);
            this.btnNewArriv.TabIndex = 141;
            this.btnNewArriv.Text = "Nouveau";
            this.btnNewArriv.UseVisualStyleBackColor = false;
            this.btnNewArriv.Click += new System.EventHandler(this.btnNewArriv_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(747, 394);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(55, 26);
            this.btnModifier.TabIndex = 142;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNom.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(180, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(219, 22);
            this.txtNom.TabIndex = 146;
            // 
            // lblNoms
            // 
            this.lblNoms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoms.AutoSize = true;
            this.lblNoms.Location = new System.Drawing.Point(124, 25);
            this.lblNoms.Name = "lblNoms";
            this.lblNoms.Size = new System.Drawing.Size(40, 13);
            this.lblNoms.TabIndex = 148;
            this.lblNoms.Text = "Noms :";
            // 
            // lblReseau
            // 
            this.lblReseau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReseau.AutoSize = true;
            this.lblReseau.Location = new System.Drawing.Point(405, 25);
            this.lblReseau.Name = "lblReseau";
            this.lblReseau.Size = new System.Drawing.Size(50, 13);
            this.lblReseau.TabIndex = 149;
            this.lblReseau.Text = "Réseau :";
            // 
            // btnRecupNumber
            // 
            this.btnRecupNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecupNumber.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRecupNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecupNumber.ForeColor = System.Drawing.Color.Black;
            this.btnRecupNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecupNumber.Location = new System.Drawing.Point(433, 394);
            this.btnRecupNumber.Name = "btnRecupNumber";
            this.btnRecupNumber.Size = new System.Drawing.Size(115, 26);
            this.btnRecupNumber.TabIndex = 150;
            this.btnRecupNumber.Text = "Recuper la séléction";
            this.btnRecupNumber.UseVisualStyleBackColor = false;
            this.btnRecupNumber.Click += new System.EventHandler(this.btnRecupNumber_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumero.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(180, 52);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(219, 22);
            this.txtNumero.TabIndex = 149;
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(124, 53);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(50, 13);
            this.lblNumber.TabIndex = 150;
            this.lblNumber.Text = "Numèro :";
            // 
            // cboReseau
            // 
            this.cboReseau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboReseau.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cboReseau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReseau.FormattingEnabled = true;
            this.cboReseau.Items.AddRange(new object[] {
            "Vodacom",
            "AFRICELL",
            "Airtel",
            "Orange",
            "Autres"});
            this.cboReseau.Location = new System.Drawing.Point(524, 25);
            this.cboReseau.Name = "cboReseau";
            this.cboReseau.Size = new System.Drawing.Size(234, 21);
            this.cboReseau.TabIndex = 152;
            // 
            // lblNumRef
            // 
            this.lblNumRef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumRef.AutoSize = true;
            this.lblNumRef.Location = new System.Drawing.Point(405, 53);
            this.lblNumRef.Name = "lblNumRef";
            this.lblNumRef.Size = new System.Drawing.Size(113, 13);
            this.lblNumRef.TabIndex = 151;
            this.lblNumRef.Text = "Numéro de référence :";
            // 
            // txtNumeroRef
            // 
            this.txtNumeroRef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroRef.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNumeroRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRef.Location = new System.Drawing.Point(524, 52);
            this.txtNumeroRef.Name = "txtNumeroRef";
            this.txtNumeroRef.Size = new System.Drawing.Size(234, 22);
            this.txtNumeroRef.TabIndex = 150;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 459);
            this.splitter1.TabIndex = 152;
            this.splitter1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(83, 394);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 22);
            this.txtSearch.TabIndex = 155;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 398);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 13);
            this.lblSearch.TabIndex = 156;
            this.lblSearch.Text = "Recherche :";
            // 
            // frmPhoneNumberManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(883, 459);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cboReseau);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNumRef);
            this.Controls.Add(this.lblNoms);
            this.Controls.Add(this.txtNumeroRef);
            this.Controls.Add(this.lblReseau);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnRecupNumber);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnNewArriv);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dgvPhoneNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhoneNumberManager";
            this.Text = "Numero de téléphone";
            this.Load += new System.EventHandler(this.frmNumero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhoneNumber;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Button btnNewArriv;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNoms;
        private System.Windows.Forms.Label lblReseau;
        private System.Windows.Forms.Button btnRecupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn noms;
        private System.Windows.Forms.DataGridViewTextBoxColumn reseau;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNumRef;
        private System.Windows.Forms.TextBox txtNumeroRef;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox cboReseau;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}