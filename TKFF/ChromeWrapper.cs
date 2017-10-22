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
            Console.WriteLine("Clicking on element " + by.ToString());
            driver.FindElement(by).Click();
        }

        public void typeTextBox(By by,String msg)
        {
            IWebElement textBox = null;
            textBox = driver.FindElement(by);
            textBox.Clear();
            textBox.SendKeys(msg);
        }

        public bool WaitUntilElementIsPresent(By by, int timeout)
        {
            Console.WriteLine("Searching for element " + by.ToString());
            for (var i = 0; i < timeout; i++)
            {
                try
                {
                    Console.WriteLine("Try: " + i + "/" + timeout);
                    IWebElement element = null;
                    element = driver.FindElement(by);
                    if (element != null)
                    {
                        Console.WriteLine("Found!");
                        return true;
                    }
                    else
                    {
                        Console.Write("WTF HOW?!");
                        return false;
                    }
                }
#pragma warning disable CS0168
                catch (NoSuchElementException e)
#pragma warning restore CS0168
                {
                    Thread.Sleep(1000);
                }
            }
            Console.Write(by.ToString() + " not found!");
            return false;
        }

      public IWebElement getElement(By by)
      {
          return driver.FindElement(by);
      }
      public IReadOnlyCollection<IWebElement> getElements(By by)
      {
            return driver.FindElements(by);
      }

    }
}
