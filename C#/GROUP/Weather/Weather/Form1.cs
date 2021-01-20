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
using Newtonsoft.Json;
using System.IO;
using System.Net;

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
            //this will check to make sure that there is something to grab
            if (txtZip.TextLength == 5)
            {
                try
                {
                    int Zip = Convert.ToInt32(txtZip.Text);


                    HttpResponseMessage response = await client.GetAsync("https://api.openweathermap.org/data/2.5/weather?zip=" + Zip + "&APPID=" + apiKey + "&units=imperial");


                    //Pass the JSON HTTP response to a string for deserialize.
                    string jsonResults = (await response.Content.ReadAsStringAsync());

                    //Deserialize JSON results into our weather object to hang on to and do stuff with.
                    Data jsonObj = JsonConvert.DeserializeObject<Data>(jsonResults);

                    //Use our object to show our stored values

                    lblTemp.Text = jsonObj.main.temp + "°";
                    lblTempHigh.Text = jsonObj.main.temp_max+"";
                    lblTempLow.Text = jsonObj.main.temp_min + "";
                    lblObserve.Text = jsonObj.weather[0].main + "";
                    lblDesc.Text = jsonObj.weather[0].description + "";
                    lblPressure.Text = jsonObj.main.pressure + "";
                    lblHumidity.Text = jsonObj.main.humidity + "";
                    lblWindPressure.Text = jsonObj.wind.speed + "";

                    //code to fetch the appropriate weather icon from openweathermap
                    imgBox.Load("http://openweathermap.org/img/w/" + jsonObj.weather[0].icon + ".png");
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Please enter a valid zip code!");;
                }
                

            }
            else
            {
                MessageBox.Show("Please enter a valid zip code!");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTemp.Text = "";
            lblTempHigh.Text = "";
            lblTempLow.Text = "";
            lblObserve.Text = "";
            lblDesc.Text = "";
            lblPressure.Text = "";
            lblHumidity.Text = "";
            lblWindPressure.Text = "";
            imgBox.Image = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
