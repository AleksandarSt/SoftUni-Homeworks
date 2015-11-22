using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Point
    {
        public static readonly Point StartingCoord;

        static Point()
        {
            StartingCoord = new Point(0, 0, 0);
        }

        private double xCord;
        private double yCord;
        private double zCord;

        

        public Point(double xCord, double yCord, double zCord)
        {
            this.XCord = xCord;
            this.YCord = yCord;
            this.ZCord = zCord;
        }

        public double XCord 
        {
            get { return this.xCord; }
            set { this.xCord = value; }
        }

        public double YCord
        {
            get { return this.yCord; }
            set { this.yCord = value; }
        }

        public double ZCord
        {
            get { return this.zCord; }
            set { this.zCord = value; }
        }

        public override string ToString()
        {
           return string.Format("3D point coordinates:( {0}, {1}, {2} )", this.XCord, this.YCord, this.ZCord);
        }

        
    }
}
