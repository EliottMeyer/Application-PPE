
namespace PPE
{
    partial class WindowCommentaireFromJeu
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
            this.Del_Comment = new System.Windows.Forms.Button();
            this.textBox_Comment_Content = new System.Windows.Forms.TextBox();
            this.label_Comment_Content = new System.Windows.Forms.Label();
            this.label_Comment_list = new System.Windows.Forms.Label();
            this.label_Reponses_list = new System.Windows.Forms.Label();
            this.label_Reponse_Content = new System.Windows.Forms.Label();
            this.textBox_Reponse_Content = new System.Windows.Forms.TextBox();
            this.Del_Reponse = new System.Windows.Forms.Button();
            this.dataGridView_Comments = new System.Windows.Forms.DataGridView();
            this.dataGridView_Reponses = new System.Windows.Forms.DataGridView();
            this.label_Commentaire = new System.Windows.Forms.Label();
            this.label_Username_Commentaire = new System.Windows.Forms.Label();
            this.textBox_Username_Commentaire = new System.Windows.Forms.TextBox();
            this.button_Ban_Commentaire = new System.Windows.Forms.Button();
            this.button_Ban_Reponse = new System.Windows.Forms.Button();
            this.label_Username_Reponse = new System.Windows.Forms.Label();
            this.textBox_Username_Reponse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reponses)).BeginInit();
            this.SuspendLayout();
            // 
            // Del_Comment
            // 
            this.Del_Comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Del_Comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.Del_Comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_Comment.ForeColor = System.Drawing.Color.White;
            this.Del_Comment.Location = new System.Drawing.Point(712, 282);
            this.Del_Comment.Name = "Del_Comment";
            this.Del_Comment.Size = new System.Drawing.Size(188, 30);
            this.Del_Comment.TabIndex = 5;
            this.Del_Comment.Text = "Supprimer le commentaire";
            this.Del_Comment.UseVisualStyleBackColor = false;
            this.Del_Comment.Click += new System.EventHandler(this.Del_Comment_Click);
            // 
            // textBox_Comment_Content
            // 
            this.textBox_Comment_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Comment_Content.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_Comment_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Comment_Content.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Comment_Content.Location = new System.Drawing.Point(640, 96);
            this.textBox_Comment_Content.Multiline = true;
            this.textBox_Comment_Content.Name = "textBox_Comment_Content";
            this.textBox_Comment_Content.ReadOnly = true;
            this.textBox_Comment_Content.Size = new System.Drawing.Size(317, 180);
            this.textBox_Comment_Content.TabIndex = 7;
            this.textBox_Comment_Content.TabStop = false;
            // 
            // label_Comment_Content
            // 
            this.label_Comment_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Comment_Content.AutoSize = true;
            this.label_Comment_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Comment_Content.Location = new System.Drawing.Point(722, 76);
            this.label_Comment_Content.Name = "label_Comment_Content";
            this.label_Comment_Content.Size = new System.Drawing.Size(170, 17);
            this.label_Comment_Content.TabIndex = 8;
            this.label_Comment_Content.Text = "Message du commentaire";
            // 
            // label_Comment_list
            // 
            this.label_Comment_list.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Comment_list.AutoSize = true;
            this.label_Comment_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Comment_list.Location = new System.Drawing.Point(246, 76);
            this.label_Comment_list.Name = "label_Comment_list";
            this.label_Comment_list.Size = new System.Drawing.Size(157, 17);
            this.label_Comment_list.TabIndex = 9;
            this.label_Comment_list.Text = "Liste des commentaires";
            // 
            // label_Reponses_list
            // 
            this.label_Reponses_list.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Reponses_list.AutoSize = true;
            this.label_Reponses_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Reponses_list.Location = new System.Drawing.Point(247, 423);
            this.label_Reponses_list.Name = "label_Reponses_list";
            this.label_Reponses_list.Size = new System.Drawing.Size(128, 17);
            this.label_Reponses_list.TabIndex = 10;
            this.label_Reponses_list.Text = "Liste des réponses";
            // 
            // label_Reponse_Content
            // 
            this.label_Reponse_Content.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Reponse_Content.AutoSize = true;
            this.label_Reponse_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Reponse_Content.Location = new System.Drawing.Point(736, 423);
            this.label_Reponse_Content.Name = "label_Reponse_Content";
            this.label_Reponse_Content.Size = new System.Drawing.Size(156, 17);
            this.label_Reponse_Content.TabIndex = 12;
            this.label_Reponse_Content.Text = "Message de la réponse";
            // 
            // textBox_Reponse_Content
            // 
            this.textBox_Reponse_Content.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_Reponse_Content.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_Reponse_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Reponse_Content.Location = new System.Drawing.Point(640, 443);
            this.textBox_Reponse_Content.Multiline = true;
            this.textBox_Reponse_Content.Name = "textBox_Reponse_Content";
            this.textBox_Reponse_Content.ReadOnly = true;
            this.textBox_Reponse_Content.Size = new System.Drawing.Size(317, 180);
            this.textBox_Reponse_Content.TabIndex = 11;
            this.textBox_Reponse_Content.TextChanged += new System.EventHandler(this.enable_button);
            // 
            // Del_Reponse
            // 
            this.Del_Reponse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Del_Reponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.Del_Reponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_Reponse.ForeColor = System.Drawing.Color.White;
            this.Del_Reponse.Location = new System.Drawing.Point(712, 629);
            this.Del_Reponse.Name = "Del_Reponse";
            this.Del_Reponse.Size = new System.Drawing.Size(188, 30);
            this.Del_Reponse.TabIndex = 14;
            this.Del_Reponse.Text = "Supprimer la réponse";
            this.Del_Reponse.UseVisualStyleBackColor = false;
            this.Del_Reponse.Click += new System.EventHandler(this.Del_Reponse_Click);
            // 
            // dataGridView_Comments
            // 
            this.dataGridView_Comments.AllowUserToAddRows = false;
            this.dataGridView_Comments.AllowUserToDeleteRows = false;
            this.dataGridView_Comments.AllowUserToResizeRows = false;
            this.dataGridView_Comments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Comments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Comments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Comments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Comments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Comments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Comments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Comments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Comments.EnableHeadersVisualStyles = false;
            this.dataGridView_Comments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Comments.Location = new System.Drawing.Point(10, 96);
            this.dataGridView_Comments.MultiSelect = false;
            this.dataGridView_Comments.Name = "dataGridView_Comments";
            this.dataGridView_Comments.ReadOnly = true;
            this.dataGridView_Comments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Comments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Comments.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Comments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Comments.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.dataGridView_Comments.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Comments.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView_Comments.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Comments.RowTemplate.Height = 24;
            this.dataGridView_Comments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Comments.Size = new System.Drawing.Size(600, 300);
            this.dataGridView_Comments.TabIndex = 56;
            this.dataGridView_Comments.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Comments_MouseUp);
            // 
            // dataGridView_Reponses
            // 
            this.dataGridView_Reponses.AllowUserToAddRows = false;
            this.dataGridView_Reponses.AllowUserToDeleteRows = false;
            this.dataGridView_Reponses.AllowUserToResizeRows = false;
            this.dataGridView_Reponses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Reponses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Reponses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Reponses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Reponses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Reponses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Reponses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Reponses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Reponses.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Reponses.EnableHeadersVisualStyles = false;
            this.dataGridView_Reponses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.dataGridView_Reponses.Location = new System.Drawing.Point(10, 441);
            this.dataGridView_Reponses.MultiSelect = false;
            this.dataGridView_Reponses.Name = "dataGridView_Reponses";
            this.dataGridView_Reponses.ReadOnly = true;
            this.dataGridView_Reponses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Reponses.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Reponses.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Reponses.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Reponses.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.dataGridView_Reponses.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Reponses.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView_Reponses.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Reponses.RowTemplate.Height = 24;
            this.dataGridView_Reponses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Reponses.Size = new System.Drawing.Size(600, 300);
            this.dataGridView_Reponses.TabIndex = 57;
            this.dataGridView_Reponses.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Reponses_MouseUp);
            // 
            // label_Commentaire
            // 
            this.label_Commentaire.BackColor = System.Drawing.Color.Transparent;
            this.label_Commentaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Commentaire.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Commentaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_Commentaire.Location = new System.Drawing.Point(0, 0);
            this.label_Commentaire.Name = "label_Commentaire";
            this.label_Commentaire.Size = new System.Drawing.Size(982, 59);
            this.label_Commentaire.TabIndex = 58;
            this.label_Commentaire.Text = "Label";
            this.label_Commentaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Username_Commentaire
            // 
            this.label_Username_Commentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Username_Commentaire.AutoSize = true;
            this.label_Username_Commentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username_Commentaire.Location = new System.Drawing.Point(637, 340);
            this.label_Username_Commentaire.Name = "label_Username_Commentaire";
            this.label_Username_Commentaire.Size = new System.Drawing.Size(79, 17);
            this.label_Username_Commentaire.TabIndex = 60;
            this.label_Username_Commentaire.Text = "Utilisateur :";
            // 
            // textBox_Username_Commentaire
            // 
            this.textBox_Username_Commentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Username_Commentaire.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_Username_Commentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username_Commentaire.Location = new System.Drawing.Point(722, 335);
            this.textBox_Username_Commentaire.Multiline = true;
            this.textBox_Username_Commentaire.Name = "textBox_Username_Commentaire";
            this.textBox_Username_Commentaire.ReadOnly = true;
            this.textBox_Username_Commentaire.Size = new System.Drawing.Size(168, 25);
            this.textBox_Username_Commentaire.TabIndex = 59;
            // 
            // button_Ban_Commentaire
            // 
            this.button_Ban_Commentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Ban_Commentaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.button_Ban_Commentaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ban_Commentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ban_Commentaire.ForeColor = System.Drawing.Color.White;
            this.button_Ban_Commentaire.Location = new System.Drawing.Point(712, 366);
            this.button_Ban_Commentaire.Name = "button_Ban_Commentaire";
            this.button_Ban_Commentaire.Size = new System.Drawing.Size(188, 30);
            this.button_Ban_Commentaire.TabIndex = 61;
            this.button_Ban_Commentaire.Text = "Bannir l\'utilisateur";
            this.button_Ban_Commentaire.UseVisualStyleBackColor = false;
            this.button_Ban_Commentaire.Click += new System.EventHandler(this.button_Ban_Commentaire_Click);
            // 
            // button_Ban_Reponse
            // 
            this.button_Ban_Reponse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Ban_Reponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.button_Ban_Reponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ban_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ban_Reponse.ForeColor = System.Drawing.Color.White;
            this.button_Ban_Reponse.Location = new System.Drawing.Point(712, 713);
            this.button_Ban_Reponse.Name = "button_Ban_Reponse";
            this.button_Ban_Reponse.Size = new System.Drawing.Size(188, 30);
            this.button_Ban_Reponse.TabIndex = 64;
            this.button_Ban_Reponse.Text = "Bannir l\'utilisateur";
            this.button_Ban_Reponse.UseVisualStyleBackColor = false;
            this.button_Ban_Reponse.Click += new System.EventHandler(this.button_Ban_Reponse_Click);
            // 
            // label_Username_Reponse
            // 
            this.label_Username_Reponse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Username_Reponse.AutoSize = true;
            this.label_Username_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username_Reponse.Location = new System.Drawing.Point(637, 687);
            this.label_Username_Reponse.Name = "label_Username_Reponse";
            this.label_Username_Reponse.Size = new System.Drawing.Size(79, 17);
            this.label_Username_Reponse.TabIndex = 63;
            this.label_Username_Reponse.Text = "Utilisateur :";
            // 
            // textBox_Username_Reponse
            // 
            this.textBox_Username_Reponse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_Username_Reponse.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_Username_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username_Reponse.Location = new System.Drawing.Point(722, 682);
            this.textBox_Username_Reponse.Multiline = true;
            this.textBox_Username_Reponse.Name = "textBox_Username_Reponse";
            this.textBox_Username_Reponse.ReadOnly = true;
            this.textBox_Username_Reponse.Size = new System.Drawing.Size(168, 25);
            this.textBox_Username_Reponse.TabIndex = 62;
            // 
            // WindowCommentaireFromJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.button_Ban_Reponse);
            this.Controls.Add(this.label_Username_Reponse);
            this.Controls.Add(this.textBox_Username_Reponse);
            this.Controls.Add(this.button_Ban_Commentaire);
            this.Controls.Add(this.label_Username_Commentaire);
            this.Controls.Add(this.textBox_Username_Commentaire);
            this.Controls.Add(this.label_Commentaire);
            this.Controls.Add(this.dataGridView_Reponses);
            this.Controls.Add(this.dataGridView_Comments);
            this.Controls.Add(this.Del_Reponse);
            this.Controls.Add(this.label_Reponse_Content);
            this.Controls.Add(this.textBox_Reponse_Content);
            this.Controls.Add(this.label_Reponses_list);
            this.Controls.Add(this.label_Comment_list);
            this.Controls.Add(this.label_Comment_Content);
            this.Controls.Add(this.textBox_Comment_Content);
            this.Controls.Add(this.Del_Comment);
            this.Name = "WindowCommentaireFromJeu";
            this.Text = "Commentaires";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reponses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Del_Comment;
        private System.Windows.Forms.TextBox textBox_Comment_Content;
        private System.Windows.Forms.Label label_Comment_Content;
        private System.Windows.Forms.Label label_Comment_list;
        private System.Windows.Forms.Label label_Reponses_list;
        private System.Windows.Forms.Label label_Reponse_Content;
        private System.Windows.Forms.TextBox textBox_Reponse_Content;
        private System.Windows.Forms.Button Del_Reponse;
        private System.Windows.Forms.DataGridView dataGridView_Comments;
        private System.Windows.Forms.DataGridView dataGridView_Reponses;
        private System.Windows.Forms.Label label_Commentaire;
        private System.Windows.Forms.Label label_Username_Commentaire;
        private System.Windows.Forms.TextBox textBox_Username_Commentaire;
        private System.Windows.Forms.Button button_Ban_Commentaire;
        private System.Windows.Forms.Button button_Ban_Reponse;
        private System.Windows.Forms.Label label_Username_Reponse;
        private System.Windows.Forms.TextBox textBox_Username_Reponse;
    }
}