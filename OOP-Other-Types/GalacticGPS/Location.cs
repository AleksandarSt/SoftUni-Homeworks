using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    public struct Location
    {
        private const double minLatitude = -90;
        private const double maxLatitude = 90;
        private const double minLongitude = -180;
        private const double maxLongitude = 180;

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
                if (value<minLatitude ||value>maxLatitude)
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
                if (value<minLongitude ||value>maxLongitude)
                {
                    throw new ArgumentOutOfRangeException("Longtitude must be in range 0 to 180");
                }

                this.longitude = value;
            }
        }

        public Planet Planet 
        {
            get { return this.planet; }
            set 
            {
                this.planet = value;
            } 
        }

        public override string ToString()
        {
            string result = this.Latitude.ToString() + ", " + this.Longitude.ToString() + " - " + this.Planet;
            return result;
        }
    }
}
