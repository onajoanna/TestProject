using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    class HomePage: DriverHelper
    {
        IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));

        IWebElement lnkLogoff => driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogoff.Displayed;
    }
}
