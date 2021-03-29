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
    public partial class WindowJeu : Form
    {

        private static MySqlConnection conn = new MySqlConnection("database=bdd_jeux_slam; server=localhost; port=3307; user id=root; pwd=");

        public WindowJeu()
        {
            InitializeComponent();
            Open_Tab_Jeux();
        }

        public void Open_Tab_Jeux()
        {
            dataGridView_Jeux.DataSource = display_Jeu_Table();

            MySqlDataAdapter mydtadp = new MySqlDataAdapter();
            DataTable table_jeu = new DataTable();
            mydtadp.SelectCommand = new MySqlCommand("SELECT * FROM categories", conn);
            mydtadp.Fill(table_jeu);
            listBoxAllCategories.DataSource = table_jeu;
            listBoxAllCategories.DisplayMember = "name";

            button_Add.Enabled = false;
            button_Edit.Enabled = false;
            button_Del.Enabled = false;
            button_Commentaire.Enabled = false;
        }

        public DataTable display_Jeu_Table()
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_jeu = new MySqlDataAdapter();
            DataTable table_jeu = new DataTable();

            cmd.CommandText = "SELECT * FROM jeux";
            mydtadp_jeu.SelectCommand = cmd;

            mydtadp_jeu.Fill(table_jeu);

            return table_jeu;
        }

        private void dataGridView_Jeux_MouseUp(object sendere, MouseEventArgs ee)
        {
            for (int i = 0; i < listBoxAllCategories.Items.Count; i++)
                listBoxAllCategories.SetItemCheckState(i, CheckState.Unchecked);

            int row = dataGridView_Jeux.CurrentCell.RowIndex;
            int id_jeu = 0;

            for (int i = 0; i < 5; i++)
            {
                string val = dataGridView_Jeux.Rows[row].Cells[i].Value.ToString();
                switch (i)
                {
                    case 0:
                        textBox_ID_jeu.Text = val;
                        try
                        {
                            id_jeu = Convert.ToInt32(val);
                        }
                        catch { }
                        break;
                    case 1:
                        textBox_Name_jeu.Text = val;
                        break;
                    case 2:
                        textBox_Desc_jeu.Text = val;
                        break;
                    case 3:
                        textBox_Site_jeu.Text = val;
                        break;
                    case 4:
                        textBox_Img_jeu.Text = val;
                        break;
                }

            }

            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id_jeu", id_jeu);

            command.CommandText = "" +
                "SELECT c.id " +
                "FROM Categories c " +
                "INNER JOIN categoriser cr ON c.id = cr.id_categories " +
                "INNER JOIN jeux j ON j.id = @id_jeu AND j.id = cr.id_jeux";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int valeur = reader.GetInt32(0);
                listBoxAllCategories.SetItemChecked(valeur - 1, true);
            }

            conn.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@name", textBox_Name_jeu.Text);
            command.Parameters.AddWithValue("@description", textBox_Desc_jeu.Text);
            command.Parameters.AddWithValue("@site", textBox_Site_jeu.Text);
            command.Parameters.AddWithValue("@images", textBox_Img_jeu.Text);

            command.CommandText = "INSERT INTO jeux (name, description, site, images) VALUES (@name, @description, @site, @images) ";

            if (command.ExecuteNonQuery() > 0)
            {
                foreach (object itemChecked in listBoxAllCategories.CheckedItems)
                {
                    MySqlCommand command3 = conn.CreateCommand();
                    DataRowView castedItem = itemChecked as DataRowView;
                    command3.Parameters.AddWithValue("@name_cat", castedItem["name"].ToString());
                    command3.CommandText = "INSERT INTO categoriser (id_jeux, id_categories) " +
                        "VALUES ((SELECT MAX(id) FROM jeux), (SELECT id FROM categories WHERE categories.name = @name_cat)) ";
                    command3.ExecuteNonQuery();

                }
                MessageBox.Show("Insertion effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de l’insertion!");
            }

            conn.Close();

            dataGridView_Jeux.DataSource = display_Jeu_Table();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir modifier le jeu " + textBox_ID_jeu.Text + " ?", "Modification de jeu", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@name", textBox_Name_jeu.Text);
                command.Parameters.AddWithValue("@description", textBox_Desc_jeu.Text);
                command.Parameters.AddWithValue("@site", textBox_Site_jeu.Text);
                command.Parameters.AddWithValue("@images", textBox_Img_jeu.Text);
                command.Parameters.AddWithValue("@id", textBox_ID_jeu.Text);

                command.CommandText = "DELETE FROM categoriser WHERE id_jeux = @id";
                command.ExecuteNonQuery();
                command.CommandText = "UPDATE jeux SET name = @name , description = @description , site = @site , images = @images WHERE id = @id";


                if (command.ExecuteNonQuery() > 0)
                {
                    foreach (object itemChecked in listBoxAllCategories.CheckedItems)
                    {
                        MySqlCommand command3 = conn.CreateCommand();
                        DataRowView castedItem = itemChecked as DataRowView;
                        command3.Parameters.AddWithValue("@name_cat", castedItem["name"].ToString());
                        command3.CommandText = "INSERT INTO categoriser (id_jeux, id_categories) " +
                            "VALUES ((SELECT MAX(id) FROM jeux), (SELECT id FROM categories WHERE categories.name = @name_cat)) ";
                        command3.ExecuteNonQuery();

                    }
                    MessageBox.Show("Modification effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification!");
                }

                conn.Close();

                dataGridView_Jeux.DataSource = display_Jeu_Table();
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer le jeu " + textBox_ID_jeu.Text + " ?", "Suppression de jeu", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            { 
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", textBox_ID_jeu.Text);

                command.CommandText = "DELETE FROM categoriser WHERE id_jeux = @id";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM jeux WHERE id = @id";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Suppression effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression!");
                }

                conn.Close();

                dataGridView_Jeux.DataSource = display_Jeu_Table();
            }  
        }

        private void button_clear_ID_Click(object sender, EventArgs e)
        {
            textBox_ID_jeu.ResetText();
        }

        private void button_clear_name_Click(object sender, EventArgs e)
        {
            textBox_Name_jeu.ResetText();
        }

        private void button_clear_site_Click(object sender, EventArgs e)
        {
            textBox_Site_jeu.ResetText();
        }

        private void button_clear_image_Click(object sender, EventArgs e)
        {
            textBox_Img_jeu.ResetText();
        }

        private void button_clear_description_Click(object sender, EventArgs e)
        {
            textBox_Desc_jeu.ResetText();
        }

        private void button_clear_categories_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxAllCategories.Items.Count; i++)
                listBoxAllCategories.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void enable_Button(object sender, EventArgs e)
        {
            if (textBox_ID_jeu.TextLength != 0)
            {
                button_Add.Enabled = false;
                button_Edit.Enabled = true;
                button_Del.Enabled = true;
                button_Commentaire.Enabled = true;
            }
            else
            {
                button_Add.Enabled = true;
                button_Edit.Enabled = false;
                button_Del.Enabled = false;
                button_Commentaire.Enabled = false;
            }

            if (textBox_Name_jeu.TextLength == 0 || textBox_Desc_jeu.TextLength == 0 || textBox_Img_jeu.TextLength == 0)
            {
                button_Add.Enabled = false;
                button_Edit.Enabled = false;
            }
        }

        private void button_Commentaire_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(textBox_ID_jeu.Text, out n);
            if (isNumeric == true)
            {
                WindowCommentaireFromJeu Jeu_Comments = new WindowCommentaireFromJeu(Convert.ToInt32(textBox_ID_jeu.Text));
                Jeu_Comments.Show();
            }
        }
    }
}
