
namespace PPE
{
    partial class WindowUtilisateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox_Role_user = new System.Windows.Forms.ComboBox();
            this.label_role_user = new System.Windows.Forms.Label();
            this.label_pays_user = new System.Windows.Forms.Label();
            this.textBox_Pays_user = new System.Windows.Forms.TextBox();
            this.textBox_Adresse_user = new System.Windows.Forms.TextBox();
            this.textBox_Anniv_user = new System.Windows.Forms.TextBox();
            this.textBox_Numero_user = new System.Windows.Forms.TextBox();
            this.textBox_Nom_user = new System.Windows.Forms.TextBox();
            this.textBox_Prenom_user = new System.Windows.Forms.TextBox();
            this.textBox_Email_user = new System.Windows.Forms.TextBox();
            this.textBox_Username_user = new System.Windows.Forms.TextBox();
            this.textBox_ID_user = new System.Windows.Forms.TextBox();
            this.label_adresse_user = new System.Windows.Forms.Label();
            this.label_birthday_user = new System.Windows.Forms.Label();
            this.label_numero_user = new System.Windows.Forms.Label();
            this.label_nom_user = new System.Windows.Forms.Label();
            this.label_prenom_user = new System.Windows.Forms.Label();
            this.label_email_user = new System.Windows.Forms.Label();
            this.label_Name_user = new System.Windows.Forms.Label();
            this.label_id_user = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.button_clear_ID = new System.Windows.Forms.Button();
            this.button_clear_username = new System.Windows.Forms.Button();
            this.button_clear_prenom = new System.Windows.Forms.Button();
            this.button_clear_nom = new System.Windows.Forms.Button();
            this.button_clear_email = new System.Windows.Forms.Button();
            this.button_clear_anniversaire = new System.Windows.Forms.Button();
            this.button_clear_numero = new System.Windows.Forms.Button();
            this.button_clear_adresse = new System.Windows.Forms.Button();
            this.button_clear_pays = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Role_user
            // 
            this.comboBox_Role_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Role_user.BackColor = System.Drawing.Color.White;
            this.comboBox_Role_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Role_user.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Role_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Role_user.FormattingEnabled = true;
            this.comboBox_Role_user.Items.AddRange(new object[] {
            "user",
            "admin",
            "disable",
            "banned"});
            this.comboBox_Role_user.Location = new System.Drawing.Point(594, 692);
            this.comboBox_Role_user.Name = "comboBox_Role_user";
            this.comboBox_Role_user.Size = new System.Drawing.Size(185, 26);
            this.comboBox_Role_user.TabIndex = 57;
            this.comboBox_Role_user.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // label_role_user
            // 
            this.label_role_user.AllowDrop = true;
            this.label_role_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_role_user.AutoSize = true;
            this.label_role_user.Location = new System.Drawing.Point(541, 694);
            this.label_role_user.Name = "label_role_user";
            this.label_role_user.Size = new System.Drawing.Size(50, 17);
            this.label_role_user.TabIndex = 56;
            this.label_role_user.Text = "Rôle* :";
            this.label_role_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_pays_user
            // 
            this.label_pays_user.AllowDrop = true;
            this.label_pays_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_pays_user.AutoSize = true;
            this.label_pays_user.Location = new System.Drawing.Point(541, 643);
            this.label_pays_user.Name = "label_pays_user";
            this.label_pays_user.Size = new System.Drawing.Size(47, 17);
            this.label_pays_user.TabIndex = 55;
            this.label_pays_user.Text = "Pays :";
            this.label_pays_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Pays_user
            // 
            this.textBox_Pays_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Pays_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pays_user.Location = new System.Drawing.Point(594, 640);
            this.textBox_Pays_user.Name = "textBox_Pays_user";
            this.textBox_Pays_user.Size = new System.Drawing.Size(313, 24);
            this.textBox_Pays_user.TabIndex = 54;
            // 
            // textBox_Adresse_user
            // 
            this.textBox_Adresse_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Adresse_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Adresse_user.Location = new System.Drawing.Point(594, 585);
            this.textBox_Adresse_user.Name = "textBox_Adresse_user";
            this.textBox_Adresse_user.Size = new System.Drawing.Size(313, 24);
            this.textBox_Adresse_user.TabIndex = 52;
            // 
            // textBox_Anniv_user
            // 
            this.textBox_Anniv_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Anniv_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Anniv_user.Location = new System.Drawing.Point(594, 469);
            this.textBox_Anniv_user.Name = "textBox_Anniv_user";
            this.textBox_Anniv_user.Size = new System.Drawing.Size(313, 24);
            this.textBox_Anniv_user.TabIndex = 50;
            // 
            // textBox_Numero_user
            // 
            this.textBox_Numero_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Numero_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Numero_user.Location = new System.Drawing.Point(594, 526);
            this.textBox_Numero_user.Name = "textBox_Numero_user";
            this.textBox_Numero_user.Size = new System.Drawing.Size(313, 24);
            this.textBox_Numero_user.TabIndex = 48;
            // 
            // textBox_Nom_user
            // 
            this.textBox_Nom_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Nom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nom_user.Location = new System.Drawing.Point(102, 640);
            this.textBox_Nom_user.Name = "textBox_Nom_user";
            this.textBox_Nom_user.Size = new System.Drawing.Size(327, 24);
            this.textBox_Nom_user.TabIndex = 46;
            // 
            // textBox_Prenom_user
            // 
            this.textBox_Prenom_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Prenom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prenom_user.Location = new System.Drawing.Point(102, 585);
            this.textBox_Prenom_user.Name = "textBox_Prenom_user";
            this.textBox_Prenom_user.Size = new System.Drawing.Size(327, 24);
            this.textBox_Prenom_user.TabIndex = 44;
            // 
            // textBox_Email_user
            // 
            this.textBox_Email_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Email_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email_user.Location = new System.Drawing.Point(102, 694);
            this.textBox_Email_user.Name = "textBox_Email_user";
            this.textBox_Email_user.Size = new System.Drawing.Size(327, 24);
            this.textBox_Email_user.TabIndex = 42;
            this.textBox_Email_user.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBox_Username_user
            // 
            this.textBox_Username_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Username_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username_user.Location = new System.Drawing.Point(102, 526);
            this.textBox_Username_user.Name = "textBox_Username_user";
            this.textBox_Username_user.Size = new System.Drawing.Size(327, 24);
            this.textBox_Username_user.TabIndex = 39;
            this.textBox_Username_user.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBox_ID_user
            // 
            this.textBox_ID_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_ID_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID_user.Location = new System.Drawing.Point(102, 469);
            this.textBox_ID_user.Name = "textBox_ID_user";
            this.textBox_ID_user.Size = new System.Drawing.Size(327, 24);
            this.textBox_ID_user.TabIndex = 38;
            this.textBox_ID_user.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // label_adresse_user
            // 
            this.label_adresse_user.AllowDrop = true;
            this.label_adresse_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_adresse_user.AutoSize = true;
            this.label_adresse_user.Location = new System.Drawing.Point(520, 588);
            this.label_adresse_user.Name = "label_adresse_user";
            this.label_adresse_user.Size = new System.Drawing.Size(68, 17);
            this.label_adresse_user.TabIndex = 53;
            this.label_adresse_user.Text = "Adresse :";
            this.label_adresse_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_birthday_user
            // 
            this.label_birthday_user.AllowDrop = true;
            this.label_birthday_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_birthday_user.AutoSize = true;
            this.label_birthday_user.Location = new System.Drawing.Point(493, 472);
            this.label_birthday_user.Name = "label_birthday_user";
            this.label_birthday_user.Size = new System.Drawing.Size(95, 17);
            this.label_birthday_user.TabIndex = 51;
            this.label_birthday_user.Text = "Anniversaire :";
            this.label_birthday_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_numero_user
            // 
            this.label_numero_user.AllowDrop = true;
            this.label_numero_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_numero_user.AutoSize = true;
            this.label_numero_user.Location = new System.Drawing.Point(522, 529);
            this.label_numero_user.Name = "label_numero_user";
            this.label_numero_user.Size = new System.Drawing.Size(66, 17);
            this.label_numero_user.TabIndex = 49;
            this.label_numero_user.Text = "Numéro :";
            this.label_numero_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_nom_user
            // 
            this.label_nom_user.AllowDrop = true;
            this.label_nom_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_nom_user.AutoSize = true;
            this.label_nom_user.Location = new System.Drawing.Point(46, 643);
            this.label_nom_user.Name = "label_nom_user";
            this.label_nom_user.Size = new System.Drawing.Size(45, 17);
            this.label_nom_user.TabIndex = 47;
            this.label_nom_user.Text = "Nom :";
            this.label_nom_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_prenom_user
            // 
            this.label_prenom_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_prenom_user.AutoSize = true;
            this.label_prenom_user.Location = new System.Drawing.Point(31, 588);
            this.label_prenom_user.Name = "label_prenom_user";
            this.label_prenom_user.Size = new System.Drawing.Size(65, 17);
            this.label_prenom_user.TabIndex = 45;
            this.label_prenom_user.Text = "Prénom :";
            this.label_prenom_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_email_user
            // 
            this.label_email_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_email_user.AutoSize = true;
            this.label_email_user.Location = new System.Drawing.Point(41, 697);
            this.label_email_user.Name = "label_email_user";
            this.label_email_user.Size = new System.Drawing.Size(55, 17);
            this.label_email_user.TabIndex = 43;
            this.label_email_user.Text = "Email* :";
            this.label_email_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Name_user
            // 
            this.label_Name_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Name_user.AutoSize = true;
            this.label_Name_user.Location = new System.Drawing.Point(10, 529);
            this.label_Name_user.Name = "label_Name_user";
            this.label_Name_user.Size = new System.Drawing.Size(86, 17);
            this.label_Name_user.TabIndex = 41;
            this.label_Name_user.Text = "Username* :";
            this.label_Name_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id_user
            // 
            this.label_id_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_id_user.AutoSize = true;
            this.label_id_user.Location = new System.Drawing.Point(67, 472);
            this.label_id_user.Name = "label_id_user";
            this.label_id_user.Size = new System.Drawing.Size(29, 17);
            this.label_id_user.TabIndex = 40;
            this.label_id_user.Text = "ID :";
            this.label_id_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_User
            // 
            this.label_User.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.Color.Transparent;
            this.label_User.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_User.Location = new System.Drawing.Point(371, 9);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(240, 45);
            this.label_User.TabIndex = 58;
            this.label_User.Text = "UTILISATEURS";
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AllowUserToAddRows = false;
            this.dataGridView_Users.AllowUserToDeleteRows = false;
            this.dataGridView_Users.AllowUserToResizeRows = false;
            this.dataGridView_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Users.EnableHeadersVisualStyles = false;
            this.dataGridView_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Users.Location = new System.Drawing.Point(31, 70);
            this.dataGridView_Users.MultiSelect = false;
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.ReadOnly = true;
            this.dataGridView_Users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Users.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Users.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Users.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.dataGridView_Users.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Users.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView_Users.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Users.RowTemplate.Height = 24;
            this.dataGridView_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Users.Size = new System.Drawing.Size(920, 370);
            this.dataGridView_Users.TabIndex = 59;
            this.dataGridView_Users.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Users_MouseUp);
            // 
            // button_clear_ID
            // 
            this.button_clear_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear_ID.BackColor = System.Drawing.Color.Red;
            this.button_clear_ID.FlatAppearance.BorderSize = 0;
            this.button_clear_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_ID.Location = new System.Drawing.Point(435, 465);
            this.button_clear_ID.Name = "button_clear_ID";
            this.button_clear_ID.Size = new System.Drawing.Size(33, 30);
            this.button_clear_ID.TabIndex = 60;
            this.button_clear_ID.Text = "X";
            this.button_clear_ID.UseVisualStyleBackColor = false;
            this.button_clear_ID.Click += new System.EventHandler(this.button_clear_ID_Click);
            // 
            // button_clear_username
            // 
            this.button_clear_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear_username.BackColor = System.Drawing.Color.Red;
            this.button_clear_username.FlatAppearance.BorderSize = 0;
            this.button_clear_username.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_username.Location = new System.Drawing.Point(435, 522);
            this.button_clear_username.Name = "button_clear_username";
            this.button_clear_username.Size = new System.Drawing.Size(33, 30);
            this.button_clear_username.TabIndex = 61;
            this.button_clear_username.Text = "X";
            this.button_clear_username.UseVisualStyleBackColor = false;
            this.button_clear_username.Click += new System.EventHandler(this.button_clear_username_Click);
            // 
            // button_clear_prenom
            // 
            this.button_clear_prenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear_prenom.BackColor = System.Drawing.Color.Red;
            this.button_clear_prenom.FlatAppearance.BorderSize = 0;
            this.button_clear_prenom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_prenom.Location = new System.Drawing.Point(435, 581);
            this.button_clear_prenom.Name = "button_clear_prenom";
            this.button_clear_prenom.Size = new System.Drawing.Size(33, 30);
            this.button_clear_prenom.TabIndex = 62;
            this.button_clear_prenom.Text = "X";
            this.button_clear_prenom.UseVisualStyleBackColor = false;
            this.button_clear_prenom.Click += new System.EventHandler(this.button_clear_prenom_Click);
            // 
            // button_clear_nom
            // 
            this.button_clear_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear_nom.BackColor = System.Drawing.Color.Red;
            this.button_clear_nom.FlatAppearance.BorderSize = 0;
            this.button_clear_nom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_nom.Location = new System.Drawing.Point(435, 636);
            this.button_clear_nom.Name = "button_clear_nom";
            this.button_clear_nom.Size = new System.Drawing.Size(33, 30);
            this.button_clear_nom.TabIndex = 63;
            this.button_clear_nom.Text = "X";
            this.button_clear_nom.UseVisualStyleBackColor = false;
            this.button_clear_nom.Click += new System.EventHandler(this.button_clear_nom_Click);
            // 
            // button_clear_email
            // 
            this.button_clear_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear_email.BackColor = System.Drawing.Color.Red;
            this.button_clear_email.FlatAppearance.BorderSize = 0;
            this.button_clear_email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_email.Location = new System.Drawing.Point(435, 690);
            this.button_clear_email.Name = "button_clear_email";
            this.button_clear_email.Size = new System.Drawing.Size(33, 30);
            this.button_clear_email.TabIndex = 64;
            this.button_clear_email.Text = "X";
            this.button_clear_email.UseVisualStyleBackColor = false;
            this.button_clear_email.Click += new System.EventHandler(this.button_clear_email_Click);
            // 
            // button_clear_anniversaire
            // 
            this.button_clear_anniversaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_anniversaire.BackColor = System.Drawing.Color.Red;
            this.button_clear_anniversaire.FlatAppearance.BorderSize = 0;
            this.button_clear_anniversaire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_anniversaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_anniversaire.Location = new System.Drawing.Point(913, 465);
            this.button_clear_anniversaire.Name = "button_clear_anniversaire";
            this.button_clear_anniversaire.Size = new System.Drawing.Size(33, 30);
            this.button_clear_anniversaire.TabIndex = 65;
            this.button_clear_anniversaire.Text = "X";
            this.button_clear_anniversaire.UseVisualStyleBackColor = false;
            this.button_clear_anniversaire.Click += new System.EventHandler(this.button_clear_anniversaire_Click);
            // 
            // button_clear_numero
            // 
            this.button_clear_numero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_numero.BackColor = System.Drawing.Color.Red;
            this.button_clear_numero.FlatAppearance.BorderSize = 0;
            this.button_clear_numero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_numero.Location = new System.Drawing.Point(913, 522);
            this.button_clear_numero.Name = "button_clear_numero";
            this.button_clear_numero.Size = new System.Drawing.Size(33, 30);
            this.button_clear_numero.TabIndex = 66;
            this.button_clear_numero.Text = "X";
            this.button_clear_numero.UseVisualStyleBackColor = false;
            this.button_clear_numero.Click += new System.EventHandler(this.button_clear_numero_Click);
            // 
            // button_clear_adresse
            // 
            this.button_clear_adresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_adresse.BackColor = System.Drawing.Color.Red;
            this.button_clear_adresse.FlatAppearance.BorderSize = 0;
            this.button_clear_adresse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_adresse.Location = new System.Drawing.Point(913, 581);
            this.button_clear_adresse.Name = "button_clear_adresse";
            this.button_clear_adresse.Size = new System.Drawing.Size(33, 30);
            this.button_clear_adresse.TabIndex = 67;
            this.button_clear_adresse.Text = "X";
            this.button_clear_adresse.UseVisualStyleBackColor = false;
            this.button_clear_adresse.Click += new System.EventHandler(this.button_clear_adresse_Click);
            // 
            // button_clear_pays
            // 
            this.button_clear_pays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_pays.BackColor = System.Drawing.Color.Red;
            this.button_clear_pays.FlatAppearance.BorderSize = 0;
            this.button_clear_pays.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_pays.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_pays.Location = new System.Drawing.Point(913, 636);
            this.button_clear_pays.Name = "button_clear_pays";
            this.button_clear_pays.Size = new System.Drawing.Size(33, 30);
            this.button_clear_pays.TabIndex = 68;
            this.button_clear_pays.Text = "X";
            this.button_clear_pays.UseVisualStyleBackColor = false;
            this.button_clear_pays.Click += new System.EventHandler(this.button_clear_pays_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button_Del);
            this.panel1.Controls.Add(this.button_Edit);
            this.panel1.Controls.Add(this.button_Reset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 753);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 69;
            // 
            // button_Del
            // 
            this.button_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Del.ForeColor = System.Drawing.Color.White;
            this.button_Del.Location = new System.Drawing.Point(757, 13);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(200, 75);
            this.button_Del.TabIndex = 72;
            this.button_Del.Text = "Supprimer l\'utilisateur";
            this.button_Del.UseVisualStyleBackColor = false;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.ForeColor = System.Drawing.Color.White;
            this.button_Edit.Location = new System.Drawing.Point(391, 13);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(200, 75);
            this.button_Edit.TabIndex = 71;
            this.button_Edit.Text = "Modifier l\'utilisateur";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.ForeColor = System.Drawing.Color.White;
            this.button_Reset.Location = new System.Drawing.Point(37, 13);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(200, 75);
            this.button_Reset.TabIndex = 70;
            this.button_Reset.Text = "Réinitialisier le mot de passe";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // WindowUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_clear_pays);
            this.Controls.Add(this.button_clear_adresse);
            this.Controls.Add(this.button_clear_numero);
            this.Controls.Add(this.button_clear_anniversaire);
            this.Controls.Add(this.button_clear_email);
            this.Controls.Add(this.button_clear_nom);
            this.Controls.Add(this.button_clear_prenom);
            this.Controls.Add(this.button_clear_username);
            this.Controls.Add(this.button_clear_ID);
            this.Controls.Add(this.dataGridView_Users);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.comboBox_Role_user);
            this.Controls.Add(this.label_role_user);
            this.Controls.Add(this.label_pays_user);
            this.Controls.Add(this.textBox_Pays_user);
            this.Controls.Add(this.textBox_Adresse_user);
            this.Controls.Add(this.textBox_Anniv_user);
            this.Controls.Add(this.textBox_Numero_user);
            this.Controls.Add(this.textBox_Nom_user);
            this.Controls.Add(this.textBox_Prenom_user);
            this.Controls.Add(this.textBox_Email_user);
            this.Controls.Add(this.textBox_Username_user);
            this.Controls.Add(this.textBox_ID_user);
            this.Controls.Add(this.label_adresse_user);
            this.Controls.Add(this.label_birthday_user);
            this.Controls.Add(this.label_numero_user);
            this.Controls.Add(this.label_nom_user);
            this.Controls.Add(this.label_prenom_user);
            this.Controls.Add(this.label_email_user);
            this.Controls.Add(this.label_Name_user);
            this.Controls.Add(this.label_id_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WindowUtilisateur";
            this.Text = "Utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Role_user;
        private System.Windows.Forms.Label label_role_user;
        private System.Windows.Forms.Label label_pays_user;
        private System.Windows.Forms.TextBox textBox_Pays_user;
        private System.Windows.Forms.TextBox textBox_Adresse_user;
        private System.Windows.Forms.TextBox textBox_Anniv_user;
        private System.Windows.Forms.TextBox textBox_Numero_user;
        private System.Windows.Forms.TextBox textBox_Nom_user;
        private System.Windows.Forms.TextBox textBox_Prenom_user;
        private System.Windows.Forms.TextBox textBox_Email_user;
        private System.Windows.Forms.TextBox textBox_Username_user;
        private System.Windows.Forms.TextBox textBox_ID_user;
        private System.Windows.Forms.Label label_adresse_user;
        private System.Windows.Forms.Label label_birthday_user;
        private System.Windows.Forms.Label label_numero_user;
        private System.Windows.Forms.Label label_nom_user;
        private System.Windows.Forms.Label label_prenom_user;
        private System.Windows.Forms.Label label_email_user;
        private System.Windows.Forms.Label label_Name_user;
        private System.Windows.Forms.Label label_id_user;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.Button button_clear_ID;
        private System.Windows.Forms.Button button_clear_username;
        private System.Windows.Forms.Button button_clear_prenom;
        private System.Windows.Forms.Button button_clear_nom;
        private System.Windows.Forms.Button button_clear_email;
        private System.Windows.Forms.Button button_clear_anniversaire;
        private System.Windows.Forms.Button button_clear_numero;
        private System.Windows.Forms.Button button_clear_adresse;
        private System.Windows.Forms.Button button_clear_pays;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Reset;
    }
}