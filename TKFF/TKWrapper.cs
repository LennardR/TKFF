﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TKFF
{
    class TKWrapper
    {
        ChromeWrapper browser = null;
        public TKWrapper() {
        Console.WriteLine("Hi!");
        browser = new ChromeWrapper();
            Console.WriteLine("Going to Kingdoms!");
            browser.LoadUrl("http://www.kingdoms.com");
            Console.WriteLine("Kingdoms Website loaded!");
            Login("xx","xx");
        }

        public void Login(String emailadresse, String password)
        {
            browser.clickElement(By.Id("loginButton"));
            if (browser.WaitUntilElementIsPresent(By.Name("submit"), 5) == false){ 
            browser.typeTextBox(By.Name("email"), emailadresse);
            }else{
                Console.Write("Login not possible! Login form not found!");
            }
        }

    }
}
