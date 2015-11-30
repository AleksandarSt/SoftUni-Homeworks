﻿

using Shapes.Interfaces;

namespace Shapes.Classes
{
    abstract class BasicShape:IShape
    {
        private double width;

        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double CalculateArea()
        {
            throw new System.NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            throw new System.NotImplementedException();
        }

        
    }
}
