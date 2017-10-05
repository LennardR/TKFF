using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            Login("andrasmumm99@yahoo.de", "aachenbremen123");
        }

        public void Login(String username, String password)
        {
            browser.clickElement(By.Id("loginButton"));
            browser.WaitUntilElementIsPresent(By.Name("email"),5);
        }

    }
}
