using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            new Order().Show();
            Hide();
        }

        private void CategotyButton_Click(object sender, EventArgs e)
        {
            new Category().Show();
            Hide();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            new Clients().Show();
            Hide();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            Utils.FillComboBoxFromSql(
                comboBox1,
                Utils.GenerateSelectQuery("Category", "Category_id, NameCategory"),
                "NameCategory",
                "Category_id"
                );
            ShowTable();
        }

        private void ShowTable()
        {
            Utils.Select(dataGridView1, "Item", new List<string>
            {
                "Item.Item_id AS ID",
                "Item.NameItem AS \'Назва товару\'",
                "Category.NameCategory AS \'Назва категорії\'",
                "Item.Price AS Ціна",
                "Item.DescriptionItem AS Опис"
            },
            null, new List<string> { "Category" },
            new Dictionary<string, string>
            {
                { "Category", "Item.Category_id = Category.Category_id" },
            });
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Utils.Insert("Item", new Dictionary<string, object>
            {
                { "NameItem", NameTextBox.Text },
                { "DescriptionItem", NameTextBox.Text },
                { "Price", PriceTextBox.Text },
                { "Category_id", Utils.GetIdFromTable("Category", "Category_id",
                new Dictionary<string, string>
                {
                    { "NameCategory" , comboBox1.Text }
                })}
            });

            ShowTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> setValues = new Dictionary<string, object>
            {
                { "NameItem", NameTextBox.Text },
                { "Price", PriceTextBox.Text },
                { "DescriptionItem", DescriptionTextBox.Text },
                { "Category_id", Utils.GetIdFromTable("Category", "Category_id",
                new Dictionary<string, string>
                {
                    { "NameCategory", comboBox1.Text }
                }
                )}};

            if (string.IsNullOrEmpty(NameTextBox.Text))
                setValues.Remove("NameItem");
            if (string.IsNullOrEmpty(DescriptionTextBox.Text))
                setValues.Remove("DescriptionItem");
            if (string.IsNullOrEmpty(PriceTextBox.Text))
                setValues.Remove("Price");

            Utils.Update("Item", setValues, new Dictionary<string, object>
            {
                { "Item_id", IDtextBox.Text }
            });

            ShowTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Utils.Delete("Item", new Dictionary<string, object>
            {
                { "Item_id", IDtextBox.Text }
            });
            ShowTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                PriceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                DescriptionTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception) { }
        }

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void report_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcel(dataGridView1);
        }
    }
}
