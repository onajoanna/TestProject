using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    class LoginPage : DriverHelper
    {
        IWebElement txtUserName => driver.FindElement(By.Name("UserName"));

        IWebElement txtPassword => driver.FindElement(By.Name("Password"));

        IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
