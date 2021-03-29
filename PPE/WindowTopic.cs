using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE
{
    public partial class WindowTopic : Form
    {

        private static MySqlConnection conn = new MySqlConnection("database=bdd_jeux_slam; server=localhost; port=3307; user id=root; pwd=");

        public WindowTopic()
        {
            InitializeComponent();
            Open_Tab_Topics();
        }

        public void Open_Tab_Topics()
        {
            dataGridView_Topics_jeu.DataSource = display_Jeu_Table();

            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_jeu = new MySqlDataAdapter();
            DataTable table_jeu = new DataTable();

            cmd.CommandText = "SELECT name FROM jeux";
            mydtadp_jeu.SelectCommand = cmd;

            mydtadp_jeu.Fill(table_jeu);

            for (int i = 0; i < table_jeu.Rows.Count; i++)
            {
                comboBox_Jeu_topic.Items.Add(table_jeu.Rows[i]["name"]);
            }

            button_Edit.Enabled = false;
            button_Del.Enabled = false;
            button_Commentaire.Enabled = false;
        }

        public DataTable display_Jeu_Table()
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_jeu = new MySqlDataAdapter();
            DataTable table_jeu = new DataTable();

            cmd.CommandText = "SELECT j.id, j.name, COUNT(t.name_jeu) AS topics " +
                "FROM jeux j " +
                "LEFT JOIN topic t ON j.name = t.name_jeu " +
                "GROUP BY j.name ";
            mydtadp_jeu.SelectCommand = cmd;

            mydtadp_jeu.Fill(table_jeu);

            return table_jeu;
        }

        public DataTable display_Topic_Table()
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_topic = new MySqlDataAdapter();
            DataTable table_topic = new DataTable();
            cmd.Parameters.AddWithValue("@jeu", comboBox_Jeu_topic.Text);

            cmd.CommandText = "SELECT * FROM topic WHERE name_jeu = @jeu";
            mydtadp_topic.SelectCommand = cmd;

            mydtadp_topic.Fill(table_topic);

            return table_topic;
        }

        private void dataGridView_Jeux_MouseUp(object sendere, MouseEventArgs ee)
        {
            int row = dataGridView_Topics_jeu.CurrentCell.RowIndex;

            for (int i = 0; i < 3; i++)
            {
                string val = dataGridView_Topics_jeu.Rows[row].Cells[i].Value.ToString();
                switch (i)
                {
                    case 1:
                        comboBox_Jeu_topic.SelectedIndex = comboBox_Jeu_topic.FindStringExact(val);
                    break;
                }
            }

            dataGridView_Topics_sujet.DataSource = display_Topic_Table();
        }

        private void dataGridView_Topic_MouseUp(object sender, MouseEventArgs e)
        {
            if (dataGridView_Topics_sujet.CurrentCell != null)
            {
                int row = dataGridView_Topics_sujet.CurrentCell.RowIndex;

                for (int i = 0; i < 4; i++)
                {
                    string val = dataGridView_Topics_sujet.Rows[row].Cells[i].Value.ToString();
                    switch (i)
                    {
                        case 0:
                            textBox_ID_topic.Text = val;
                            break;
                        case 2:
                            textBox_Titre_topic.Text = val;
                            break;
                        case 3:
                            textBox_Content_topic.Text = val;
                            break;
                    }
                }
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir modifier le topic " + textBox_ID_topic.Text + " ?", "Modification de topic", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@ID", textBox_ID_topic.Text);
                command.Parameters.AddWithValue("@jeu", comboBox_Jeu_topic.Text);
                command.Parameters.AddWithValue("@content", textBox_Content_topic.Text);
                command.Parameters.AddWithValue("@titre", textBox_Titre_topic.Text);

                command.CommandText = "UPDATE topic SET name_jeu = @jeu , titre = @titre , contenu = @content WHERE id = @ID";


                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Modification effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification!");
                }

                conn.Close();

                dataGridView_Topics_sujet.DataSource = display_Topic_Table();
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer le topic " + textBox_ID_topic.Text + " ?", "Suppression de topic", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            { 
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", textBox_ID_topic.Text);

                command.CommandText = "DELETE FROM topic WHERE id = @id";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Suppression effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression!");
                }

                conn.Close();

                dataGridView_Topics_jeu.DataSource = display_Jeu_Table();
                dataGridView_Topics_sujet.DataSource = display_Topic_Table();
            }  
        }

        private void button_clear_ID_Click(object sender, EventArgs e)
        {
            textBox_ID_topic.ResetText();
        }

        private void button_clear_titre_Click(object sender, EventArgs e)
        {
            textBox_Titre_topic.ResetText();
        }

        private void button_clear_content_Click(object sender, EventArgs e)
        {
            textBox_Content_topic.ResetText();
        }

        private void enable_Button(object sender, EventArgs e)
        {
            if (textBox_ID_topic.TextLength != 0)
            {
                button_Edit.Enabled = true;
                button_Del.Enabled = true;
                button_Commentaire.Enabled = true;
            }
            else
            {
                button_Edit.Enabled = false;
                button_Del.Enabled = false;
                button_Commentaire.Enabled = false;
            }

            if (comboBox_Jeu_topic.Text == "" || textBox_Titre_topic.TextLength == 0)
            {
                button_Edit.Enabled = false;
            }
        }

        private void button_Commentaire_Click(object sender, EventArgs e)
        {
            WindowCommentaireFromTopic Topic_Comments = new WindowCommentaireFromTopic(Convert.ToInt32(textBox_ID_topic.Text));
            Topic_Comments.Show();
        }
    }
}
