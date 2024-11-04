using GeoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeoWebAPI.Controllers
{
    public class GeoController : ApiController
    {
        public List<GeoPoint> Points = new List<GeoPoint>()
        {
            new GeoPoint() {ID = 1, Longitude = 51.1, Latitude = 35.5 },
            new GeoPoint() {ID = 2, Longitude = 52.3, Latitude = 34.3 },
            new GeoPoint() {ID = 3, Longitude = 53.2, Latitude = 32.3 },
            new GeoPoint() {ID = 4, Longitude = 49.9, Latitude = 35.7 }
        };

        private GeoPoint getbyID(int id)
        {
            GeoPoint point = null;
            foreach (GeoPoint pt in Points)
            {
                if (pt.ID == id)
                {
                    point = new GeoPoint();
                    point = pt;
                }
            }
            return point;
        }


        public IHttpActionResult GetPointByID(int id)
        {
            GeoPoint point = getbyID(id);
            if (point == null)
                return NotFound();

            return Ok(point);
        }

        public IHttpActionResult GetDistance(double x, double y, int id)
        {
            GeoPoint point = getbyID(id);
            if (point == null)
                return NotFound();

            double distance = Math.Sqrt(Math.Pow(point.Longitude - x, 2) + Math.Pow(point.Latitude - y, 2));
            return Ok(distance);
        }



    }
}
