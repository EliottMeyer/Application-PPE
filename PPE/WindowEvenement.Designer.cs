
namespace PPE
{
    partial class WindowEvenement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Evenement = new System.Windows.Forms.Label();
            this.label_event = new System.Windows.Forms.Label();
            this.dataGridView_Event = new System.Windows.Forms.DataGridView();
            this.button_clear_image = new System.Windows.Forms.Button();
            this.button_clear_site = new System.Windows.Forms.Button();
            this.button_clear_name = new System.Windows.Forms.Button();
            this.button_clear_ID = new System.Windows.Forms.Button();
            this.label_img_event = new System.Windows.Forms.Label();
            this.label_site_event = new System.Windows.Forms.Label();
            this.label_date_jeu = new System.Windows.Forms.Label();
            this.label_nom_event = new System.Windows.Forms.Label();
            this.label_id_event = new System.Windows.Forms.Label();
            this.textBox_Img_event = new System.Windows.Forms.TextBox();
            this.textBox_Site_event = new System.Windows.Forms.TextBox();
            this.textBox_Name_event = new System.Windows.Forms.TextBox();
            this.textBox_ID_event = new System.Windows.Forms.TextBox();
            this.dateTimePicker_event = new System.Windows.Forms.DateTimePicker();
            this.button_clear_date = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Event)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 82;
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
            this.button_Del.Text = "Supprimer l\'événement";
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
            this.button_Edit.Text = "Modifier l\'événement";
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
            this.button_Add.Text = "Ajouter un événement";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Evenement
            // 
            this.label_Evenement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Evenement.AutoSize = true;
            this.label_Evenement.BackColor = System.Drawing.Color.Transparent;
            this.label_Evenement.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Evenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_Evenement.Location = new System.Drawing.Point(396, 9);
            this.label_Evenement.Name = "label_Evenement";
            this.label_Evenement.Size = new System.Drawing.Size(234, 45);
            this.label_Evenement.TabIndex = 78;
            this.label_Evenement.Text = "EVENEMENTS";
            // 
            // label_event
            // 
            this.label_event.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_event.AutoSize = true;
            this.label_event.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_event.ForeColor = System.Drawing.Color.Black;
            this.label_event.Location = new System.Drawing.Point(430, 66);
            this.label_event.Name = "label_event";
            this.label_event.Size = new System.Drawing.Size(150, 23);
            this.label_event.TabIndex = 75;
            this.label_event.Text = "Evénements prévu";
            // 
            // dataGridView_Event
            // 
            this.dataGridView_Event.AllowUserToAddRows = false;
            this.dataGridView_Event.AllowUserToDeleteRows = false;
            this.dataGridView_Event.AllowUserToResizeRows = false;
            this.dataGridView_Event.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Event.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Event.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Event.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Event.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Event.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Event.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridView_Event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Event.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridView_Event.EnableHeadersVisualStyles = false;
            this.dataGridView_Event.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Event.Location = new System.Drawing.Point(37, 92);
            this.dataGridView_Event.MultiSelect = false;
            this.dataGridView_Event.Name = "dataGridView_Event";
            this.dataGridView_Event.ReadOnly = true;
            this.dataGridView_Event.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Event.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridView_Event.RowHeadersWidth = 51;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Event.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridView_Event.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.dataGridView_Event.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Event.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView_Event.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Event.RowTemplate.Height = 24;
            this.dataGridView_Event.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Event.Size = new System.Drawing.Size(920, 402);
            this.dataGridView_Event.TabIndex = 102;
            this.dataGridView_Event.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Event_MouseUp);
            // 
            // button_clear_image
            // 
            this.button_clear_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_image.BackColor = System.Drawing.Color.Red;
            this.button_clear_image.FlatAppearance.BorderSize = 0;
            this.button_clear_image.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_image.Location = new System.Drawing.Point(924, 647);
            this.button_clear_image.Name = "button_clear_image";
            this.button_clear_image.Size = new System.Drawing.Size(33, 30);
            this.button_clear_image.TabIndex = 99;
            this.button_clear_image.Text = "X";
            this.button_clear_image.UseVisualStyleBackColor = false;
            this.button_clear_image.Click += new System.EventHandler(this.button_clear_image_Click);
            // 
            // button_clear_site
            // 
            this.button_clear_site.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_site.BackColor = System.Drawing.Color.Red;
            this.button_clear_site.FlatAppearance.BorderSize = 0;
            this.button_clear_site.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_site.Location = new System.Drawing.Point(924, 602);
            this.button_clear_site.Name = "button_clear_site";
            this.button_clear_site.Size = new System.Drawing.Size(33, 30);
            this.button_clear_site.TabIndex = 98;
            this.button_clear_site.Text = "X";
            this.button_clear_site.UseVisualStyleBackColor = false;
            this.button_clear_site.Click += new System.EventHandler(this.button_clear_site_Click);
            // 
            // button_clear_name
            // 
            this.button_clear_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_name.BackColor = System.Drawing.Color.Red;
            this.button_clear_name.FlatAppearance.BorderSize = 0;
            this.button_clear_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_name.Location = new System.Drawing.Point(924, 559);
            this.button_clear_name.Name = "button_clear_name";
            this.button_clear_name.Size = new System.Drawing.Size(33, 30);
            this.button_clear_name.TabIndex = 97;
            this.button_clear_name.Text = "X";
            this.button_clear_name.UseVisualStyleBackColor = false;
            this.button_clear_name.Click += new System.EventHandler(this.button_clear_name_Click);
            // 
            // button_clear_ID
            // 
            this.button_clear_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_ID.BackColor = System.Drawing.Color.Red;
            this.button_clear_ID.FlatAppearance.BorderSize = 0;
            this.button_clear_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_ID.Location = new System.Drawing.Point(924, 520);
            this.button_clear_ID.Name = "button_clear_ID";
            this.button_clear_ID.Size = new System.Drawing.Size(33, 30);
            this.button_clear_ID.TabIndex = 96;
            this.button_clear_ID.Text = "X";
            this.button_clear_ID.UseVisualStyleBackColor = false;
            this.button_clear_ID.Click += new System.EventHandler(this.button_clear_ID_Click);
            // 
            // label_img_event
            // 
            this.label_img_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_img_event.AutoSize = true;
            this.label_img_event.Location = new System.Drawing.Point(25, 654);
            this.label_img_event.Name = "label_img_event";
            this.label_img_event.Size = new System.Drawing.Size(59, 17);
            this.label_img_event.TabIndex = 92;
            this.label_img_event.Text = "Image* :";
            this.label_img_event.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_site_event
            // 
            this.label_site_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_site_event.AutoSize = true;
            this.label_site_event.Location = new System.Drawing.Point(44, 609);
            this.label_site_event.Name = "label_site_event";
            this.label_site_event.Size = new System.Drawing.Size(40, 17);
            this.label_site_event.TabIndex = 91;
            this.label_site_event.Text = "Site :";
            this.label_site_event.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_date_jeu
            // 
            this.label_date_jeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_date_jeu.AutoSize = true;
            this.label_date_jeu.Location = new System.Drawing.Point(33, 696);
            this.label_date_jeu.Name = "label_date_jeu";
            this.label_date_jeu.Size = new System.Drawing.Size(51, 17);
            this.label_date_jeu.TabIndex = 90;
            this.label_date_jeu.Text = "Date* :";
            this.label_date_jeu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_nom_event
            // 
            this.label_nom_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nom_event.AutoSize = true;
            this.label_nom_event.Location = new System.Drawing.Point(34, 566);
            this.label_nom_event.Name = "label_nom_event";
            this.label_nom_event.Size = new System.Drawing.Size(50, 17);
            this.label_nom_event.TabIndex = 89;
            this.label_nom_event.Text = "Nom* :";
            this.label_nom_event.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id_event
            // 
            this.label_id_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id_event.AutoSize = true;
            this.label_id_event.Location = new System.Drawing.Point(55, 527);
            this.label_id_event.Name = "label_id_event";
            this.label_id_event.Size = new System.Drawing.Size(29, 17);
            this.label_id_event.TabIndex = 88;
            this.label_id_event.Text = "ID :";
            this.label_id_event.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Img_event
            // 
            this.textBox_Img_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Img_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Img_event.Location = new System.Drawing.Point(90, 651);
            this.textBox_Img_event.Name = "textBox_Img_event";
            this.textBox_Img_event.Size = new System.Drawing.Size(828, 24);
            this.textBox_Img_event.TabIndex = 87;
            // 
            // textBox_Site_event
            // 
            this.textBox_Site_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Site_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Site_event.Location = new System.Drawing.Point(90, 606);
            this.textBox_Site_event.Name = "textBox_Site_event";
            this.textBox_Site_event.Size = new System.Drawing.Size(828, 24);
            this.textBox_Site_event.TabIndex = 86;
            // 
            // textBox_Name_event
            // 
            this.textBox_Name_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name_event.Location = new System.Drawing.Point(90, 563);
            this.textBox_Name_event.Name = "textBox_Name_event";
            this.textBox_Name_event.Size = new System.Drawing.Size(828, 24);
            this.textBox_Name_event.TabIndex = 84;
            // 
            // textBox_ID_event
            // 
            this.textBox_ID_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID_event.Location = new System.Drawing.Point(90, 524);
            this.textBox_ID_event.Name = "textBox_ID_event";
            this.textBox_ID_event.Size = new System.Drawing.Size(828, 24);
            this.textBox_ID_event.TabIndex = 83;
            // 
            // dateTimePicker_event
            // 
            this.dateTimePicker_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_event.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_event.Location = new System.Drawing.Point(90, 693);
            this.dateTimePicker_event.Name = "dateTimePicker_event";
            this.dateTimePicker_event.Size = new System.Drawing.Size(828, 22);
            this.dateTimePicker_event.TabIndex = 103;
            // 
            // button_clear_date
            // 
            this.button_clear_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_date.BackColor = System.Drawing.Color.Lime;
            this.button_clear_date.FlatAppearance.BorderSize = 0;
            this.button_clear_date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_date.Location = new System.Drawing.Point(924, 691);
            this.button_clear_date.Name = "button_clear_date";
            this.button_clear_date.Size = new System.Drawing.Size(33, 30);
            this.button_clear_date.TabIndex = 100;
            this.button_clear_date.Text = "X";
            this.button_clear_date.UseVisualStyleBackColor = false;
            this.button_clear_date.Click += new System.EventHandler(this.button_clear_date_Click);
            // 
            // WindowEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 853);
            this.Controls.Add(this.dateTimePicker_event);
            this.Controls.Add(this.dataGridView_Event);
            this.Controls.Add(this.button_clear_date);
            this.Controls.Add(this.button_clear_image);
            this.Controls.Add(this.button_clear_site);
            this.Controls.Add(this.button_clear_name);
            this.Controls.Add(this.button_clear_ID);
            this.Controls.Add(this.label_img_event);
            this.Controls.Add(this.label_site_event);
            this.Controls.Add(this.label_date_jeu);
            this.Controls.Add(this.label_nom_event);
            this.Controls.Add(this.label_id_event);
            this.Controls.Add(this.textBox_Img_event);
            this.Controls.Add(this.textBox_Site_event);
            this.Controls.Add(this.textBox_Name_event);
            this.Controls.Add(this.textBox_ID_event);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Evenement);
            this.Controls.Add(this.label_event);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WindowEvenement";
            this.Text = "WindowEvenement";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Event)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Evenement;
        private System.Windows.Forms.Label label_event;
        private System.Windows.Forms.DataGridView dataGridView_Event;
        private System.Windows.Forms.Button button_clear_image;
        private System.Windows.Forms.Button button_clear_site;
        private System.Windows.Forms.Button button_clear_name;
        private System.Windows.Forms.Button button_clear_ID;
        private System.Windows.Forms.Label label_img_event;
        private System.Windows.Forms.Label label_site_event;
        private System.Windows.Forms.Label label_date_jeu;
        private System.Windows.Forms.Label label_nom_event;
        private System.Windows.Forms.Label label_id_event;
        private System.Windows.Forms.TextBox textBox_Img_event;
        private System.Windows.Forms.TextBox textBox_Site_event;
        private System.Windows.Forms.TextBox textBox_Name_event;
        private System.Windows.Forms.TextBox textBox_ID_event;
        private System.Windows.Forms.DateTimePicker dateTimePicker_event;
        private System.Windows.Forms.Button button_clear_date;
    }
}