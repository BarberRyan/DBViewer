namespace DBViewer
{
    partial class OpenConnectionPrompt
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
            this.AddConnection_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ServerAddress_ComboBox = new System.Windows.Forms.ComboBox();
            this.DatabaseName_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserID_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddConnection_Button
            // 
            this.AddConnection_Button.Location = new System.Drawing.Point(19, 183);
            this.AddConnection_Button.Name = "AddConnection_Button";
            this.AddConnection_Button.Size = new System.Drawing.Size(100, 23);
            this.AddConnection_Button.TabIndex = 2;
            this.AddConnection_Button.Text = "Open Connection";
            this.AddConnection_Button.UseVisualStyleBackColor = true;
            this.AddConnection_Button.Click += new System.EventHandler(this.AddConnection_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(174, 183);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ServerAddress_ComboBox
            // 
            this.ServerAddress_ComboBox.FormattingEnabled = true;
            this.ServerAddress_ComboBox.Location = new System.Drawing.Point(131, 26);
            this.ServerAddress_ComboBox.Name = "ServerAddress_ComboBox";
            this.ServerAddress_ComboBox.Size = new System.Drawing.Size(210, 21);
            this.ServerAddress_ComboBox.TabIndex = 4;
            this.ServerAddress_ComboBox.Text = "RYAN-PC\\SQLEXPRESS";
            // 
            // DatabaseName_ComboBox
            // 
            this.DatabaseName_ComboBox.FormattingEnabled = true;
            this.DatabaseName_ComboBox.Location = new System.Drawing.Point(131, 59);
            this.DatabaseName_ComboBox.Name = "DatabaseName_ComboBox";
            this.DatabaseName_ComboBox.Size = new System.Drawing.Size(210, 21);
            this.DatabaseName_ComboBox.TabIndex = 5;
            this.DatabaseName_ComboBox.Text = "Northwind";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Database Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "User ID:";
            // 
            // UserID_TextBox
            // 
            this.UserID_TextBox.Location = new System.Drawing.Point(131, 102);
            this.UserID_TextBox.Name = "UserID_TextBox";
            this.UserID_TextBox.Size = new System.Drawing.Size(210, 20);
            this.UserID_TextBox.TabIndex = 10;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(131, 135);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '●';
            this.Password_TextBox.Size = new System.Drawing.Size(210, 20);
            this.Password_TextBox.TabIndex = 11;
            // 
            // OpenConnectionPrompt
            // 
            this.AcceptButton = this.AddConnection_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 220);
            this.ControlBox = false;
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.UserID_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabaseName_ComboBox);
            this.Controls.Add(this.ServerAddress_ComboBox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.AddConnection_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OpenConnectionPrompt";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Connection";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddConnection_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.ComboBox ServerAddress_ComboBox;
        private System.Windows.Forms.ComboBox DatabaseName_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserID_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
    }
}