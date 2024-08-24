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
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void ClientButton_Click(object sender, EventArgs e)
        {
            new Clients().Show();
            Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
            Hide();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Authorization.isAdmin)
            {
                ItemButton.Visible = false;
                CategotyButton.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
