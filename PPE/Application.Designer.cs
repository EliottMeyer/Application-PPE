
namespace PPE
{
    partial class Application
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.button_User = new System.Windows.Forms.Button();
            this.button_Topic = new System.Windows.Forms.Button();
            this.button_Event = new System.Windows.Forms.Button();
            this.button_Jeux = new System.Windows.Forms.Button();
            this.button_Categories = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.panelSideMenu.Controls.Add(this.button_User);
            this.panelSideMenu.Controls.Add(this.button_Topic);
            this.panelSideMenu.Controls.Add(this.button_Event);
            this.panelSideMenu.Controls.Add(this.button_Jeux);
            this.panelSideMenu.Controls.Add(this.button_Categories);
            this.panelSideMenu.Controls.Add(this.panel);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.Color.Black;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 853);
            this.panelSideMenu.TabIndex = 0;
            // 
            // button_User
            // 
            this.button_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_User.FlatAppearance.BorderSize = 0;
            this.button_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_User.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_User.ForeColor = System.Drawing.Color.White;
            this.button_User.Location = new System.Drawing.Point(0, 469);
            this.button_User.Name = "button_User";
            this.button_User.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_User.Size = new System.Drawing.Size(200, 75);
            this.button_User.TabIndex = 5;
            this.button_User.Text = "Utilisateurs";
            this.button_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_User.UseVisualStyleBackColor = true;
            this.button_User.Click += new System.EventHandler(this.button_User_Click);
            // 
            // button_Topic
            // 
            this.button_Topic.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Topic.FlatAppearance.BorderSize = 0;
            this.button_Topic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Topic.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Topic.ForeColor = System.Drawing.Color.White;
            this.button_Topic.Location = new System.Drawing.Point(0, 394);
            this.button_Topic.Name = "button_Topic";
            this.button_Topic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Topic.Size = new System.Drawing.Size(200, 75);
            this.button_Topic.TabIndex = 4;
            this.button_Topic.Text = "Topics";
            this.button_Topic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Topic.UseVisualStyleBackColor = true;
            // 
            // button_Event
            // 
            this.button_Event.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Event.FlatAppearance.BorderSize = 0;
            this.button_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Event.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Event.ForeColor = System.Drawing.Color.White;
            this.button_Event.Location = new System.Drawing.Point(0, 319);
            this.button_Event.Name = "button_Event";
            this.button_Event.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Event.Size = new System.Drawing.Size(200, 75);
            this.button_Event.TabIndex = 3;
            this.button_Event.Text = "Evènements";
            this.button_Event.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Event.UseVisualStyleBackColor = true;
            // 
            // button_Jeux
            // 
            this.button_Jeux.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Jeux.FlatAppearance.BorderSize = 0;
            this.button_Jeux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Jeux.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Jeux.ForeColor = System.Drawing.Color.White;
            this.button_Jeux.Location = new System.Drawing.Point(0, 244);
            this.button_Jeux.Name = "button_Jeux";
            this.button_Jeux.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Jeux.Size = new System.Drawing.Size(200, 75);
            this.button_Jeux.TabIndex = 2;
            this.button_Jeux.Text = "Jeux";
            this.button_Jeux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Jeux.UseVisualStyleBackColor = true;
            this.button_Jeux.Click += new System.EventHandler(this.button_Jeux_Click);
            // 
            // button_Categories
            // 
            this.button_Categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Categories.FlatAppearance.BorderSize = 0;
            this.button_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories.ForeColor = System.Drawing.Color.White;
            this.button_Categories.Location = new System.Drawing.Point(0, 169);
            this.button_Categories.Name = "button_Categories";
            this.button_Categories.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Categories.Size = new System.Drawing.Size(200, 75);
            this.button_Categories.TabIndex = 1;
            this.button_Categories.Text = "Catégories";
            this.button_Categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Categories.UseVisualStyleBackColor = true;
            this.button_Categories.Click += new System.EventHandler(this.button_Categories_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 169);
            this.panel.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(982, 853);
            this.panelChildForm.TabIndex = 2;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(1122, 750);
            this.Name = "Application";
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button button_User;
        private System.Windows.Forms.Button button_Topic;
        private System.Windows.Forms.Button button_Event;
        private System.Windows.Forms.Button button_Jeux;
        private System.Windows.Forms.Button button_Categories;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelChildForm;
    }
}