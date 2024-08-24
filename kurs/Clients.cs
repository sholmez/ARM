using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            new Order().Show();
            Hide();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            new Items().Show();
            Hide();
        }

        private void CategotyButton_Click(object sender, EventArgs e)
        {
            new Category().Show();
            Hide();
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (!Authorization.isAdmin)
            {
                ItemButton.Visible = false;
                CategotyButton.Visible = false;
            }
            ShowTable();
        }

        private void ShowTable()
        {
            Utils.Select(dataGridView1, "Client", new List<string>
            {
                "Client_id AS ID",
                "Lastname AS Прізвище",
                "Firstname AS Імя",
                "Phone AS Телефон",
            });
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Utils.Insert("Client", new Dictionary<string, object>
            {
                { "Lastname" , NameTextBox.Text},
                { "Firstname" , SurnameTextBox.Text},
                { "Phone" , PhoneTextBox.Text}
            });
            ShowTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> setValues = new Dictionary<string, object>
            {
                { "Lastname", SurnameTextBox.Text },
                { "Firstname", NameTextBox.Text },
                { "Phone", PhoneTextBox.Text }
            };

            if (string.IsNullOrEmpty(NameTextBox.Text))
                setValues.Remove("Firstname");
            if (string.IsNullOrEmpty(SurnameTextBox.Text))
                setValues.Remove("Lastname");
            if (string.IsNullOrEmpty(PhoneTextBox.Text))
                setValues.Remove("Phone");

            Utils.Update("Client", setValues, new Dictionary<string, object>
            {
                { "Client_id", IDtextBox.Text }
            });

            Utils.Select(dataGridView1, "Client");
            ShowTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Utils.Delete("Client", new Dictionary<string, object>
            {
                { "Client_id", IDtextBox.Text }
            });
            ShowTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                SurnameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                PhoneTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception) { }
        }

        private void report_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcel(dataGridView1);
        }
    }
}
