﻿namespace TKFF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pBrowser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pBrowser
            // 
            pBrowser.Location = new System.Drawing.Point(0, 150);
            pBrowser.Name = "pBrowser";
            pBrowser.Size = new System.Drawing.Size(1080, 720);
            pBrowser.TabIndex = 0;
            pBrowser.Paint += new System.Windows.Forms.PaintEventHandler(this.pBrowser_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 831);
            this.Controls.Add(pBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.Panel pBrowser;
    }
}

