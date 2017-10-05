using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TKFF
{
    class TKWrapper


    {
        public TKWrapper() {
        Console.WriteLine("Hi!");
        ChromeWrapper browser = new ChromeWrapper();
            Console.WriteLine("Going to Kingdoms!");
            browser.LoadUrl("http://www.kingdoms.com");
            Console.WriteLine("Back to google!");
            browser.LoadUrl("http://www.google.de");
            Console.WriteLine("Aaaand back to Kingdoms!");
            browser.LoadUrl("http://www.kingdoms.com");
            Console.WriteLine("click play now");
            browser.clickElement("loginButton");
            Console.WriteLine("did he ? ");


        }

    }
}
