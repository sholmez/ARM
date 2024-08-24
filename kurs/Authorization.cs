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
using System.Security.Cryptography;

namespace kurs
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        static public bool isAdmin = false;
        private void loginButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> loginPasswords = GetUserLoginsAndPasswordsAndPrivileges(Utils.ConnectionString).Item1;
            List<string> privileges = GetUserLoginsAndPasswordsAndPrivileges(Utils.ConnectionString).Item2;

            string login = loginTextBox.Text,
                   password = passwordTextBox.Text;

            bool isCorrectLogPass = false;

            int i = 0;
            foreach (KeyValuePair<string, string> entry in loginPasswords)
            {
                if (entry.Key == login && entry.Value == password)
                {
                    if (privileges[i].Replace(" ", "") == "Admin")
                        isAdmin = true;
                    isCorrectLogPass = true;
                    break;
                }
                i++;
            }

            if (isCorrectLogPass)
            {
                new MainForm().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неправильний логін чи пароль.", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static (Dictionary<string, string>, List<string>) GetUserLoginsAndPasswordsAndPrivileges(string connectionString)
        {
            (Dictionary<string, string>, List<string>) result;
            result.Item1 = new Dictionary<string, string>();
            result.Item2 = new List<string>();

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT Login, Password, Privilege FROM Users", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string login = reader.GetString(0);
                    string password = reader.GetString(1);
                    string privilege = reader.GetString(1);
                    result.Item1.Add(login, password);
                    result.Item2.Add(privilege);
                }
            }

            return result;
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}