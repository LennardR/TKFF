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
        ChromeWrapper browser = new ChromeWrapper();
        Console.WriteLine(browser.getHTML());
        }
    }
}
