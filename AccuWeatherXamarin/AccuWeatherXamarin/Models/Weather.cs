﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccuWeatherXamarin.Models
{
    public class Weather
    {
        public string Text { get; set; }

        public string Category { get; set; }

        public string MinTemperature { get; set; }

        public string MaxTemperature { get; set; }
    }
}