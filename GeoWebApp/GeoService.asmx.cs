using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GeoWebApp
{
    /// <summary>
    /// Summary description for GeoService
    /// </summary>
    [WebService(Namespace = "http://www.wenet.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GeoService : System.Web.Services.WebService
    {
        public List<GeoPoint> Points = new List<GeoPoint>()
        {
            new GeoPoint() { Latitude = 35, Longitude = 51, ID = 1},
            new GeoPoint() { Latitude = 36, Longitude = 52, ID = 2},
            new GeoPoint() { Latitude = 37, Longitude = 53, ID = 3},
            new GeoPoint() { Latitude = 39, Longitude = 54, ID = 4}
        };

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public GeoPoint GetPointByID(int id)
        {
            GeoPoint result = GetByID(id);
            return result;
        }

        [WebMethod]
        public double GetDistance(int id, double X, double Y)
        {
            GeoPoint point = GetByID(id);

            if (point != null)
            {
                double distance = point.Longitude - X + point.Latitude * Y;

                return distance;
            }
            else
            {
                return -1;
            }
            
        }


        private GeoPoint GetByID(int id)
        {
            GeoPoint result = null;

            foreach (GeoPoint pt in Points)
            {
                if (pt.ID == id)
                {
                    result = pt;
                }
            }

            return result;
        }
    }
}
