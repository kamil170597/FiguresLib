using System;

public class Class1
{
	public Class1()
	{
	}

    public class Wheel : Circle, IMeasurable2D
    {
        public Wheel() : this(new Point(0, 0), 1) { }

        public Wheel(Point center, double radius) : base(center, radius)
        {
            Color = System.Drawing.Color.Magenta;
        }

        public double Circumference => Length;

        public double Surface => Math.PI * Radius * Radius;

        public override string ToString() => $"Wheel( {Center}, {Radius} )";
        public override void Draw()
        {
            Console.WriteLine($"drawing: {this}, {Color}, Circumference = {Circumference}, Surface = {Surface}");
        }
    }
}
