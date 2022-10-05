using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBViewer
{
    public partial class OpenConnectionPrompt : Form
    {
        public string ServerName { get; set; }
        public string DBName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }

        public void ClearInfo()
        {
            this.ServerName = String.Empty;
            this.DBName = String.Empty;
            this.UserID = String.Empty;
            this.Password = String.Empty;
        }

        public OpenConnectionPrompt()
        {
            InitializeComponent();

            this.ServerName = ServerName;
            this.DBName = DBName;
            this.UserID = UserID;
            this.Password = Password;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event fired when user clicks the "Add Connection" button
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>

        private void AddConnection_Button_Click(object sender, EventArgs e)
        {
            if (ServerAddress_ComboBox.Text.Length > 0
                && DatabaseName_ComboBox.Text.Length > 0
                && UserID_TextBox.Text.Length > 0
                && Password_TextBox.Text.Length > 0)
            {
                this.ServerName = ServerAddress_ComboBox.Text;
                this.DBName = DatabaseName_ComboBox.Text;
                this.UserID = UserID_TextBox.Text;
                this.Password = Password_TextBox.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }        
        }
    }
}
