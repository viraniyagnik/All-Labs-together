using System;
using Lab1_Geometry2D.Geomatry2D;

namespace Lab1_Geometry2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P = new Point();// make x and y (0,0)
            Point p1 = new Point(1,2);//make x and y (1,2)

            P.SetCoords(3,3);// to set coordinates (3,3)
            P.SetCoords(3, null);//to set coordinates(3,0)
        }
    }
}
