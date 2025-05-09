﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
       public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast("Stratford,CA");
            ExtractCurrent("Stratford,CA");
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast(string Location)
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q="+ $"{Location}" + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            days.Clear();

            while (reader.Read())
            {
                //TODO: create a day object

                Day d = new Day();

                //TODO: find time element and get day attribute

                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                // find temp element get min max attributes

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                //add day to list of days
                days.Add(d);
            }
        }

        public static void ExtractCurrent(string Location)
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + $"{Location}" + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            // reader.ReadToFollowing("");
            // days[0].currentTime = reader.GetAttribute("");

            DateTime dateTime = DateTime.Now;
            days[0].currentTime = Convert.ToString(dateTime.TimeOfDay);

            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("value");

            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("value");


            reader.ReadToFollowing("visibility");
            days[0].visibility = reader.GetAttribute("value");

            reader.ReadToFollowing("precipitation");
            days[0].precipitation = reader.GetAttribute("mode");


        }


    }
}
