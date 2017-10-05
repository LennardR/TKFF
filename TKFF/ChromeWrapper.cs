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
            service.Port = 8088;
            driver = new ChromeDriver();
        }
        public String getHTML()
        {
            return null;
        }
        public void LoadUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public Boolean clickElement(String value, String valueType)
        {
                
            return true;
        }
    }
}
