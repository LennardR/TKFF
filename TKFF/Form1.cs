using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKFF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FOR TESTING PURPOSE
            TKWrapper travian = new TKWrapper();
        }

        private void pBrowser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
