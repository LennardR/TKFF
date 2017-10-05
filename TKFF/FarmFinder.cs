using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TKFF
{
    class FarmFinder
    {
        ChromeWrapper browser = null;
        public FarmFinder()
        {
            Console.WriteLine("Hi!");
            browser = new ChromeWrapper();
            Console.WriteLine("Going to FarmFinder!");
            browser.LoadUrl("https://travian.engin9tools.com/farm-finder");
            x By.Id("md_input-0");
            y By.Id("md_input-1");
            village By.Id("md_input-9");
            vPopMin By.Id("md_input-2");
            vPopMax By.Id("md_input-3");
            vPlamin By.Id("md_input-4");
            vPlaMax By.Id("md_input-5");
            vilcount By.Id("md_input-6");
            evoMax By.Id("md_input-7");
            evoMin By.Id("md_input-8");
        }

        public void Login(String username, String password)
        {
            browser.clickElement(By.Id("loginButton"));
            browser.waitForElement(3, By.Name("email"));
        }

    }
}
