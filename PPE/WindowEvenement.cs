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

    public partial class WindowEvenement : Form
    {

        private static MySqlConnection conn = new MySqlConnection("database=bdd_jeux_slam; server=localhost; port=3307; user id=root; pwd=");

        public WindowEvenement()
        {
            InitializeComponent();
            Open_Tab_Event();
        }

        public void Open_Tab_Event()
        {
            dataGridView_Event.DataSource = display_Event_Table();

            button_Add.Enabled = false;
            button_Edit.Enabled = false;
            button_Del.Enabled = false;
        }

        public DataTable display_Event_Table()
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_event = new MySqlDataAdapter();
            DataTable table_event = new DataTable();

            cmd.CommandText = "SELECT * FROM event";
            mydtadp_event.SelectCommand = cmd;

            mydtadp_event.Fill(table_event);

            return table_event;
        }

        private void dataGridView_Event_MouseUp(object sender, MouseEventArgs e)
        {
            int row = dataGridView_Event.CurrentCell.RowIndex;

            for (int i = 0; i < 5; i++)
            {
                string val = dataGridView_Event.Rows[row].Cells[i].Value.ToString();
                switch (i)
                {
                    case 0:
                        textBox_ID_event.Text = val;
                        break;
                    case 1:
                        textBox_Name_event.Text = val;
                        break;
                    case 2:
                        dateTimePicker_event.Text = val;
                        break;
                    case 3:
                        textBox_Site_event.Text = val;
                        break;
                    case 4:
                        textBox_Img_event.Text = val;
                        break;
                }
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@name", textBox_Name_event.Text);
            command.Parameters.AddWithValue("@date", dateTimePicker_event.Text);
            command.Parameters.AddWithValue("@site", textBox_Site_event.Text);
            command.Parameters.AddWithValue("@images", textBox_Img_event.Text);

            command.CommandText = "INSERT INTO event (name, date, site, images) VALUES (@name, @date, @site, @images) ";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Insertion effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de l’insertion!");
            }

            conn.Close();

            dataGridView_Event.DataSource = display_Event_Table();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir modifier l'événement " + textBox_ID_event.Text + " ?", "Modification de l'événement", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@name", textBox_Name_event.Text);
                command.Parameters.AddWithValue("@date", dateTimePicker_event.Text);
                command.Parameters.AddWithValue("@site", textBox_Site_event.Text);
                command.Parameters.AddWithValue("@images", textBox_Img_event.Text);
                command.Parameters.AddWithValue("@id", textBox_ID_event.Text);

                command.CommandText = "UPDATE event SET name = @name , date = @date , site = @site , images = @images WHERE id = @id";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Modification effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification!");
                }

                conn.Close();

                dataGridView_Event.DataSource = display_Event_Table();
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer l'événement " + textBox_ID_event.Text + " ?", "Suppression de l'événement", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", textBox_ID_event.Text);

                command.CommandText = "DELETE FROM event WHERE id = @id";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Suppression effectuée!");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression!");
                }

                conn.Close();

                dataGridView_Event.DataSource = display_Event_Table();
            }
        }

        private void button_clear_ID_Click(object sender, EventArgs e)
        {
            textBox_ID_event.ResetText();
        }

        private void button_clear_name_Click(object sender, EventArgs e)
        {
            textBox_Name_event.ResetText();
        }

        private void button_clear_site_Click(object sender, EventArgs e)
        {
            textBox_Site_event.ResetText();
        }

        private void button_clear_image_Click(object sender, EventArgs e)
        {
            textBox_Img_event.ResetText();
        }

        private void button_clear_date_Click(object sender, EventArgs e)
        {
            dateTimePicker_event.Value = DateTime.Today.AddDays(0);
        }

        private void enable_Button(object sender, EventArgs e)
        {
            if (textBox_ID_event.TextLength != 0)
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

            if (textBox_Name_event.TextLength == 0  || textBox_Img_event.TextLength == 0)
            {
                button_Add.Enabled = false;
                button_Edit.Enabled = false;
            }
        }
    }
}
