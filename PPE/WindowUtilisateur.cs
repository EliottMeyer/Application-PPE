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
    public partial class WindowUtilisateur : Form
    {
        private static MySqlConnection conn = new MySqlConnection("database=bdd_jeux_slam; server=localhost; port=3307; user id=root; pwd=");

        public WindowUtilisateur()
        {
            InitializeComponent();
            Open_Tab_User();
        }

        public void Open_Tab_User() // Fonction lorsque l'on rentre dans un onglet
        {
            dataGridView_Users.DataSource = display_User_Table(); // lancement de la fonction pour charger la table SQL "user" dans le tableau indiqué

            button_Reset.Enabled = false;
            button_Edit.Enabled = false;
            button_Del.Enabled = false;
        }

        public DataTable display_User_Table() // Fonction pour charger la table SQL "user" 
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_user = new MySqlDataAdapter(); // créé un objet pour remplir    
            DataTable table_user = new DataTable(); // créé un objet de table de données

            cmd.CommandText = "SELECT * FROM user";

            mydtadp_user.SelectCommand = cmd;
            mydtadp_user.Fill(table_user); // rempli cette table par les données récupéré par la commande SQL

            return table_user; // retourne le tableau
        }

        private void dataGridView_Users_MouseUp(object sender, MouseEventArgs e)
        {
            int row = dataGridView_Users.CurrentCell.RowIndex; // attribue a une variable la valeur de la ligne sur laquelle on a cliqué 

            for (int i = 0; i < 11; i++) // boucle pour chaque cellule de la ligne
            {
                string val = dataGridView_Users.Rows[row].Cells[i].Value.ToString(); // sauvegarde la valeur de la cellule pointé
                switch (i)
                {
                    case 0:
                        textBox_ID_user.Text = val;
                    break;
                    case 1:
                        textBox_Username_user.Text = val;
                    break;
                    case 2:
                        textBox_Email_user.Text = val;
                    break;
                    case 4:
                        textBox_Nom_user.Text = val;
                    break;
                    case 5:
                        textBox_Prenom_user.Text = val;
                    break;
                    case 6:
                        textBox_Anniv_user.Text = val;
                    break;
                    case 7:
                        textBox_Numero_user.Text = val;
                    break;
                    case 8:
                        textBox_Adresse_user.Text = val;
                    break;
                    case 9:
                        textBox_Pays_user.Text = val;
                    break;
                    case 10:
                        comboBox_Role_user.SelectedIndex = comboBox_Role_user.FindStringExact(val);
                    break;
                }
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir réinitialiser le mot de passe du l'utilisateur " + textBox_ID_user.Text + " ?", "Réinitialisation de mot de passe", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", textBox_ID_user.Text);

                command.CommandText = "UPDATE user SET password = '' WHERE id = @id ";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Mot de passe réinitialisé!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de l’insertion!");
                }

                conn.Close();

                dataGridView_Users.DataSource = display_User_Table();
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir modifier l'utilisateur " + textBox_ID_user.Text + " ?", "Modification d'utilisateur", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", textBox_ID_user.Text);
                command.Parameters.AddWithValue("@username", textBox_Username_user.Text);
                command.Parameters.AddWithValue("@email", textBox_Email_user.Text);
                command.Parameters.AddWithValue("@nom", textBox_Nom_user.Text);
                command.Parameters.AddWithValue("@prenom", textBox_Prenom_user.Text);
                command.Parameters.AddWithValue("@anniv", textBox_Anniv_user.Text);
                command.Parameters.AddWithValue("@num", textBox_Numero_user.Text);
                command.Parameters.AddWithValue("@adresse", textBox_Adresse_user.Text);
                command.Parameters.AddWithValue("@pays", textBox_Pays_user.Text);
                command.Parameters.AddWithValue("@role", comboBox_Role_user.Text);

                command.CommandText = "UPDATE user SET username = @username , email = @email , nom = @nom , prenom = @prenom, birthday = @anniv, num_tel = @num, adresse = @adresse, pays = @pays, status = @role WHERE id = @id";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Modification effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification!");
                }

                conn.Close();

                dataGridView_Users.DataSource = display_User_Table();
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer l'utilisateur " + textBox_ID_user.Text + " ?", "Suppression d'utilisateur", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", textBox_ID_user.Text);

                command.CommandText = "DELETE FROM like_dislike_comment WHERE id_comm = (SELECT id FROM commentaires WHERE id_user = @id)";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM like_dislike_topic_comment WHERE id_comm = (SELECT id FROM topic_comment WHERE id_user = @id)";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM reply_comment WHERE id_comment = (SELECT id FROM commentaires WHERE id_user = @id)";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM reply_comment WHERE id_user = @id";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM commentaires WHERE id_user = @id";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM reply_topic_comment WHERE id_topic_comment = (SELECT id FROM topic_comment WHERE id_user = @id)";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM reply_topic_comment WHERE id_user = @id";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM topic_comment WHERE id_user = @id";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM like_dislike_comment WHERE id_user = @id";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM like_dislike_topic_comment WHERE id_user = @id";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM user WHERE id = @id";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Suppression effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression!");
                }

                conn.Close();

                dataGridView_Users.DataSource = display_User_Table();
            }
        }

        private void button_clear_ID_Click(object sender, EventArgs e)
        {
            textBox_ID_user.ResetText();
        }

        private void button_clear_username_Click(object sender, EventArgs e)
        {
            textBox_Username_user.ResetText();
        }

        private void button_clear_prenom_Click(object sender, EventArgs e)
        {
            textBox_Prenom_user.ResetText();
        }

        private void button_clear_nom_Click(object sender, EventArgs e)
        {
            textBox_Nom_user.ResetText();
        }

        private void button_clear_email_Click(object sender, EventArgs e)
        {
            textBox_Email_user.ResetText();
        }

        private void button_clear_anniversaire_Click(object sender, EventArgs e)
        {
            textBox_Anniv_user.ResetText();
        }

        private void button_clear_numero_Click(object sender, EventArgs e)
        {
            textBox_Numero_user.ResetText();
        }

        private void button_clear_adresse_Click(object sender, EventArgs e)
        {
            textBox_Adresse_user.ResetText();
        }

        private void button_clear_pays_Click(object sender, EventArgs e)
        {
            textBox_Pays_user.ResetText();
        }

        private void enable_Button(object sender, EventArgs e)
        {
            if (textBox_ID_user.TextLength != 0)
            {
                button_Reset.Enabled = true;
                button_Edit.Enabled = true;
                button_Del.Enabled = true;
            }
            else
            {
                button_Reset.Enabled = false;
                button_Edit.Enabled = false;
                button_Del.Enabled = false;
            }

            if (textBox_Username_user.TextLength == 0 || textBox_Email_user.TextLength == 0 || comboBox_Role_user.Text == "")
            {
                button_Edit.Enabled = false;
            }
        }
    }
}
