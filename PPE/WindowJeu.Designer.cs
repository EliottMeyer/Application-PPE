
namespace PPE
{
    partial class WindowJeu
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
            this.listBoxAllCategories = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_img_jeu = new System.Windows.Forms.Label();
            this.label_site_jeu = new System.Windows.Forms.Label();
            this.label_desc_jeu = new System.Windows.Forms.Label();
            this.label_nom_jeu = new System.Windows.Forms.Label();
            this.label_id_jeu = new System.Windows.Forms.Label();
            this.textBox_Img_jeu = new System.Windows.Forms.TextBox();
            this.textBox_Site_jeu = new System.Windows.Forms.TextBox();
            this.textBox_Desc_jeu = new System.Windows.Forms.TextBox();
            this.textBox_Name_jeu = new System.Windows.Forms.TextBox();
            this.textBox_ID_jeu = new System.Windows.Forms.TextBox();
            this.label_Jeu = new System.Windows.Forms.Label();
            this.button_clear_ID = new System.Windows.Forms.Button();
            this.button_clear_name = new System.Windows.Forms.Button();
            this.button_clear_site = new System.Windows.Forms.Button();
            this.button_clear_image = new System.Windows.Forms.Button();
            this.button_clear_description = new System.Windows.Forms.Button();
            this.button_clear_categories = new System.Windows.Forms.Button();
            this.dataGridView_Jeux = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Commentaire = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jeux)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAllCategories
            // 
            this.listBoxAllCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAllCategories.CheckOnClick = true;
            this.listBoxAllCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxAllCategories.FormattingEnabled = true;
            this.listBoxAllCategories.Location = new System.Drawing.Point(686, 476);
            this.listBoxAllCategories.Name = "listBoxAllCategories";
            this.listBoxAllCategories.Size = new System.Drawing.Size(227, 256);
            this.listBoxAllCategories.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Liste des catégories";
            // 
            // label_img_jeu
            // 
            this.label_img_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_img_jeu.AutoSize = true;
            this.label_img_jeu.Location = new System.Drawing.Point(51, 584);
            this.label_img_jeu.Name = "label_img_jeu";
            this.label_img_jeu.Size = new System.Drawing.Size(59, 17);
            this.label_img_jeu.TabIndex = 33;
            this.label_img_jeu.Text = "Image* :";
            this.label_img_jeu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_site_jeu
            // 
            this.label_site_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_site_jeu.AutoSize = true;
            this.label_site_jeu.Location = new System.Drawing.Point(70, 539);
            this.label_site_jeu.Name = "label_site_jeu";
            this.label_site_jeu.Size = new System.Drawing.Size(40, 17);
            this.label_site_jeu.TabIndex = 32;
            this.label_site_jeu.Text = "Site :";
            this.label_site_jeu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_desc_jeu
            // 
            this.label_desc_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_desc_jeu.AutoSize = true;
            this.label_desc_jeu.Location = new System.Drawing.Point(18, 626);
            this.label_desc_jeu.Name = "label_desc_jeu";
            this.label_desc_jeu.Size = new System.Drawing.Size(92, 17);
            this.label_desc_jeu.TabIndex = 31;
            this.label_desc_jeu.Text = "Description* :";
            this.label_desc_jeu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_nom_jeu
            // 
            this.label_nom_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nom_jeu.AutoSize = true;
            this.label_nom_jeu.Location = new System.Drawing.Point(60, 496);
            this.label_nom_jeu.Name = "label_nom_jeu";
            this.label_nom_jeu.Size = new System.Drawing.Size(50, 17);
            this.label_nom_jeu.TabIndex = 30;
            this.label_nom_jeu.Text = "Nom* :";
            this.label_nom_jeu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id_jeu
            // 
            this.label_id_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id_jeu.AutoSize = true;
            this.label_id_jeu.Location = new System.Drawing.Point(81, 457);
            this.label_id_jeu.Name = "label_id_jeu";
            this.label_id_jeu.Size = new System.Drawing.Size(29, 17);
            this.label_id_jeu.TabIndex = 29;
            this.label_id_jeu.Text = "ID :";
            this.label_id_jeu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Img_jeu
            // 
            this.textBox_Img_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Img_jeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Img_jeu.Location = new System.Drawing.Point(116, 579);
            this.textBox_Img_jeu.Name = "textBox_Img_jeu";
            this.textBox_Img_jeu.Size = new System.Drawing.Size(459, 24);
            this.textBox_Img_jeu.TabIndex = 28;
            this.textBox_Img_jeu.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBox_Site_jeu
            // 
            this.textBox_Site_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Site_jeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Site_jeu.Location = new System.Drawing.Point(116, 534);
            this.textBox_Site_jeu.Name = "textBox_Site_jeu";
            this.textBox_Site_jeu.Size = new System.Drawing.Size(459, 24);
            this.textBox_Site_jeu.TabIndex = 27;
            // 
            // textBox_Desc_jeu
            // 
            this.textBox_Desc_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Desc_jeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Desc_jeu.Location = new System.Drawing.Point(116, 621);
            this.textBox_Desc_jeu.Multiline = true;
            this.textBox_Desc_jeu.Name = "textBox_Desc_jeu";
            this.textBox_Desc_jeu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Desc_jeu.Size = new System.Drawing.Size(459, 107);
            this.textBox_Desc_jeu.TabIndex = 26;
            this.textBox_Desc_jeu.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBox_Name_jeu
            // 
            this.textBox_Name_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name_jeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name_jeu.Location = new System.Drawing.Point(116, 491);
            this.textBox_Name_jeu.Name = "textBox_Name_jeu";
            this.textBox_Name_jeu.Size = new System.Drawing.Size(459, 24);
            this.textBox_Name_jeu.TabIndex = 25;
            this.textBox_Name_jeu.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBox_ID_jeu
            // 
            this.textBox_ID_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID_jeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID_jeu.Location = new System.Drawing.Point(116, 452);
            this.textBox_ID_jeu.Name = "textBox_ID_jeu";
            this.textBox_ID_jeu.Size = new System.Drawing.Size(459, 24);
            this.textBox_ID_jeu.TabIndex = 24;
            this.textBox_ID_jeu.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // label_Jeu
            // 
            this.label_Jeu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Jeu.AutoSize = true;
            this.label_Jeu.BackColor = System.Drawing.Color.Transparent;
            this.label_Jeu.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Jeu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_Jeu.Location = new System.Drawing.Point(443, 10);
            this.label_Jeu.Name = "label_Jeu";
            this.label_Jeu.Size = new System.Drawing.Size(95, 45);
            this.label_Jeu.TabIndex = 47;
            this.label_Jeu.Text = "JEUX";
            // 
            // button_clear_ID
            // 
            this.button_clear_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_ID.BackColor = System.Drawing.Color.Red;
            this.button_clear_ID.FlatAppearance.BorderSize = 0;
            this.button_clear_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_ID.Location = new System.Drawing.Point(581, 448);
            this.button_clear_ID.Name = "button_clear_ID";
            this.button_clear_ID.Size = new System.Drawing.Size(33, 30);
            this.button_clear_ID.TabIndex = 49;
            this.button_clear_ID.Text = "X";
            this.button_clear_ID.UseVisualStyleBackColor = false;
            this.button_clear_ID.Click += new System.EventHandler(this.button_clear_ID_Click);
            // 
            // button_clear_name
            // 
            this.button_clear_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_name.BackColor = System.Drawing.Color.Red;
            this.button_clear_name.FlatAppearance.BorderSize = 0;
            this.button_clear_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_name.Location = new System.Drawing.Point(581, 487);
            this.button_clear_name.Name = "button_clear_name";
            this.button_clear_name.Size = new System.Drawing.Size(33, 30);
            this.button_clear_name.TabIndex = 50;
            this.button_clear_name.Text = "X";
            this.button_clear_name.UseVisualStyleBackColor = false;
            this.button_clear_name.Click += new System.EventHandler(this.button_clear_name_Click);
            // 
            // button_clear_site
            // 
            this.button_clear_site.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_site.BackColor = System.Drawing.Color.Red;
            this.button_clear_site.FlatAppearance.BorderSize = 0;
            this.button_clear_site.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_site.Location = new System.Drawing.Point(581, 530);
            this.button_clear_site.Name = "button_clear_site";
            this.button_clear_site.Size = new System.Drawing.Size(33, 30);
            this.button_clear_site.TabIndex = 51;
            this.button_clear_site.Text = "X";
            this.button_clear_site.UseVisualStyleBackColor = false;
            this.button_clear_site.Click += new System.EventHandler(this.button_clear_site_Click);
            // 
            // button_clear_image
            // 
            this.button_clear_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_image.BackColor = System.Drawing.Color.Red;
            this.button_clear_image.FlatAppearance.BorderSize = 0;
            this.button_clear_image.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_image.Location = new System.Drawing.Point(581, 575);
            this.button_clear_image.Name = "button_clear_image";
            this.button_clear_image.Size = new System.Drawing.Size(33, 30);
            this.button_clear_image.TabIndex = 52;
            this.button_clear_image.Text = "X";
            this.button_clear_image.UseVisualStyleBackColor = false;
            this.button_clear_image.Click += new System.EventHandler(this.button_clear_image_Click);
            // 
            // button_clear_description
            // 
            this.button_clear_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_description.BackColor = System.Drawing.Color.Red;
            this.button_clear_description.FlatAppearance.BorderSize = 0;
            this.button_clear_description.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_description.Location = new System.Drawing.Point(581, 658);
            this.button_clear_description.Name = "button_clear_description";
            this.button_clear_description.Size = new System.Drawing.Size(33, 30);
            this.button_clear_description.TabIndex = 53;
            this.button_clear_description.Text = "X";
            this.button_clear_description.UseVisualStyleBackColor = false;
            this.button_clear_description.Click += new System.EventHandler(this.button_clear_description_Click);
            // 
            // button_clear_categories
            // 
            this.button_clear_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_categories.BackColor = System.Drawing.Color.Red;
            this.button_clear_categories.FlatAppearance.BorderSize = 0;
            this.button_clear_categories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_categories.Location = new System.Drawing.Point(919, 571);
            this.button_clear_categories.Name = "button_clear_categories";
            this.button_clear_categories.Size = new System.Drawing.Size(33, 30);
            this.button_clear_categories.TabIndex = 54;
            this.button_clear_categories.Text = "X";
            this.button_clear_categories.UseVisualStyleBackColor = false;
            this.button_clear_categories.Click += new System.EventHandler(this.button_clear_categories_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Jeux.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Jeux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Jeux.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Jeux.EnableHeadersVisualStyles = false;
            this.dataGridView_Jeux.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Jeux.Location = new System.Drawing.Point(31, 70);
            this.dataGridView_Jeux.MultiSelect = false;
            this.dataGridView_Jeux.Name = "dataGridView_Jeux";
            this.dataGridView_Jeux.ReadOnly = true;
            this.dataGridView_Jeux.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Jeux.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Jeux.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Jeux.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Jeux.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.dataGridView_Jeux.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Jeux.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView_Jeux.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Jeux.RowTemplate.Height = 24;
            this.dataGridView_Jeux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Jeux.Size = new System.Drawing.Size(920, 370);
            this.dataGridView_Jeux.TabIndex = 55;
            this.dataGridView_Jeux.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Jeux_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button_Commentaire);
            this.panel1.Controls.Add(this.button_Del);
            this.panel1.Controls.Add(this.button_Edit);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 753);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 56;
            // 
            // button_Commentaire
            // 
            this.button_Commentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Commentaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button_Commentaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Commentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Commentaire.ForeColor = System.Drawing.Color.White;
            this.button_Commentaire.Location = new System.Drawing.Point(752, 13);
            this.button_Commentaire.Name = "button_Commentaire";
            this.button_Commentaire.Size = new System.Drawing.Size(200, 75);
            this.button_Commentaire.TabIndex = 6;
            this.button_Commentaire.Text = "Gérer les commentaires";
            this.button_Commentaire.UseVisualStyleBackColor = false;
            this.button_Commentaire.Click += new System.EventHandler(this.button_Commentaire_Click);
            // 
            // button_Del
            // 
            this.button_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Del.ForeColor = System.Drawing.Color.White;
            this.button_Del.Location = new System.Drawing.Point(463, 13);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(200, 75);
            this.button_Del.TabIndex = 5;
            this.button_Del.Text = "Supprimer le jeu";
            this.button_Del.UseVisualStyleBackColor = false;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.ForeColor = System.Drawing.Color.White;
            this.button_Edit.Location = new System.Drawing.Point(248, 13);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(200, 75);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "Modifier le jeu";
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
            this.button_Add.Location = new System.Drawing.Point(31, 13);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(200, 75);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Ajouter un jeu";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // WindowJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Jeux);
            this.Controls.Add(this.button_clear_categories);
            this.Controls.Add(this.button_clear_description);
            this.Controls.Add(this.button_clear_image);
            this.Controls.Add(this.button_clear_site);
            this.Controls.Add(this.button_clear_name);
            this.Controls.Add(this.button_clear_ID);
            this.Controls.Add(this.label_Jeu);
            this.Controls.Add(this.listBoxAllCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_img_jeu);
            this.Controls.Add(this.label_site_jeu);
            this.Controls.Add(this.label_desc_jeu);
            this.Controls.Add(this.label_nom_jeu);
            this.Controls.Add(this.label_id_jeu);
            this.Controls.Add(this.textBox_Img_jeu);
            this.Controls.Add(this.textBox_Site_jeu);
            this.Controls.Add(this.textBox_Desc_jeu);
            this.Controls.Add(this.textBox_Name_jeu);
            this.Controls.Add(this.textBox_ID_jeu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WindowJeu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jeux)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox listBoxAllCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_img_jeu;
        private System.Windows.Forms.Label label_site_jeu;
        private System.Windows.Forms.Label label_desc_jeu;
        private System.Windows.Forms.Label label_nom_jeu;
        private System.Windows.Forms.Label label_id_jeu;
        private System.Windows.Forms.TextBox textBox_Img_jeu;
        private System.Windows.Forms.TextBox textBox_Site_jeu;
        private System.Windows.Forms.TextBox textBox_Desc_jeu;
        private System.Windows.Forms.TextBox textBox_Name_jeu;
        private System.Windows.Forms.TextBox textBox_ID_jeu;
        private System.Windows.Forms.Label label_Jeu;
        private System.Windows.Forms.Button button_clear_ID;
        private System.Windows.Forms.Button button_clear_name;
        private System.Windows.Forms.Button button_clear_site;
        private System.Windows.Forms.Button button_clear_image;
        private System.Windows.Forms.Button button_clear_description;
        private System.Windows.Forms.Button button_clear_categories;
        private System.Windows.Forms.DataGridView dataGridView_Jeux;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Commentaire;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Add;
    }
}