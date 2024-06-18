using Assigment.BusinessLayer;

namespace Assigment
{
    public partial class Form1 : Form
    {
        private UserManager userManager = new UserManager();
        private BankAccount bankAccount = new BankAccount();
        public Form1()
        {
            InitializeComponent();
            userManager.SuccessfulLogin += UserManager_SuccessfulLogin;
            userManager.UnsuccessfulLogin += UserManager_UnsuccessfulLogin;
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userManager.AuthenticateUser(txtUserName.Text, txtPassword.Text);
        }

        private void UserManager_SuccessfulLogin(object sender, EventArgs e)
        {
            MessageBox.Show("Login successful!");
            pnlAccountOperations.Visible = true;

            
            bankAccount = userManager.LoggedInUserAccount;
            bankAccount.BalanceChanged += BankAccount_BalanceChanged;

            
            lblBalance.Text = $"Balance: {bankAccount.Balance:C}";
        }

        private void UserManager_UnsuccessfulLogin(object sender, EventArgs e)
        {
            MessageBox.Show("Login failed. Please check your username and password.");
        }

        private void BankAccount_BalanceChanged(object sender, EventArgs e)
        {
            lblBalance.Text = $"Balance: {bankAccount.Balance:C}";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                bankAccount.Deposit(amount);
                txtAmount.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }


        private void btnWithdraw_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                try
                {
                    bankAccount.Withdraw(amount);
                    txtAmount.Clear();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }
    }
}
