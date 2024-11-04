﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoWebAPI.Models
{
    public class GeoPoint
    {
        public int ID   { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}