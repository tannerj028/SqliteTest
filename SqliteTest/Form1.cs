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
    public partial class Form1 : Form
    {
        private readonly SQLiteConnection connection;
        public Form1()
        {
            InitializeComponent();
            SQLiteConnectionString connectionString = new SQLiteConnectionString(@".\db.db");
            connection = new SQLiteConnection(connectionString);
            connection.CreateTable<Account>(CreateFlags.AllImplicit);
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
          var addForm =  new winAddNewAccount();
            if(addForm.ShowDialog() == DialogResult.OK)
            {
                dgAccounts.DataSource = connection.Table<Account>().ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgAccounts.DataSource = connection.Table<Account>().ToList();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dgAccounts.SelectedRows == null)
            {
                MessageBox.Show("U haven't selected anyone from the list yet");
                return;

            }

            if (MessageBox.Show("U sure u want to delete the selected record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int accountId = int.Parse(dgAccounts.CurrentRow.Cells[0].Value.ToString());
                connection.Delete<Account>(accountId);
                MessageBox.Show("Deleted!");
                dgAccounts.DataSource = connection.Table<Account>().ToList();
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            int accountId = int.Parse(dgAccounts.CurrentRow.Cells[0].Value.ToString());
            var editForm = new winEditAccount(accountId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                dgAccounts.DataSource = connection.Table<Account>().ToList();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
