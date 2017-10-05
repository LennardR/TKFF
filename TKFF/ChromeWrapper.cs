using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TKFF
{
    class ChromeWrapper
    //Controlling Chrome with Selenium
    {
        private static IWebDriver driver;

        public ChromeWrapper()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            driver = new ChromeDriver();
        }
        public String getHTMLOfElement(String idValue)
        {
            return driver.FindElement(By.Id(idValue)).GetAttribute("innerHTML");
        }

        public String getTextOfElement(String idValue)
        {
            return driver.FindElement(By.Id(idValue)).Text;
        }

        public String getValueOfAttributeOfElement(String idValue, String attributeName)
        {
            return driver.FindElement(By.Id(idValue)).GetAttribute(attributeName);
        }
        public void LoadUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void clickElement(String idValue)
        {
            IWebElement e = driver.FindElement(By.Id(idValue));
            if (true)e.Click();
        }
    }
}
