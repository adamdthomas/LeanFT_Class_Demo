using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HP.LFT.SDK.Web;

namespace LeanFT_Geico2.Pages
{
    public class LoginPage
    {
        IBrowser browser;
        BankOR bankOR;
        public LoginPage(IBrowser browser)
        {
            this.browser = browser;
            bankOR = new BankOR(this.browser);
        }
        public bool ValidLogin(string userName, string password)
        {
            bankOR.AbcBankDemoPage.UserUsernameEditField.SetValue(userName);
            bankOR.AbcBankDemoPage.UserPasswordEditField.SetValue(password);
            bankOR.AbcBankDemoPage.LoginButton.Click();
            return bankOR.AbcBankDemoPage.LogoutButton.Exists(5);
        }
        public bool ValidLogin()
        {
            bankOR.AbcBankDemoPage.UserUsernameEditField.SetValue("Adam");
            bankOR.AbcBankDemoPage.UserPasswordEditField.SetValue("ValidPassword");
            bankOR.AbcBankDemoPage.LoginButton.Click();
            return bankOR.AbcBankDemoPage.LogoutButton.Exists(5);
        }
    }
}
