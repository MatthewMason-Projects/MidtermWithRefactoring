namespace ATMApp.Forms
{
    partial class MainMenuForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.checkBalanceButton = new System.Windows.Forms.Button();
            this.withdrawCheckingButton = new System.Windows.Forms.Button();
            this.withdrawSavingsButton = new System.Windows.Forms.Button();
            this.transferToSavingsButton = new System.Windows.Forms.Button();
            this.transferToCheckingButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(46, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(65, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome\r\n";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(276, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 1;
            // 
            // checkBalanceButton
            // 
            this.checkBalanceButton.Location = new System.Drawing.Point(135, 74);
            this.checkBalanceButton.Name = "checkBalanceButton";
            this.checkBalanceButton.Size = new System.Drawing.Size(168, 32);
            this.checkBalanceButton.TabIndex = 2;
            this.checkBalanceButton.Text = "Check Balance";
            this.checkBalanceButton.UseVisualStyleBackColor = true;
            this.checkBalanceButton.Click += new System.EventHandler(this.checkBalanceButton_Click_1);
            // 
            // withdrawCheckingButton
            // 
            this.withdrawCheckingButton.Location = new System.Drawing.Point(135, 112);
            this.withdrawCheckingButton.Name = "withdrawCheckingButton";
            this.withdrawCheckingButton.Size = new System.Drawing.Size(168, 32);
            this.withdrawCheckingButton.TabIndex = 3;
            this.withdrawCheckingButton.Text = "Withdraw from Checking";
            this.withdrawCheckingButton.UseVisualStyleBackColor = true;
            this.withdrawCheckingButton.Click += new System.EventHandler(this.withdrawCheckingButton_Click);
            // 
            // withdrawSavingsButton
            // 
            this.withdrawSavingsButton.Location = new System.Drawing.Point(135, 150);
            this.withdrawSavingsButton.Name = "withdrawSavingsButton";
            this.withdrawSavingsButton.Size = new System.Drawing.Size(168, 32);
            this.withdrawSavingsButton.TabIndex = 4;
            this.withdrawSavingsButton.Text = "Withdraw from Savings";
            this.withdrawSavingsButton.UseVisualStyleBackColor = true;
            this.withdrawSavingsButton.Click += new System.EventHandler(this.withdrawSavingsButton_Click);
            // 
            // transferToSavingsButton
            // 
            this.transferToSavingsButton.Location = new System.Drawing.Point(135, 188);
            this.transferToSavingsButton.Name = "transferToSavingsButton";
            this.transferToSavingsButton.Size = new System.Drawing.Size(168, 32);
            this.transferToSavingsButton.TabIndex = 5;
            this.transferToSavingsButton.Text = "Transfer to Savings";
            this.transferToSavingsButton.UseVisualStyleBackColor = true;
            this.transferToSavingsButton.Click += new System.EventHandler(this.transferToSavingsButton_Click);
            // 
            // transferToCheckingButton
            // 
            this.transferToCheckingButton.Location = new System.Drawing.Point(135, 226);
            this.transferToCheckingButton.Name = "transferToCheckingButton";
            this.transferToCheckingButton.Size = new System.Drawing.Size(168, 32);
            this.transferToCheckingButton.TabIndex = 6;
            this.transferToCheckingButton.Text = "Transfer to Checking";
            this.transferToCheckingButton.UseVisualStyleBackColor = true;
            this.transferToCheckingButton.Click += new System.EventHandler(this.transferToCheckingButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(135, 264);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(168, 32);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(331, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(331, 156);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(331, 194);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown3.TabIndex = 10;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(331, 232);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(503, 382);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.transferToCheckingButton);
            this.Controls.Add(this.transferToSavingsButton);
            this.Controls.Add(this.withdrawSavingsButton);
            this.Controls.Add(this.withdrawCheckingButton);
            this.Controls.Add(this.checkBalanceButton);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button checkBalanceButton;
        private System.Windows.Forms.Button withdrawCheckingButton;
        private System.Windows.Forms.Button withdrawSavingsButton;
        private System.Windows.Forms.Button transferToSavingsButton;
        private System.Windows.Forms.Button transferToCheckingButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}