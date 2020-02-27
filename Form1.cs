using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Weather_Condition_App
{
    public partial class Form1 : Form
    {
        private const bool V = true;

        // Global variable with server's address
        readonly string BaseUrl = "http://weather-csharp.herokuapp.com/";

        string[] States = {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado",
            "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Hawaii",
            "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine",
            "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri",
            "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York",
            "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania",
            "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah",
            "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };



        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            // Disable button to prevent user making another request before this one is done
            btnGetWeather.Enabled = false;

            // Read data from TextBoxes
            string city = txtCity.Text;
            string state = cbxState.Text;

            if (LocationDataValid(city, state))
            {
                // Fetch current weather and display    
                if (GetWeatherText(city, state, out string weatherText, out string error))
                {
                    lblWeather.Text = weatherText;
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            if (picWeather.Image != null)
            {
                picWeather.Image.Dispose();  // Clear previous image
            }

            if (GetWeatherImage(city, state, out Image image, out string imageErrorMessage))
            {
                picWeather.Image = image;
            }
            else
            {
                MessageBox.Show("Enter both city and state", "Error");
            }

            //Enable button so user can get weather for somewhere else
            btnGetWeather.Enabled = true;
        }

        private bool GetWeatherText(string city, string state, out string weatherText, out string errorMessage)
        {
            // Use the Format method to make a string in the format
             // http://weather-csharp.herokuapp.com/text?city=minneapolis&state=mn

            string weatherTextUrl = String.Format("{0}text?city={1}&state={2}", BaseUrl, city, state);
            Debug.WriteLine(weatherTextUrl);  // Message only seen by developers

            errorMessage = null;
            weatherText = null;

            try
            {

                using (WebClient client = new WebClient())
                {
                    weatherText = client.DownloadString(weatherTextUrl);
                }

                Debug.WriteLine(weatherText);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
                errorMessage = e.Message;  // You'll refine this in lab
                return false;
            }
        }

        private bool LocationDataValid(string city, string state)
        {
            // Make checks on data, return false if any fail
            if (String.IsNullOrWhiteSpace(city))
            {
                return false;
            }

            if (String.IsNullOrWhiteSpace(state))
            {
                return false;
            }
            // All checks passed? Data looks good, return true
            return true;
        }
        private bool GetWeatherImage(string city, string state, out Image WeatherImage, out string errorMessage)
        {
            WeatherImage = null;  // Initialize the out parameters
            errorMessage = null;  // Will only set one of these, depending on if things work or not

            try
            {
                using (WebClient client = new WebClient())
                {
                    // use the Format method to make a string in the format
                    // http://weather-csharp.herokuapp.com/photo?city=austin&state=tx
                    string weatherPhotoUrl = String.Format("{0}photo?city={1}&state={2}", BaseUrl, city, state);
                    string tempFileDirectory = Path.GetTempPath().ToString();  // Directory to save image
                    string weatherFilePath = Path.Combine(tempFileDirectory, "weather_image.jpg");  // Plus filename to make complete path
                    Debug.WriteLine(weatherFilePath);
                    client.DownloadFile(weatherPhotoUrl, weatherFilePath);  // Download from URL
                    WeatherImage = Image.FromFile(weatherFilePath);  // setting the out parameter
                }
                return true;  // Request was made, file was saved, no errors
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);  // To help troubleshoot
                errorMessage = e.Message;  // setting the out parameter
                return false; // to inform the caller that there was an error
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxState.Items.AddRange(States);
        }
    }
}