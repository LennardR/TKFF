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
using OpenQA.Selenium.Support.UI;

namespace TKFF
{
    class ChromeWrapper
    //Controlling Chrome with Selenium
    {
        private static IWebDriver driver;

        public ChromeWrapper()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--user-data-dir=%LocalAppData%\\Local\\Google\\Chrome\\User Data\\Default");
            driver = new ChromeDriver();
        }
        public String getHTMLOfElement(By by)
        {
            return driver.FindElement(by).GetAttribute("innerHTML");
        }

        public String getTextOfElement(By by)
        {
            return driver.FindElement(by).Text;
        }

        public String getValueOfAttributeOfElement(By by, String attributeName)
        {
            return driver.FindElement(by).GetAttribute(attributeName);
        }
        public void LoadUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void clickElement(By by)
        {
            driver.FindElement(by).Click();
        }

        public Boolean waitForElement(int timeoutInSeconds,By by)
        {
            IWebElement waitedForElement = null;
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                waitedForElement = wait.Until(drv => drv.FindElement(by));

            }
            waitedForElement = driver.FindElement(by);
            if (waitedForElement == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void chooseSelect(By byElement,By byOption)
        {
            driver.FindElement(byElement).Click();
        }

    }
}
