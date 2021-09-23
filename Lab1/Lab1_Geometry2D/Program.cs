using System;
using Lab1_Geometry2D.Geomatry2D;

namespace Lab1_Geometry2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P = new Point();
            Point p1 = new Point(1,2);

            P.SetCoords(3,3);
            P.SetCoords(3, null);
        }
    }
}
