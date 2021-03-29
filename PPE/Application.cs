using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show() ;
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {
            openChildForm(new WindowCategorie());
        }

        private void button_Jeux_Click(object sender, EventArgs e)
        {
            openChildForm(new WindowJeu());
        }

        private void button_Event_Click(object sender, EventArgs e)
        {
            //openChildForm(new WindowEvent());
        }

        private void button_Topics_Click(object sender, EventArgs e)
        {
            openChildForm(new WindowTopic());
        }

        private void button_User_Click(object sender, EventArgs e)
        {
            openChildForm(new WindowUtilisateur());
        }
    }
}
