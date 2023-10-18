using System;

namespace lab1_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point[] vertices = new Point[4];
            InputCoordinates(out vertices);

            Rechtangle rechtangle = new Rechtangle(vertices);

            OutputCooridates(vertices);

            double perimeter = rechtangle.FindPerimeter();
            double area = rechtangle.FindArea();
            Console.WriteLine($"Периметр: {perimeter}");
            Console.WriteLine($"Площа: {area}");
        }
        public static void InputCoordinates(out Point[] vertices)
        {
            vertices = new Point[4];
            Console.WriteLine("Введіть координати для 4 вершин в такому форматі {x y} через Enter");
            for (int i = 0; i < 4; i++)
            {
                string[] cord = Console.ReadLine().Trim().Split();
                vertices[i] = new Point( Convert.ToDouble(cord[0]), Convert.ToDouble(cord[1]));
            }
        }
        public static void OutputCooridates(Point[] vertices)
        {
            Console.WriteLine("Вершини прямокутника:");
            foreach (Point vertex in vertices)
            {
                Console.WriteLine($"({vertex.x}; {vertex.y})");
            }
        }
    }
}