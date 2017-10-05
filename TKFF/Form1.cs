using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace TKFF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static ChromiumWebBrowser chromeBrowser;
        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://www.google.de");
            // Add it to the form and fill it to the form window.
            Form1.pBrowser.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;


            //FOR TESTING PURPOSE
            TKWrapper travian = new TKWrapper();

        }
    }
    }
