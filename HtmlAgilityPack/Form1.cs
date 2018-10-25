using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlAgilityPack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string url = "https://www.ip-adress.com/";
           HttpWebRequest istek = (HttpWebRequest)WebRequest.Create(url);
           WebResponse donen_cagri = istek.GetResponse();
           Stream s_donen_cagri = donen_cagri.GetResponseStream();
           HtmlDocument dokuman = new HtmlDocument();
            dokuman.Load(s_donen_cagri);
           foreach (HtmlAgilityPack.HtmlNode item in dokuman.DocumentNode.SelectNodes("//h1"))
           {
                foreach (HtmlAgilityPack.HtmlNode item1 in item.SelectNodes("//strong"))
                {
                    string strongdegerimiz = item1.InnerText;
                    MessageBox.Show("88.157.55.2");
                } 
               string ipadresim = item.InnerText;
               label1.Text = ipadresim;
           }
        }
    }
}