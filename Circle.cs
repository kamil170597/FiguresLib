using System;

public class Class1
{
    public Class1()
    {
    }

        public class Circle : Figure, IMeasurable1D, IEquatable<Circle>
    {
        public Point Center;
        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if (value < 0)
                    throw new ArgumentException("negative argument not allowed");
                radius = Math.Round(value, Figure.FRACTIONAL_DIGITS);
            }
        }

        public Circle() : this(new Point(0, 0), 1) { }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
            Color = System.Drawing.Color.Cyan;
        }

        public double Length => 2 * Math.PI * radius;

        public override string ToString() => $"Circle( {Center}, {radius} )";

        public override void Draw()
        {
            Console.WriteLine($"drawing: {this}, {Color}, Length = {Length}");
        }

        #region IEquatable<Circle> implementation
        public bool Equals(Circle other)
        {
            if (other is null) return false;

            return this.Center == other.Center && this.Radius == other.Radius;
        }
        #endregion
    }
}
