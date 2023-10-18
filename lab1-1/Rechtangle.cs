using System.Linq;

namespace lab1_1
{
    public class Rechtangle
    {
        public double[] sides;

        public Rechtangle(Point[] vertices)
        {
            sides = new double[2];
            sides[0] = vertices[0].FindDistance(vertices[1]);
            sides[1] = vertices[1].FindDistance(vertices[2]);
        }
        public double this[int index]
        {
            get 
            {
                if (index >= 0 || index < sides.Length)
                {
                    return sides[index];
                }
                else
                {
                    return 0;
                }
            }
        }
        public double FindPerimeter()
        {
            return 2*sides.Sum();
        }

        public double FindArea()
        {
            return sides[0] * sides[1];
        }
    }
}