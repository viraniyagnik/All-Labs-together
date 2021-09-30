using System;
using Lab1_Geometry2D.Geometry2D;
using Lab1_Geometry2D.Particles;

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


            Phonon p = new Phonon(1);
            Console.WriteLine(p); // position (0, 0)


            Point point = p.Position;
            point.SetCoords(100, 100);
            Console.WriteLine(p); // position (100,100),  change to set position remain (0,0)

            Phonon P1 = new Phonon(p);// make a replica of p 


        }
    }
}
