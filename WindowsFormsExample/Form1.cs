using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string google = "http://www.google.com";
        private async void Button100_Click(object sender, EventArgs e)
        {
            var urls = Enumerable.Range(1, 100).Select(x => google).ToList();
            foreach (var url in urls)
            {
                var txt = await WebScraper.BrowserBasedWebScraper.LoadUrl(url);
                this.textBox1.Text = DateTime.Now.ToString() + Environment.NewLine
                    + txt.Substring(1, 200) + "...";
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = await WebScraper.BrowserBasedWebScraper.LoadUrl(google);
        }

        private void ButtonMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move me and look at TextBox first line!");
        }
    }
}
