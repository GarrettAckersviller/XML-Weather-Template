using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public static string Location = "";

        public void DisplayCurrent()
        {
            

            currentLabel.Text = Form1.days[0].currentTemp;
            cityOutput.Text = Form1.days[0].location;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            windOutput.Text = Form1.days[0].windSpeed;
            wdOutput.Text = Form1.days[0].windDirection;
            precipOutput.Text = Form1.days[0].precipitation;
            visOutput.Text = Form1.days[0].visibility;
            if (Convert.ToDouble(currentLabel.Text) <= 5)
            {
                this.BackColor = Color.Blue;
                currentLabel.BackColor = Color.Blue;
                minOutput.BackColor = Color.Blue;
                maxOutput.BackColor = Color.Blue;
                windOutput.BackColor = Color.Blue;
                wdOutput.BackColor = Color.Blue;
                precipOutput.BackColor = Color.Blue;
                visOutput.BackColor = Color.Blue;
                pictureBox1.Image = Properties.Resources.Snow;
            }

            if (Convert.ToDouble(currentLabel.Text) >= 5)
            {
                this.BackColor = Color.Black;
                currentLabel.BackColor = Color.Black;
                minOutput.BackColor = Color.Black;
                maxOutput.BackColor = Color.Black;
                windOutput.BackColor = Color.Black;
                wdOutput.BackColor = Color.Black;
                precipOutput.BackColor = Color.Black;
                visOutput.BackColor = Color.Black;
                pictureBox1.Image = Properties.Resources.Sun;
            }

           
            


        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Location = searchBox.Text;
                Form1.ExtractForecast(Location);
                Form1.ExtractCurrent(Location);

                DisplayCurrent();

                searchBox.Text = "Search City...";

                this.Focus();
            }
            catch
            {
                searchBox.Text = "Error";
            }

            if (Convert.ToDouble(currentLabel.Text) <= 5)
            {
                this.BackColor = Color.Blue;
                currentLabel.BackColor = Color.Blue;
                minOutput.BackColor = Color.Blue;
                maxOutput.BackColor = Color.Blue;
                windOutput.BackColor = Color.Blue;
                wdOutput.BackColor = Color.Blue;
                precipOutput.BackColor = Color.Blue;
                visOutput.BackColor = Color.Blue;

                pictureBox1.Image = Properties.Resources.Snow;
            }



            if (Convert.ToDouble(currentLabel.Text) >= 5)
            {
                this.BackColor = Color.Black;
                currentLabel.BackColor = Color.Black;
               minOutput.BackColor = Color.Black;
                maxOutput.BackColor = Color.Black;
                windOutput.BackColor = Color.Black;
                wdOutput.BackColor = Color.Black;
                precipOutput.BackColor = Color.Black;
                visOutput.BackColor = Color.Black;
                pictureBox1.Image = Properties.Resources.Sun;

            }

            if (Convert.ToDouble(currentLabel.Text) >= 30)
            {
                this.BackColor = Color.DarkRed;
                currentLabel.BackColor = Color.DarkRed;
                minOutput.BackColor = Color.DarkRed;
                maxOutput.BackColor = Color.DarkRed;
                windOutput.BackColor = Color.DarkRed;
                wdOutput.BackColor = Color.DarkRed;
                precipOutput.BackColor = Color.DarkRed;
                visOutput.BackColor = Color.DarkRed;
                pictureBox1.Image = Properties.Resources.Sun;
            }

           if (precipOutput.Text == "yes")
            {
                pictureBox1.Image = Properties.Resources.Rain;
            }

            if (Convert.ToDouble(windOutput.Text) >= 10)
            {
                pictureBox1.Image = Properties.Resources.Cloud;
            }



        }


    }
}
