using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    public struct Location
    {
        const double maxLatitude = 90;
        const double maxLongtitude = 180;

        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude,Planet planet)
            :this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value<0 ||value>maxLatitude)
                {
                    throw new ArgumentOutOfRangeException("Latitude must be in range 0 to 90");
                }

                this.latitude=value;
            }
        }

        public double Longitude {
            get { return this.longitude; }
            set
            {
                if (value<0 ||value>maxLongtitude)
                {
                    throw new ArgumentOutOfRangeException("Longtitude must be in range 0 to 180");
                }

                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            string result = this.Latitude.ToString() + ", " + this.Longitude.ToString() + " - " + this.Planet;
            return result;
        }
    }
}
