using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

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

        public void typeTextBox(By by,String msg)
        {
            IWebElement textBox = driver.FindElement(by);
            textBox.Clear();
            textBox.SendKeys(msg);
        }

        public bool WaitUntilElementIsPresent(By by, int timeout)
        {
            for (var i = 0; i < timeout; i++)
            {
                try
                {
                    IWebElement element = null;
                    element = driver.FindElement(by);
                    if (element != null)
                    {
                        return true;
                    }
                    else
                    {
                        Console.Write("WTF HOW?!");
                        return false;
                    }
                }
                catch (ElementNotVisibleException e)
                {
                    Thread.Sleep(1000);
                }
            }
            return false;
        }

        public void chooseSelect(By byElement,By byOption)
        {
            driver.FindElement(byElement).Click();
        }

    }
}
