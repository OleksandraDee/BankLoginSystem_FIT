using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.BusinessLayer
{
    public class UserManager
    {
        /// <summary>
        /// Mock data for the login detailes
        /// </summary>
        private readonly Dictionary<string, string> users = new()
        {
            { "Tom", "1234" },
            { "Alice", "password" }
        };

        /// <summary>
        /// Mock data for the balance detailes
        /// </summary>
        private readonly Dictionary<string, BankAccount> userAccounts = new()
    {
        { "Tom", new BankAccount(500) }, // Tom starts with a balance of 500
        { "Alice", new BankAccount(300) } // Alice starts with a balance of 300
    };


        /// <summary>
        /// Initializing event handelling for login event
        /// </summary>
        public event EventHandler SuccessfulLogin;
        public event EventHandler UnsuccessfulLogin;

        public BankAccount LoggedInUserAccount { get; private set; }  // Define the property

        /// <summary>
        /// Checks if the login detailes are valid
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void AuthenticateUser(string userName, string password)
        {
            if (users.TryGetValue(userName, out string correctPassword) && correctPassword == password)
            {
                LoggedInUserAccount = userAccounts[userName];
                OnSuccessfulLogin();
            }
            else
            {
                LoggedInUserAccount = null;
                OnUnsuccessfulLogin();
            }
        }

        /// <summary>
        /// Involke event on successfyl login
        /// </summary>
        protected virtual void OnSuccessfulLogin()
        {
            SuccessfulLogin?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Invoke even on unsuccessful login
        /// </summary>
        protected virtual void OnUnsuccessfulLogin()
        {
            UnsuccessfulLogin?.Invoke(this, EventArgs.Empty);
        }
    }
}
