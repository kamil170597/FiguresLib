using System;

public class Class1
{
	public Class1()
	{
	}
    public class LineSegment : Figure, IMeasurable1D, IEquatable<LineSegment>
    {
        public Point StartPoint;
        public Point EndPoint;

        public LineSegment() : this(new Point(0, 0), new Point(0, 0))
        {
        }

        public LineSegment(Point p1, Point p2)
        {
            StartPoint = p1;
            EndPoint = p2;
            Color = System.Drawing.Color.Green;
        }

        public double Length => Math.Sqrt(Math.Pow(StartPoint.X - EndPoint.X, 2) + Math.Pow(StartPoint.Y - EndPoint.Y, 2));

        public override void Draw()
        {
            Console.WriteLine($"drawing: {this}, {Color}, Length = {Length}");
        }

        public override string ToString() => $"LineSegment({StartPoint}, {EndPoint})";

        #region IEquatable<LineSegment> implementation
        public bool Equals(LineSegment other)
        {
            if (other is null) return false;

            return (this.StartPoint == other.StartPoint && this.EndPoint == other.EndPoint)
                    || (this.StartPoint == other.EndPoint && this.EndPoint == other.StartPoint);
        }

        public static bool operator ==(LineSegment s1, LineSegment s2)
        {
            if (s1 is null && s2 is null) return true;
            if (s1 is null && !(s2 is null)) return false;

            return s1.Equals(s2);
        }

        public static bool operator !=(LineSegment s1, LineSegment s2) => !(s1 == s2);
        #endregion
    }
}
