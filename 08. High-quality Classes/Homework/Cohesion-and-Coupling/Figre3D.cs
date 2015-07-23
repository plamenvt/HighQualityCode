namespace CohesionAndCoupling
{
    using System;

    internal class Figure3D : IDiagonalsCalculator2D, IDiagonalsCalculator3D
    {
        private double width;

        private double height;

        private double depth;

        public Figure3D(double width, double height, double depth)
        {
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (!this.IsValidSide(value))
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
                if (!this.IsValidSide(value))
                {
                    throw new ArgumentOutOfRangeException("Width must be a positive number");
                }

                this.width = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (!this.IsValidSide(value))
                {
                    throw new ArgumentOutOfRangeException("Depth must be a positive number");
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXyz()
        {
            double distance = CalculateDistanceUtils.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXy()
        {
            double distance = CalculateDistanceUtils.CalculateDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXz()
        {
            double distance = CalculateDistanceUtils.CalculateDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYz()
        {
            double distance = CalculateDistanceUtils.CalculateDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

        private bool IsValidSide(double number)
        {
            return number > 0;
        }
    }
}
