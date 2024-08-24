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
    public partial class Order : Form
    {
        static private int Order_id = 0;
        public Order()
        {
            InitializeComponent();
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

        private void ClientButton_Click(object sender, EventArgs e)
        {
            new Clients().Show();
            Hide();
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            if (!Authorization.isAdmin)
            {
                ItemButton.Visible = false;
                CategotyButton.Visible = false;
            }

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            Utils.FillComboBoxFromSql(comboBox1,
                Utils.GenerateSelectQuery("Client", "Client_id, CONCAT(Client_id, \'. \', Lastname, \' \', Firstname) AS Fullname"),
                "Fullname", "Client_id");

            Utils.FillComboBoxFromSql(comboBox3,
                Utils.GenerateSelectQuery("Item", "Item_id, CONCAT(Item_id, \'. \', NameItem) AS IdName"),
                "IdName", "Item_id");

            PriceTextBox.Text = (QuanityNumeric.Value *
                Convert.ToInt32(Utils.GetFieldValueFromSql($"SELECT * FROM Item WHERE Item_id = {comboBox3.Text[0]}", "Price"))).ToString();

            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            ShowTable();

            dataGridView1.Columns["Order_id"].Visible = false;
            dataGridView1.Columns["Item_id"].Visible = false;
        }

        private void ShowTable()
        {
            Utils.Select(dataGridView1, "Position", new List<string>{
                "Position.Position_id AS ID",
                "Item.NameItem AS \'Назва товару\'",
                "Item.Price * Position.Quantity AS Вартість",
                "OrderItem.BuyDate AS \'Дата замовлення\'",
                "OrderItem.BuyStatus AS \'Статус замовлення\'",
                "Position.Quantity AS Кількість",
                "CONCAT(Client.Client_id, \'. \', Client.Lastname, \' \', Client.Firstname) AS Клієнт",
                "Client.Phone AS Телефон",
                "OrderItem.Order_id",
                "Item.Item_id"
            }, joinTables: new List<string>{
                "OrderItem",
                "Item",
                "Client"
            }, joinConditions: new Dictionary<string, string>{
                { "OrderItem", "Position.Order_id = OrderItem.Order_id" },
                { "Item", "Position.Item_id = Item.Item_id" },
                { "Client", "OrderItem.Client_id = Client.Client_id" }
            });
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Utils.Insert("OrderItem", new Dictionary<string, object>
            {
                { "BuyDate", dateTimePicker1.Value },
                { "BuyStatus", comboBox2.Text },
                { "Client_id", int.Parse(comboBox1.Text[0].ToString()) }
            });

            Utils.Insert("Position", new Dictionary<string, object>
            {
                { "Order_id", Utils.GetLastInsertedId("OrderItem") },
                { "Item_id", comboBox3.Text[0] },
                { "Quantity", QuanityNumeric.Value }
            });

            ShowTable();
        }

        private void QuanityNumeric_ValueChanged(object sender, EventArgs e)
        {
            PriceTextBox.Text = (QuanityNumeric.Value *
                Convert.ToInt32(Utils.GetFieldValueFromSql($"SELECT * FROM Item WHERE Item_id = {comboBox3.Text[0]}", "Price"))).ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Utils.Update("OrderItem", new Dictionary<string, object>
            {
                { "BuyDate", dateTimePicker1.Value },
                { "BuyStatus", comboBox2.Text },
                { "Client_id", int.Parse(comboBox1.Text[0].ToString()) }
            },
            new Dictionary<string, object>
            {
                { "Order_id", Order_id }
            });

            Utils.Update("Position", new Dictionary<string, object>
            {
                { "Order_id", Utils.GetLastInsertedId("OrderItem") },
                { "Item_id", comboBox3.Text[0] },
                { "Quantity", QuanityNumeric.Value }
            },
            new Dictionary<string, object>
            {
                { "Position_id", IDtextBox.Text }
            });

            ShowTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["Item_id"].Index].Value.ToString() +
                    ". " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                QuanityNumeric.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                PriceTextBox.Text = (QuanityNumeric.Value *
                    Convert.ToInt32(Utils.GetFieldValueFromSql($"SELECT * FROM Item WHERE Item_id = {comboBox3.Text[0]}", "Price"))).ToString();
                Order_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["Order_id"].Index].Value);
            }
            catch (Exception) { }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceTextBox.Text = (QuanityNumeric.Value *
                Convert.ToInt32(Utils.GetFieldValueFromSql($"SELECT * FROM Item WHERE Item_id = {comboBox3.Text[0]}", "Price"))).ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Utils.Delete("OrderItem", new Dictionary<string, object>
            {
                { "Order_id", Order_id }
            });
            Utils.Delete("Position", new Dictionary<string, object>
            {
                { "Position_id", IDtextBox.Text }
            });
            ShowTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcel(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
