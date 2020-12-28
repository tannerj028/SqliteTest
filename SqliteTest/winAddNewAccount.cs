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
    public partial class winAddNewAccount : Form
    {
        private readonly SQLiteConnection connection;
        public winAddNewAccount()
        {
            InitializeComponent();
            SQLiteConnectionString connectionString = new SQLiteConnectionString(@".\db.db");
            connection = new SQLiteConnection(connectionString);
            connection.CreateTable<Account>(CreateFlags.AllImplicit);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Platform = txtPlatform.Text
            };
            connection.Insert(newAccount);
            MessageBox.Show("New account added");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtPlatform_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
