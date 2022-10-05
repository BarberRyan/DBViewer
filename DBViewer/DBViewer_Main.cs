using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBViewer
{
    public partial class DBViewer : Form
    {
        DB database;

        public SqlConnectionStringBuilder ConnSB = new SqlConnectionStringBuilder();
        public DBViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event fired when user clicks "Connect to Database" option in the menu.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void ConnectToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new OpenConnectionPrompt())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ConnSB.DataSource = form.ServerName;
                    ConnSB.InitialCatalog = form.DBName;
                    ConnSB.UserID = form.UserID;
                    ConnSB.Password = form.Password;
                    form.ClearInfo();
                    ConnSB.ConnectTimeout = 30;

                    database = new DB(ConnSB.ConnectionString);

                    if (database.TestConnection())
                    {
                        TableSelection_ComboBox.DataSource = database.GetTableList();
                        connectionStatus_Label.ForeColor = System.Drawing.Color.Green;
                        connectionStatus_Label.Text = $"Connected to {ConnSB.InitialCatalog} on {ConnSB.DataSource} as {ConnSB.UserID}";
                    }
                    else
                    {
                        MessageBox.Show("Connection to database failed. Please check connection settings and credentials and try again.", "Connection Failed");
                    }


                    ConnSB.Clear();
                }
            }
        }

        /// <summary>
        /// Event fired when user clicks "Close Connection" option in the menu.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void CloseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(database != null)
            {
                if(database.conn != null)
                {
                    database.CloseConnection();
                }
            }
            TableSelection_ComboBox.DataSource = new List<string> { };
            connectionStatus_Label.ForeColor = System.Drawing.Color.Red;
            connectionStatus_Label.Text = "Not Connected";
            TableInfo_Label.Text = "";
            QueryResult_DGV.DataSource = null;
        }

        /// <summary>
        /// Event fired when user selects a table to view
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void TableSelected(object sender, EventArgs e)
        {
            if (TableSelection_ComboBox.SelectedIndex > 0)
            {
                QueryResult_DGV.DataSource = null;
                string selection = TableSelection_ComboBox.Text;
                QueryResult_DGV.DataSource = database.GetTable(selection);
                TableInfo_Label.Text = $"Viewing {TableSelection_ComboBox.Text} table ({database.GetTableCount(selection)} records)";
            }
            else
            {
                QueryResult_DGV.DataSource = null;
                TableInfo_Label.Text = "";
            }
        }
    }
}
