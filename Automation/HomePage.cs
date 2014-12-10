﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    class HomePage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://telluswho2.herokuapp.com/");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        public class LoginCommand
        {
            private readonly string userName;
            private string password;

            public LoginCommand(string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Login()
            {
                var loginInput = Driver.Instance.FindElement(By.Id("user_login"));
                loginInput.SendKeys(userName);

                var passwordInput = Driver.Instance.FindElement(By.Id("user_pass"));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.Id("wp-submit"));
                loginButton.Click();
            }
        }
    }
}
