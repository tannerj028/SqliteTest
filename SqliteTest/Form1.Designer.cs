
namespace SqliteTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateNewAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNewAccount
            // 
            this.btnCreateNewAccount.Location = new System.Drawing.Point(359, 34);
            this.btnCreateNewAccount.Name = "btnCreateNewAccount";
            this.btnCreateNewAccount.Size = new System.Drawing.Size(91, 43);
            this.btnCreateNewAccount.TabIndex = 0;
            this.btnCreateNewAccount.Text = "Create a new account";
            this.btnCreateNewAccount.UseVisualStyleBackColor = true;
            this.btnCreateNewAccount.Click += new System.EventHandler(this.btnCreateNewAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(358, 104);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(91, 43);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "Edit account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(358, 165);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(91, 43);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "Delete acount";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // dgAccounts
            // 
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Location = new System.Drawing.Point(28, 34);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.Size = new System.Drawing.Size(325, 174);
            this.dgAccounts.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 246);
            this.Controls.Add(this.dgAccounts);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.btnCreateNewAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.DataGridView dgAccounts;
    }
}

