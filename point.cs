using System;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // checks whether three points lie on the same straight line
    public static bool IsCollinear(Point a, Point b, Point c)
    {
        double area = a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y);
        return area == 0;
    }
}
