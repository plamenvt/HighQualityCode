namespace Task1.ClassSizeInCSharp
{
    using System;
 
    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be possitive number!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be possitive number!");
                }

                this.height = value;
            }
        }

        public static Figure GetRotatedFigure(Figure figure, double angleOfTheFigureToBeRotated)
        {
         double sinusTimesWidth = Math.Abs(Math.Sin(angleOfTheFigureToBeRotated)) * figure.Width;
         double cosinusTimesWidth = Math.Abs(Math.Cos(angleOfTheFigureToBeRotated)) * figure.Width;
         double sinusTimesHeight = Math.Abs(Math.Sin(angleOfTheFigureToBeRotated)) * figure.Height;
         double cosinusTimesHeight = Math.Abs(Math.Cos(angleOfTheFigureToBeRotated)) * figure.Height;

         double rotatedFigureWidth = cosinusTimesWidth + sinusTimesHeight;
         double rotatedFigureHeight = sinusTimesWidth + cosinusTimesHeight;

         Figure rotatedFigure = new Figure(rotatedFigureWidth, rotatedFigureHeight);

         return rotatedFigure;
        }
    }
}
