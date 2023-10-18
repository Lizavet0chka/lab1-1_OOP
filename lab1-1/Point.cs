using System;

namespace lab1_1
{
    public class Point
    {
        public double x { get; }
        public double y { get; }
        
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double FindDistance(Point other)
        {
            double dx = x - other.x;
            double dy = y - other.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}