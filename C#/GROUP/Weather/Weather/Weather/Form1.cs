using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Weather
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();

        static string apiKey = ("2ba963f59f13c6d5308cbe0961c9086c");           

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            int Zip = Convert.ToInt32(txtZip.Text);
            //string txtData;

            HttpResponseMessage response = await client.GetAsync("https://api.openweathermap.org/data/2.5/weather?zip=" + Zip + "&APPID=" + apiKey);
            //txtData = (await response.Content.ReadAsStringAsync());
            rtfBox.Text = (await response.Content.ReadAsStringAsync());


        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
