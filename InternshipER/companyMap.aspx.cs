using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace InternshipER
{
    public partial class companyMap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Coordinate deneme = GetCoordinates("Ankara");
            System.Diagnostics.Debug.WriteLine("$$$$$"+deneme.Latitude+" - "+deneme.Longitude);
            RetrieveFormatedAddress(deneme.Latitude.ToString(),deneme.Longitude.ToString());
        }
        public static Coordinate GetCoordinates(string region)
        {
            using (var client = new WebClient())
            {
                String uri = "https://maps.googleapis.com/maps/api/geocode/xml?address=" + region + "&key=AIzaSyBfwnyg_sJupaI-e-MuAxGh7jbLK83Beu8";
                //string uri = "http://maps.google.com/maps/geo?q='" + region +
                //  "'&output=csv&key=ABQIAAAAzr2EBOXUKnm_jVnk0OJI7xSosDVG8KKPE1" +
                //  "-AIzaSyBfwnyg_sJupaI-e-MuAxGh7jbLK83Beu8";

                string[] geocodeInfo = client.DownloadString(uri).Split(',');

                return new Coordinate(Convert.ToDouble(geocodeInfo[2]),
                           Convert.ToDouble(geocodeInfo[3]));
            }
        }
        public struct Coordinate
        {
            private double lat;
            private double lng;

            public Coordinate(double latitude, double longitude)
            {
                lat = latitude;
                lng = longitude;

            }

            public double Latitude { get { return lat; } set { lat = value; } }
            public double Longitude { get { return lng; } set { lng = value; } }

        }

        static string baseUri ="http://maps.googleapis.com/maps/api/geocode/xml?latlng={0},{1}&sensor=false";
        string location = string.Empty;

        public static void RetrieveFormatedAddress(string lat, string lng)
        {
            string requestUri = string.Format(baseUri, lat, lng);

            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString(requestUri);
                var xmlElm = XElement.Parse(result);
                var status = (from elm in xmlElm.Descendants() where
                                elm.Name == "status" select elm).FirstOrDefault();
                if (status.Value.ToLower() == "ok")
                {
                    var res = (from elm in xmlElm.Descendants() where
                                elm.Name == "formatted_address" select elm).FirstOrDefault();
                    requestUri = res.Value;
                    System.Diagnostics.Debug.WriteLine("$$$$$$$ "+res.Value);
                }
                
            }
        }
    }
}