using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Text = webBrowser1.DocumentTitle;
            textBox1.Text = webBrowser1.Url.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.bg/");
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string googleSearchString = "http://www.google.co.uk/search?hl=en&q=" + textBox2.Text + "&meta=";
            webBrowser1.Navigate(googleSearchString); ;
            WindowState = FormWindowState.Maximized;
            webBrowser1.Size = new Size(Form1.ActiveForm.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            WindowState = FormWindowState.Maximized;
        }
    }
}
