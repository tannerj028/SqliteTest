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
    public partial class winEditAccount : Form
    {
        private readonly SQLiteConnection connection;
        private int accountid;
        public winEditAccount(int accountId)
        {
            InitializeComponent();
            SQLiteConnectionString connectionString = new SQLiteConnectionString(@".\db.db");
            connection = new SQLiteConnection(connectionString);
            connection.CreateTable<Account>(CreateFlags.AllImplicit);

            var account = connection.Find<Account>(accountId);
            this.accountid = accountId;
            txtEmail.Text = account.Email;
            txtPassword.Text = account.Password;
            txtPlatform.Text = account.Platform;
        }


        private void winEditAccount_Load(object sender, EventArgs e)
        {

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
                Platform = txtPlatform.Text,
                AccountId = this.accountid
            };
            
            connection.Update(newAccount);
            MessageBox.Show(" account updated");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
