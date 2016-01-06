using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace TryForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Double lat;
            Double lon;
            bool result;
            result = Double.TryParse(textBox6.Text.ToString(), out lat);
            result = Double.TryParse(textBox7.Text.ToString(), out lon);
            //textBox8.Text = lat.ToString();
            //textBox9.Text = lon.ToString();
            
            DateTime date = dateTimePicker1.Value;
            double jd     = SunriseCalculator.SolarInfo.ForDate(lat, lon, date).JD;
            textBox1.Text = jd.ToString();

            TimeSpan? noon = SunriseCalculator.SolarInfo.ForDate(lat, lon, date).Noon;
            textBox2.Text  = noon.ToString();

            TimeSpan eot  = SunriseCalculator.SolarInfo.ForDate(lat, lon, date).EquationOfTime;
            textBox3.Text = eot.ToString();

            DateTime sunrise = SunriseCalculator.SolarInfo.ForDate(lat, lon, date).Sunrise;
            textBox4.Text    = sunrise.ToString();

            DateTime sunset = SunriseCalculator.SolarInfo.ForDate(lat, lon, date).Sunset;
            textBox5.Text   = sunset.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Double lat;
            //Double lon;
            //bool result;
            //result = Double.TryParse(textBox6.Text.ToString(), out lat);
            //result = Double.TryParse(textBox7.Text.ToString(), out lon);
            //textBox8.Text = lat.ToString();
            //textBox9.Text = lon.ToString();
            
            //DateTime date = dateTimePicker1.Value;
            //double jd = SunriseCalculator.SolarInfo.ForDate(lat, 88.74467, date).JD;
            //textBox1.Text = jd.ToString();

            //TimeSpan? noon = SunriseCalculator.SolarInfo.ForDate(lat, 88.74467, date).Noon;
            //textBox2.Text = noon.ToString();

            //TimeSpan eot = SunriseCalculator.SolarInfo.ForDate(lat, 88.74467, date).EquationOfTime;
            //textBox3.Text = eot.ToString();

            //DateTime sunrise = SunriseCalculator.SolarInfo.ForDate(lat, 88.74467, date).Sunrise;
            //textBox4.Text = sunrise.ToString();

            //DateTime sunset = SunriseCalculator.SolarInfo.ForDate(lat, 88.74467, date).Sunset;
            //textBox5.Text = sunset.ToString();
        }
    }
}