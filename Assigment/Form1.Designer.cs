namespace Assigment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlAccountOperations = new Panel();
            lblAmount = new Label();
            btnWithdraw = new Button();
            txtAmount = new TextBox();
            lblBalance = new Label();
            btnDeposit = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            pnlAccountOperations.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAccountOperations
            // 
            pnlAccountOperations.Controls.Add(lblAmount);
            pnlAccountOperations.Controls.Add(btnWithdraw);
            pnlAccountOperations.Controls.Add(txtAmount);
            pnlAccountOperations.Controls.Add(lblBalance);
            pnlAccountOperations.Controls.Add(btnDeposit);
            pnlAccountOperations.Location = new Point(182, 406);
            pnlAccountOperations.Name = "pnlAccountOperations";
            pnlAccountOperations.Size = new Size(911, 309);
            pnlAccountOperations.TabIndex = 0;
            pnlAccountOperations.Visible = false;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(46, 198);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 25);
            lblAmount.TabIndex = 6;
            lblAmount.Text = "Amount";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(692, 121);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(112, 34);
            btnWithdraw.TabIndex = 9;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click_1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(153, 198);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(278, 31);
            txtAmount.TabIndex = 7;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(222, 66);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(71, 25);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "Balance";
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(521, 121);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(112, 34);
            btnDeposit.TabIndex = 8;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(400, 113);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(278, 31);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(400, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 31);
            txtPassword.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(218, 113);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(99, 25);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(218, 174);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(901, 140);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 862);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(pnlAccountOperations);
            Name = "Form1";
            Text = "Main";
            Load += Form1_Load;
            pnlAccountOperations.ResumeLayout(false);
            pnlAccountOperations.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlAccountOperations;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblBalance;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnLogin;
    }
}
