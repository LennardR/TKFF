using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace TKFF
{
    class ChromeWrapper
    {
        private static ChromiumWebBrowser chromeBrowser;

        public ChromeWrapper()
        {
            chromeBrowser = Form1.chromeBrowser;
        }
        public String getHTML()
        {
            String source = chromeBrowser.GetSourceAsync().ToString();
            return source;
        }
        public void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                chromeBrowser.Load(url);
            }
        }


        public Boolean clickElement(String value, String valueType)
        {
                

            return true;
        }
    }
}
