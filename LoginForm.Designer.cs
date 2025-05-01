namespace ATMApp.Forms
{
    partial class LoginForm
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
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(17, 15);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(83, 16);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "Customer ID:";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(21, 46);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(126, 22);
            this.customerIdTextBox.TabIndex = 1;
            this.customerIdTextBox.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(21, 118);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.PasswordChar = '*';
            this.pinTextBox.Size = new System.Drawing.Size(126, 22);
            this.pinTextBox.TabIndex = 2;
            this.pinTextBox.TextChanged += new System.EventHandler(this.pinTextBox_TextChanged);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(18, 87);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(32, 16);
            this.lblPin.TabIndex = 3;
            this.lblPin.Text = "PIN:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(115, 201);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(75, 178);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(88, 39);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(257, 252);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.lblCustomerId);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button loginButton;
    }
}

