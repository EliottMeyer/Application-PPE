
namespace PPE
{
    partial class WindowCategorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_id_categorie = new System.Windows.Forms.Label();
            this.label_jeux_de_la_cat = new System.Windows.Forms.Label();
            this.label_nom_categorie = new System.Windows.Forms.Label();
            this.textBox_Name_categorie = new System.Windows.Forms.TextBox();
            this.textBox_ID_categorie = new System.Windows.Forms.TextBox();
            this.dataGridView_Categorie = new System.Windows.Forms.DataGridView();
            this.label_liste_categorie = new System.Windows.Forms.Label();
            this.label_Categorie = new System.Windows.Forms.Label();
            this.dataGridView_Jeux = new System.Windows.Forms.DataGridView();
            this.button_clear_ID = new System.Windows.Forms.Button();
            this.button_clear_Name = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jeux)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_id_categorie
            // 
            this.label_id_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id_categorie.AutoSize = true;
            this.label_id_categorie.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_categorie.Location = new System.Drawing.Point(742, 141);
            this.label_id_categorie.Name = "label_id_categorie";
            this.label_id_categorie.Size = new System.Drawing.Size(36, 23);
            this.label_id_categorie.TabIndex = 44;
            this.label_id_categorie.Text = "ID :";
            this.label_id_categorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_jeux_de_la_cat
            // 
            this.label_jeux_de_la_cat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_jeux_de_la_cat.AutoSize = true;
            this.label_jeux_de_la_cat.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jeux_de_la_cat.ForeColor = System.Drawing.Color.Black;
            this.label_jeux_de_la_cat.Location = new System.Drawing.Point(425, 310);
            this.label_jeux_de_la_cat.Name = "label_jeux_de_la_cat";
            this.label_jeux_de_la_cat.Size = new System.Drawing.Size(161, 23);
            this.label_jeux_de_la_cat.TabIndex = 42;
            this.label_jeux_de_la_cat.Text = "Jeux de la catégorie";
            // 
            // label_nom_categorie
            // 
            this.label_nom_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nom_categorie.AutoSize = true;
            this.label_nom_categorie.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom_categorie.Location = new System.Drawing.Point(714, 182);
            this.label_nom_categorie.Name = "label_nom_categorie";
            this.label_nom_categorie.Size = new System.Drawing.Size(64, 23);
            this.label_nom_categorie.TabIndex = 41;
            this.label_nom_categorie.Text = "Nom* :";
            this.label_nom_categorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Name_categorie
            // 
            this.textBox_Name_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name_categorie.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name_categorie.Location = new System.Drawing.Point(784, 182);
            this.textBox_Name_categorie.Name = "textBox_Name_categorie";
            this.textBox_Name_categorie.Size = new System.Drawing.Size(129, 30);
            this.textBox_Name_categorie.TabIndex = 40;
            this.textBox_Name_categorie.TextChanged += new System.EventHandler(this.display_Jeu_from_Categorie);
            // 
            // textBox_ID_categorie
            // 
            this.textBox_ID_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID_categorie.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID_categorie.Location = new System.Drawing.Point(784, 138);
            this.textBox_ID_categorie.Name = "textBox_ID_categorie";
            this.textBox_ID_categorie.Size = new System.Drawing.Size(129, 30);
            this.textBox_ID_categorie.TabIndex = 39;
            this.textBox_ID_categorie.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // dataGridView_Categorie
            // 
            this.dataGridView_Categorie.AllowUserToAddRows = false;
            this.dataGridView_Categorie.AllowUserToDeleteRows = false;
            this.dataGridView_Categorie.AllowUserToResizeRows = false;
            this.dataGridView_Categorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Categorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Categorie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Categorie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Categorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Categorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Categorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Categorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Categorie.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Categorie.EnableHeadersVisualStyles = false;
            this.dataGridView_Categorie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Categorie.Location = new System.Drawing.Point(37, 95);
            this.dataGridView_Categorie.MultiSelect = false;
            this.dataGridView_Categorie.Name = "dataGridView_Categorie";
            this.dataGridView_Categorie.ReadOnly = true;
            this.dataGridView_Categorie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Categorie.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Categorie.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Categorie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Categorie.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.dataGridView_Categorie.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Categorie.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView_Categorie.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Categorie.RowTemplate.Height = 24;
            this.dataGridView_Categorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Categorie.Size = new System.Drawing.Size(670, 200);
            this.dataGridView_Categorie.TabIndex = 38;
            this.dataGridView_Categorie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Categorie_MouseUp);
            // 
            // label_liste_categorie
            // 
            this.label_liste_categorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_liste_categorie.AutoSize = true;
            this.label_liste_categorie.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_liste_categorie.Location = new System.Drawing.Point(296, 67);
            this.label_liste_categorie.Name = "label_liste_categorie";
            this.label_liste_categorie.Size = new System.Drawing.Size(158, 23);
            this.label_liste_categorie.TabIndex = 45;
            this.label_liste_categorie.Text = "Liste des catégories";
            // 
            // label_Categorie
            // 
            this.label_Categorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Categorie.AutoSize = true;
            this.label_Categorie.BackColor = System.Drawing.Color.Transparent;
            this.label_Categorie.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Categorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_Categorie.Location = new System.Drawing.Point(382, 10);
            this.label_Categorie.Name = "label_Categorie";
            this.label_Categorie.Size = new System.Drawing.Size(217, 45);
            this.label_Categorie.TabIndex = 46;
            this.label_Categorie.Text = "CATEGORIES";
            // 
            // dataGridView_Jeux
            // 
            this.dataGridView_Jeux.AllowUserToAddRows = false;
            this.dataGridView_Jeux.AllowUserToDeleteRows = false;
            this.dataGridView_Jeux.AllowUserToResizeRows = false;
            this.dataGridView_Jeux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Jeux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Jeux.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Jeux.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Jeux.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Jeux.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Jeux.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Jeux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Jeux.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Jeux.EnableHeadersVisualStyles = false;
            this.dataGridView_Jeux.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Jeux.Location = new System.Drawing.Point(37, 336);
            this.dataGridView_Jeux.Name = "dataGridView_Jeux";
            this.dataGridView_Jeux.ReadOnly = true;
            this.dataGridView_Jeux.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Jeux.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Jeux.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Jeux.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Jeux.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.dataGridView_Jeux.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Jeux.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView_Jeux.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Jeux.RowTemplate.Height = 24;
            this.dataGridView_Jeux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Jeux.Size = new System.Drawing.Size(920, 400);
            this.dataGridView_Jeux.TabIndex = 47;
            // 
            // button_clear_ID
            // 
            this.button_clear_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_ID.BackColor = System.Drawing.Color.Red;
            this.button_clear_ID.FlatAppearance.BorderSize = 0;
            this.button_clear_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_ID.Location = new System.Drawing.Point(925, 139);
            this.button_clear_ID.Name = "button_clear_ID";
            this.button_clear_ID.Size = new System.Drawing.Size(33, 30);
            this.button_clear_ID.TabIndex = 48;
            this.button_clear_ID.Text = "X";
            this.button_clear_ID.UseVisualStyleBackColor = false;
            this.button_clear_ID.Click += new System.EventHandler(this.button_clear_ID_Click);
            // 
            // button_clear_Name
            // 
            this.button_clear_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_Name.BackColor = System.Drawing.Color.Red;
            this.button_clear_Name.FlatAppearance.BorderSize = 0;
            this.button_clear_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_Name.Location = new System.Drawing.Point(925, 180);
            this.button_clear_Name.Name = "button_clear_Name";
            this.button_clear_Name.Size = new System.Drawing.Size(33, 30);
            this.button_clear_Name.TabIndex = 49;
            this.button_clear_Name.Text = "X";
            this.button_clear_Name.UseVisualStyleBackColor = false;
            this.button_clear_Name.Click += new System.EventHandler(this.button_clear_Name_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button_Del);
            this.panel1.Controls.Add(this.button_Edit);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 753);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 70;
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
            this.button_Del.TabIndex = 2;
            this.button_Del.Text = "Supprimer la catégorie";
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
            this.button_Edit.TabIndex = 1;
            this.button_Edit.Text = "Modifier la catégorie";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(37, 13);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(200, 75);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Ajouter une catégorie";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // WindowCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_clear_Name);
            this.Controls.Add(this.button_clear_ID);
            this.Controls.Add(this.dataGridView_Jeux);
            this.Controls.Add(this.label_Categorie);
            this.Controls.Add(this.label_liste_categorie);
            this.Controls.Add(this.label_id_categorie);
            this.Controls.Add(this.label_jeux_de_la_cat);
            this.Controls.Add(this.label_nom_categorie);
            this.Controls.Add(this.textBox_Name_categorie);
            this.Controls.Add(this.textBox_ID_categorie);
            this.Controls.Add(this.dataGridView_Categorie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WindowCategorie";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jeux)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id_categorie;
        private System.Windows.Forms.Label label_jeux_de_la_cat;
        private System.Windows.Forms.Label label_nom_categorie;
        private System.Windows.Forms.TextBox textBox_Name_categorie;
        private System.Windows.Forms.TextBox textBox_ID_categorie;
        private System.Windows.Forms.DataGridView dataGridView_Categorie;
        private System.Windows.Forms.Label label_liste_categorie;
        private System.Windows.Forms.Label label_Categorie;
        private System.Windows.Forms.DataGridView dataGridView_Jeux;
        private System.Windows.Forms.Button button_clear_ID;
        private System.Windows.Forms.Button button_clear_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Edit;
    }
}