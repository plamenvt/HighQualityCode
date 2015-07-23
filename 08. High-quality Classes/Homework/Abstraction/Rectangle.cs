namespace Abstraction
{
    using System;

    internal class Rectangle : Figure
    {
        private double width;

        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height 
        { 
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be a positive number");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be a positive number");
                }

                this.width = value;
            }
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalculateSurface()
        {
            double area = this.Width * this.Height;
            return area;
        }
    }
}
