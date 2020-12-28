using SQLite;
using SqliteTest.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteTest
{
    public partial class winLogin : Form
    {
        private readonly SQLiteConnection connection;
        public winLogin()
        {
            InitializeComponent();
            SQLiteConnectionString connectionString = new SQLiteConnectionString(@".\db.db");
            connection = new SQLiteConnection(connectionString);
            connection.CreateTable<SecretCode>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          var secretCode =  connection.Table<SecretCode>().FirstOrDefault(t => t.Password == txtSecretCode.Text);
            if (secretCode == null)
            {
                MessageBox.Show("The secretcode is wrong.");
            }
            else
            {
                new Form1().Show();
                this.Hide();
            }

        }
    }
}
