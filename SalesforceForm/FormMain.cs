using SalesforceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesforceForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            try
            {
                await Salesforce.Login(
                    textBoxClientID.Text,
                    textBoxClientSecret.Text,
                    textBoxUserName.Text,
                    textBoxPassword.Text,
                    textBoxSecurityToken.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Failed: {ex.Message}");
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            listBoxContacts.Items.Clear();

            string strPhoneNumber = textBoxPhoneNumber.Text;
            try
            {
                List<Contact> contacts = await Salesforce.SearchContacts(strPhoneNumber);
                if (contacts.Count == 0)
                {
                    MessageBox.Show("No contacts found");
                    return;
                }
                listBoxContacts.Items.AddRange(contacts.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search Contacts Failed: {ex.Message}");
            }
        }
    }
}
