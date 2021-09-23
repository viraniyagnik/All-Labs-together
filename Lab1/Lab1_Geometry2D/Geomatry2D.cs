using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Geometry2D
{
    namespace Geomatry2D
    {
        
        public class Point
        {
            public double X { get; set; }
            public double Y{ get; set; }

           
            public Point(double x = 0, double y = 0)
            {
                X = x;
                Y = y;
            }

            // To get x and y coordinates 
            // return x and y value to the Point
            public void GetCoords(out double x , out double y)
            {
                x = X;
                y = Y;
            }

           
            // to set one coordinate or the other
            public void SetCoords(double? x, double? y)
            {
                X = x ?? X;
                Y = y ?? Y;
            }
            public override string ToString() => $"({X}, {Y})";
           
        }

        public class Vector
        {
            public double DX { get;  set; }
            public double DY { get;  set; }

          

            public Vector(double dx =0, double dy = 0)
            {
                DX = dx;
                DY = dy;
                Set(dx,dy);
             
            }
            //set x and y components of the vector
            public void Set(double dx, double dy)
            {
                DX = dx;
                DY = dy;
                //[-1 1] if object out of the range exception will aplly
                  if (InRange(DX) || InRange(DY))
                  {
                    // throw exception    
                    throw new ArgumentOutOfRangeException();
                  }


            }
               // to check the range
                private bool InRange(double x)
                {
                    return x <= -1 || x >= 1;
                }
            
            public override string ToString() => $"({DX}, {DY})";
        }

        //immutable rectangle the length and width
        public class Rectangle
        {
            public double Length { get; }
            public double Width { get; }

            public double Area{get; }
            

            public Rectangle(double length, double width)
            {
                // to count area of rectangle
                Length = length;
                Width = width;
                Area = Length * Width;
            }
            
             
        

        }
    }
}
