using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using HP.LFT.SDK.Web;
using HP.LFT.Report;
using LeanFT_Geico2.Pages;

namespace LeanFT_Geico2
{
    [TestFixture]
    public class LeanFtTest : UnitTestClassBase
    {


        IBrowser browser;
        //BankOR bankOR;
        LoginPage loginPage;
        static string[] names = new string[] { "bob", "frank", "sue" };

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture
           
        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
            browser = BrowserFactory.Launch(BrowserType.Firefox);
            browser.ClearCache();
            browser.Navigate(@"http://abcbank.orasi.com");

            loginPage = new LoginPage(browser);

            //bankOR = new BankOR(browser);
        }

        [Test]
        [TestCaseSource(nameof(names))]
        public void ValidLogin(string userName)
        {

            
            //bankOR.AbcBankDemoPage.UserUsernameEditField.SetValue(userName);
            //bankOR.AbcBankDemoPage.UserPasswordEditField.SetValue("Anypassword");
            //bankOR.AbcBankDemoPage.LoginButton.Click();

            bool loginSuccess = loginPage.ValidLogin(userName, "pass1");
          

            if (loginSuccess)
            {
                Reporter.ReportEvent("Login", "Tests valid login with username: " + userName, Status.Passed);
                Assert.IsTrue(true);
            }
            else
            {
                Reporter.ReportEvent("Login", "Tests valid login with username: " + userName, Status.Failed);
                Assert.IsTrue(false);
            }


            //IEditField GoogleSearchBar = browser.Describe<IEditField>(new EditFieldDescription
            //  {
            //      Type = @"text",
            //      TagName = @"INPUT",
            //      Name = @"q"
            //  });


            //  GoogleSearchBar.SetValue("Geico");
        }

        //[Test]
        //public void NegativeLogin()
        //{

        //    string userName = "Adam";
        //    //bankOR.AbcBankDemoPage.UserUsernameEditField.SetValue(userName);
        //    //bankOR.AbcBankDemoPage.UserPasswordEditField.SetValue("Anypassword");
        //    //bankOR.AbcBankDemoPage.LoginButton.Click();
        //    bool loginSuccess = loginPage.ValidLogin(userName, "INValidPassword");

        //    if (loginSuccess)
        //    {
        //        Reporter.ReportEvent("Login", "Tests valid login with username: " + userName, Status.Failed);
        //        Assert.IsTrue(false);
        //    }
        //    else
        //    {
        //        Reporter.ReportEvent("Login", "Tests valid login with username: " + userName, Status.Passed);
        //        Assert.IsTrue(true);
        //    }
        //}

        //[Test]
        //public void CheckMainTable()
        //{
        //    bool loginSuccess = loginPage.ValidLogin();
        //    //Check main table
        //}
        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            browser.CloseAllTabs();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
