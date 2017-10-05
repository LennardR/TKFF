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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using CefSharp.Internals;

namespace TKFF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static ChromiumWebBrowser chromeBrowser;
        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings

            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://www.google.de");
            // Add it to the form and fill it to the form window.
            Form1.pBrowser.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            using (var chromeBrowser = new ChromiumWebBrowser("http://www.google.de"))
            {
                    chromeBrowser.FrameLoadStart += (s, argsi) =>
                    {
                        Console.WriteLine("Loaded!");
                    };
                }
                await LoadPageAsync(chromeBrowser);
            //FOR TESTING PURPOSE
            TKWrapper travian = new TKWrapper();
            }

        public static Task LoadPageAsync(IWebBrowser browser, string address = null)
        {
            //If using .Net 4.6 then use TaskCreationOptions.RunContinuationsAsynchronously
            //and switch to tcs.TrySetResult below - no need for the custom extension method
            var tcs = new TaskCompletionSource<bool>();

            EventHandler<LoadingStateChangedEventArgs> handler = null;
            handler = (sender, args) =>
            {
                //Wait for while page to finish loading not just the first frame
                if (!args.IsLoading)
                {
                    browser.LoadingStateChanged -= handler;
                    //This is required when using a standard TaskCompletionSource
                    //Extension method found in the CefSharp.Internals namespace
                    tcs.TrySetResultAsync(true);
                }
            };

            browser.LoadingStateChanged += handler;

            if (!string.IsNullOrEmpty(address))
            {
                browser.Load(address);
            }
            return tcs.Task;
        }

        private void pBrowser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
