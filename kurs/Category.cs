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
    public partial class Category : Form
    {
        public Category()
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

        private void ClientButton_Click(object sender, EventArgs e)
        {
            new Clients().Show();
            Hide();
        }
        private void Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ShowTable();
        }

        private void ShowTable()
        {
            Utils.Select(dataGridView1, "Category", new List<string>
            {
                "Category_id AS ID",
                "NameCategory AS \'Назва категорії\'",
                "DescriptionCategory AS Опис"
            });

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DescriptionTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception) { }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Utils.Insert("Category", new Dictionary<string, object>
            {
                { "NameCategory", NameTextBox.Text },
                { "DescriptionCategory", DescriptionTextBox.Text }
            });
            ShowTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Utils.Delete("Category", new Dictionary<string, object>
            {
                { "Category_id", IDtextBox.Text }
            });
            ShowTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Utils.Update("Category", new Dictionary<string, object>
            {
                { "NameCategory", NameTextBox.Text },
                { "DescriptionCategory", DescriptionTextBox.Text },
            }, new Dictionary<string, object>
            {
                { "Category_id", IDtextBox.Text }
            });
            ShowTable();
        }

        private void report_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcel(dataGridView1);
        }
    }
}
