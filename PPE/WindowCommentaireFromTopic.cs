﻿using System;
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
    public partial class WindowCommentaireFromTopic : Form
    {
        private static MySqlConnection conn = new MySqlConnection("database=bdd_jeux_slam; server=localhost; port=3307; user id=root; pwd=");

        public WindowCommentaireFromTopic(int id_item)
        {
            InitializeComponent();
            dataGridView_Comments.DataSource = display_Comments_Table(id_item);
            Globals.id_topic = id_item;
            GiveNameToLabel(id_item);
        }

        public static class Globals
        {
            public static Int32 id_topic;
            public static Int32 id_reponse;
            public static Int32 id_commentaire;
        }

        public void GiveNameToLabel(int id_topic)
        {
            conn.Open();
            string query = "SELECT * FROM topic WHERE id=" + id_topic;
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            reader.Read();
            label_Commentaire.Text = "Commentaires du topic : " + reader.GetString("titre");
            conn.Close();
        }

        public DataTable display_Comments_Table(int id_topic)
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_com = new MySqlDataAdapter(); // créé un objet pour remplir    
            DataTable table_com = new DataTable(); // créé un objet de table de données

            cmd.Parameters.AddWithValue("@id_topic", id_topic);

            cmd.CommandText = "SELECT tc.id_topic_comment, u.username, tc.contenu, tc.date_create, COUNT(ldtc.id_topic) AS likes, COUNT(ldtc2.id_topic) AS dislikes " +
            "FROM topic_comment tc " +
            "INNER JOIN user u ON u.id = tc.id_user " +
            "LEFT JOIN like_dislike_topic_comment ldtc ON tc.id_topic_comment = ldtc.id_topic AND ldtc.type = 'like' " +
            "LEFT JOIN like_dislike_topic_comment ldtc2 ON tc.id_topic_comment = ldtc2.id_topic AND ldtc2.type='dislike' " +
            "WHERE tc.id_topic = @id_topic " +
            "GROUP BY tc.id_topic_comment";
            
            mydtadp_com.SelectCommand = cmd;
            mydtadp_com.Fill(table_com); // rempli cette table par les données récupéré par la commande SQL

            textBox_Comment_Content.Text = "";
            textBox_Username_Commentaire.Text = "";
            Del_Comment.Enabled = false;
            button_Ban_Commentaire.Enabled = false;
            Del_Reponse.Enabled = false;
            button_Ban_Reponse.Enabled = false;

            return table_com; // retourne le tableau
        }

        private void dataGridView_Comments_MouseUp(object sender, MouseEventArgs e) // Fonction pour récupérer les valeurs lorsque l'on clic sur un element du tableau 
        {

            if (dataGridView_Comments.CurrentCell != null)
            {
                int row = dataGridView_Comments.CurrentCell.RowIndex; // attribue a une variable la valeur de la ligne sur laquelle on a cliqué 

                string id_comm = dataGridView_Comments.Rows[row].Cells[0].Value.ToString();
                string contenu = dataGridView_Comments.Rows[row].Cells[2].Value.ToString(); // sauvegarde le message de la cellule pointé

                textBox_Username_Commentaire.Text = dataGridView_Comments.Rows[row].Cells[1].Value.ToString();
                textBox_Comment_Content.Text = contenu; // on remplit la TEXTBOX de la valeur sauvegarder (ici l'ID)


                try
                {
                    dataGridView_Reponses.DataSource = display_Reponses_Table(Convert.ToInt32(id_comm));
                }
                catch { }

                Del_Comment.Enabled = true;
                button_Ban_Commentaire.Enabled = true;
            }

            textBox_Reponse_Content.Text = "";
            textBox_Username_Reponse.Text = "";
            Del_Reponse.Enabled = false;
            button_Ban_Reponse.Enabled = false;
        }

        public DataTable display_Reponses_Table(int id_comm) // Fonction pour charger la table SQL "categorie" 
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_rep = new MySqlDataAdapter(); // créé un objet pour remplir    
            DataTable table_rep = new DataTable(); // créé un objet de table de données

            cmd.Parameters.AddWithValue("@id_comm", id_comm);      

            cmd.CommandText = "SELECT rtc.id, rtc.contenu, rtc.date_create, user.username AS username, user.id AS uid FROM reply_topic_comment AS rtc " +
                "LEFT JOIN user ON rtc.id_user = user.id " +
                "WHERE rtc.id_topic_comment = @id_comm";

            mydtadp_rep.SelectCommand = cmd;
            mydtadp_rep.Fill(table_rep); // rempli cette table par les données récupéré par la commande SQL            

            return table_rep; // retourne le tableau
        }

        private void dataGridView_Reponses_MouseUp(object sender, MouseEventArgs e)
        {
            if (dataGridView_Reponses.CurrentCell != null)
            {
                int row = dataGridView_Reponses.CurrentCell.RowIndex; // attribue a une variable la valeur de la ligne sur laquelle on a cliqué 

                string contenu = dataGridView_Reponses.Rows[row].Cells[1].Value.ToString(); // sauvegarde le message de la cellule pointé

                textBox_Username_Reponse.Text = dataGridView_Reponses.Rows[row].Cells[3].Value.ToString();
                textBox_Reponse_Content.Text = contenu; // on remplit la TEXTBOX de le contenu de la réponse séléctionné du commentaire
            }
        }

        private void Del_Reponse_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id_reponse", dataGridView_Reponses.Rows[dataGridView_Reponses.CurrentCell.RowIndex].Cells[0].Value.ToString());

            command.CommandText = "DELETE FROM reply_topic_comment WHERE id = @id_reponse";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Suppression effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression!");
            }

            conn.Close();

            dataGridView_Reponses.DataSource = display_Reponses_Table(Convert.ToInt32(dataGridView_Comments.Rows[dataGridView_Comments.CurrentCell.RowIndex].Cells[0].Value.ToString()));
        }

        private void Del_Comment_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id_comment", dataGridView_Comments.Rows[dataGridView_Comments.CurrentCell.RowIndex].Cells[0].Value.ToString());

            command.CommandText = "DELETE FROM reply_topic_comment WHERE id_topic_comment = @id_comment";
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM topic_comment WHERE id_topic_comment = @id_comment";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Suppression effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression!");
            }

            conn.Close();

            dataGridView_Comments.DataSource = display_Comments_Table(Globals.id_topic);
        }   

        private void button_Ban_Commentaire_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id_comm", dataGridView_Comments.Rows[dataGridView_Comments.CurrentCell.RowIndex].Cells[0].Value.ToString());

            command.CommandText = "UPDATE user SET status = 'banned' WHERE id = (SELECT id_user FROM topic_comment WHERE id_topic_comment = @id_comm)";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("L'utilisateur " + dataGridView_Comments.Rows[dataGridView_Comments.CurrentCell.RowIndex].Cells[1].Value.ToString() + " a été banni.");
            }
            else
            {   
                MessageBox.Show("Une erreur s'est produit !");
            }

            conn.Close();
        }

        private void button_Ban_Reponse_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id_comm", dataGridView_Reponses.Rows[dataGridView_Reponses.CurrentCell.RowIndex].Cells[0].Value.ToString());

            command.CommandText = "UPDATE user SET status = 'banned' WHERE id = (SELECT id_user FROM reply_topic_comment WHERE id = @id_comm)";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("L'utilisateur " + dataGridView_Reponses.Rows[dataGridView_Reponses.CurrentCell.RowIndex].Cells[3].Value.ToString() + " a été banni.");
            }
            else
            {
                MessageBox.Show("Une erreur s'est produit !");
            }

            conn.Close();
        }

        private void enable_button(object sender, EventArgs e)
        {
            Del_Reponse.Enabled = true;
            button_Ban_Reponse.Enabled = true;
        }
    }

}
