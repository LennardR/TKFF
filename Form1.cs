using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChromiumCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser chrome;
        String startURL = "https://www.google.de";

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chrome = new ChromiumWebBrowser(startURL);
            this.pContainer.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }
    }
}
