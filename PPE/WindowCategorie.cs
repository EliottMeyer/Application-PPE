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
    public partial class WindowCategorie : Form
    {

        private static MySqlConnection conn = new MySqlConnection("database=bdd_jeux_slam; server=localhost; port=3307; user id=root; pwd=");

        public WindowCategorie()
        {
            InitializeComponent();
            Open_Tab_Categories();
        }

        public void Open_Tab_Categories() // Fonction lorsque l'on rentre dans un onglet
        {
            dataGridView_Categorie.DataSource = display_Categorie_Table(); // lancement de la fonction pour charger la table SQL "categorie" dans le tableau indiqué
            dataGridView_Jeux.DataSource = display_Jeu_Table(); // lancement de la fonction pour charger la table SQL "jeu" dans le tableau indiqué

            button_Add.Enabled = false;
            button_Edit.Enabled = false;
            button_Del.Enabled = false;
        }

        public DataTable display_Categorie_Table() // Fonction pour charger la table SQL "categorie" 
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_cat = new MySqlDataAdapter(); // créé un objet pour remplir    
            DataTable table_cat = new DataTable(); // créé un objet de table de données

            cmd.CommandText = "SELECT * FROM categories";

            mydtadp_cat.SelectCommand = cmd;
            mydtadp_cat.Fill(table_cat); // rempli cette table par les données récupéré par la commande SQL

            return table_cat; // retourne le tableau
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


        private void dataGridView_Categorie_MouseUp(object sender, MouseEventArgs e) // Fonction pour récupérer les valeurs lorsque l'on clic sur un element du tableau 
        {
            int row = dataGridView_Categorie.CurrentCell.RowIndex; // attribue a une variable la valeur de la ligne sur laquelle on a cliqué 

            for (int i = 0; i < 2; i++) // boucle pour chaque cellule de la ligne
            {
                string val = dataGridView_Categorie.Rows[row].Cells[i].Value.ToString(); // sauvegarde la valeur de la cellule pointé
                switch (i)
                {
                    case 0: // pour la premiere cellule 
                        textBox_ID_categorie.Text = val; // on remplit la TEXTBOX de la valeur sauvegarder (ici l'ID)
                    break;
                    case 1: // pour la seconde cellule 
                        textBox_Name_categorie.Text = val; // on remplit la TEXTBOX de la valeur sauvegarder (ici le nom)
                    break;
                }
            }
        }

        private void display_Jeu_from_Categorie(object sender, EventArgs e)
        {
            enable_Button(sender, e);

            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_jeu = new MySqlDataAdapter();
            DataTable table_jeu = new DataTable();

            if (textBox_Name_categorie.Text == "")
            {
                cmd.CommandText = "SELECT * FROM jeux";
            }
            else
            {
                cmd.Parameters.AddWithValue("@name", textBox_Name_categorie.Text);

                cmd.CommandText = "SELECT jeux.id, jeux.name, jeux.description, jeux.site, jeux.images FROM jeux " +
                    "INNER JOIN categoriser ON categoriser.id_jeux = jeux.id " +
                    "INNER JOIN categories ON categories.id = categoriser.id_categories AND categories.name = @name";
            }
            mydtadp_jeu.SelectCommand = cmd;

            dataGridView_Jeux.DataSource = null;
            mydtadp_jeu.Fill(table_jeu);

            dataGridView_Jeux.DataSource = table_jeu;
        }

        
        private void button_Add_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@name", textBox_Name_categorie.Text);

            command.CommandText = "INSERT INTO categories (name) VALUES (@name)";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Insertion effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de l’insertion!");
            }

            conn.Close();

            dataGridView_Categorie.DataSource = display_Categorie_Table();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir modifier la catégorie " + textBox_ID_categorie.Text + " ?", "Modification de la catégorie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@name", textBox_Name_categorie.Text);
                command.Parameters.AddWithValue("@id", textBox_ID_categorie.Text);

                command.CommandText = "UPDATE categories SET name = @name WHERE id = @id ";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Insertion effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification!");
                }

                conn.Close();

                dataGridView_Categorie.DataSource = display_Categorie_Table();
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer la catégorie " + textBox_ID_categorie.Text + " ?", "Suppression de la catégorie", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", textBox_ID_categorie.Text);

                command.CommandText = "DELETE FROM categoriser WHERE id_categories = @id";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM categories WHERE id = @id";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Suppression effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression!");
                }

                conn.Close();

                dataGridView_Categorie.DataSource = display_Categorie_Table();
            }
        }

        private void button_clear_ID_Click(object sender, EventArgs e)
        {
            textBox_ID_categorie.ResetText();
        }

        private void button_clear_Name_Click(object sender, EventArgs e)
        {
            textBox_Name_categorie.ResetText();
        }

        private void enable_Button(object sender, EventArgs e)
        {
            //Catégorie TAB
            if (textBox_ID_categorie.TextLength != 0)
            {
                button_Add.Enabled = false;
                button_Edit.Enabled = true;
                button_Del.Enabled = true;
            }
            else
            {
                button_Add.Enabled = true;
                button_Edit.Enabled = false;
                button_Del.Enabled = false;
            }

            if (textBox_Name_categorie.TextLength == 0)
            {
                button_Add.Enabled = false;
            }
        }
    }
}
