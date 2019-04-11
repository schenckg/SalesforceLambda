namespace SalesforceForm
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecurityToken = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxClientSecret = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.textBoxSecurityToken);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxClientSecret);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxClientID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salesforce Login:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxPhoneNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(583, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Contacts by Phone Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxContacts);
            this.groupBox3.Location = new System.Drawing.Point(583, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Secret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Security Token:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(126, 149);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone Number:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(290, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.Location = new System.Drawing.Point(3, 16);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(377, 99);
            this.listBoxContacts.TabIndex = 0;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SalesforceForm.Properties.Settings.Default, "PhoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(104, 19);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(167, 20);
            this.textBoxPhoneNumber.TabIndex = 1;
            this.textBoxPhoneNumber.Text = global::SalesforceForm.Properties.Settings.Default.PhoneNumber;
            // 
            // textBoxSecurityToken
            // 
            this.textBoxSecurityToken.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SalesforceForm.Properties.Settings.Default, "SecurityToken", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSecurityToken.Location = new System.Drawing.Point(126, 123);
            this.textBoxSecurityToken.Name = "textBoxSecurityToken";
            this.textBoxSecurityToken.PasswordChar = '*';
            this.textBoxSecurityToken.Size = new System.Drawing.Size(414, 20);
            this.textBoxSecurityToken.TabIndex = 1;
            this.textBoxSecurityToken.Text = global::SalesforceForm.Properties.Settings.Default.SecurityToken;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SalesforceForm.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPassword.Location = new System.Drawing.Point(126, 97);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(414, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = global::SalesforceForm.Properties.Settings.Default.Password;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SalesforceForm.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUserName.Location = new System.Drawing.Point(126, 71);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(414, 20);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Text = global::SalesforceForm.Properties.Settings.Default.UserName;
            // 
            // textBoxClientSecret
            // 
            this.textBoxClientSecret.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SalesforceForm.Properties.Settings.Default, "ClientSecret", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxClientSecret.Location = new System.Drawing.Point(126, 45);
            this.textBoxClientSecret.Name = "textBoxClientSecret";
            this.textBoxClientSecret.Size = new System.Drawing.Size(414, 20);
            this.textBoxClientSecret.TabIndex = 1;
            this.textBoxClientSecret.Text = global::SalesforceForm.Properties.Settings.Default.ClientSecret;
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SalesforceForm.Properties.Settings.Default, "ClientID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxClientID.Location = new System.Drawing.Point(126, 19);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(414, 20);
            this.textBoxClientID.TabIndex = 1;
            this.textBoxClientID.Text = global::SalesforceForm.Properties.Settings.Default.ClientID;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 212);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxSecurityToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientSecret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxContacts;
    }
}

