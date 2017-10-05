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
            Console.WriteLine("Back to google!");
            browser.LoadUrl("http://www.google.de");
            Console.WriteLine("Aaaand back to Kingdoms!");
            browser.LoadUrl("http://www.kingdoms.com");
            Console.WriteLine("click play now");
            browser.clickElement(By.Id("loginButton"));
            Console.WriteLine("did he ? ");


        }

        public void Login(String username, String password)
        {
            browser.clickElement(By.Id("loginButton"));
            browser.waitForElement(3,By.Name("email"));
        }

    }
}
