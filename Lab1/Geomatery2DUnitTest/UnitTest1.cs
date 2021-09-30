using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_Geometry2D.Geometry2D;



namespace Geomatery2DUnitTest
{
	using Lab1_Geometry2D.Particles;
	
	using System;
	[TestClass]
	public class ParticleTest
	{
		[TestMethod]
		public void TestDrift()
		{
			// to test Phonom
			Phonon p = new Phonon(1);

			// To set position of x and y
			p.SetCoords(2,3);
			//test posion of x and y 
			Assert.AreEqual(2,p.Position.X);
			Assert.AreEqual(3,p.Position.Y);

			// To set direction of DX and DY
			p.SetDirection(3, 4);
			// To test direction of DX and DY
			Assert.AreEqual(3, p.Direction.DX);
			Assert.AreEqual(4, p.Direction.DY);
			
			//To set speed and test it
			p.SetSpeed(100);
			Assert.AreEqual(100, p.Speed);

			//To set drift time 5
			p.Drift(5);
			// position.X += (direction.DX * Speed * time) = 2+3*100*5 = 1502
			//position.Y += (direction.DY * Speed * time)  = 3+4*100*5 = 2003
			Assert.AreEqual(1502,p.Position.X);
			Assert.AreEqual(2003, p.Position.Y);



		}
	}



	[TestClass]
	public class PointTests
	{
		[TestMethod]
		public void TestConstructor()
		{
			//to test cordinates of the point 
			Point p1 = new Point();
			Point p2 = new Point(1, 1);
			Assert.AreEqual(0, p1.X);
			Assert.AreEqual(0, p1.Y);
			Assert.AreEqual(1, p2.X);
			Assert.AreEqual(1, p2.Y);
		}
		[TestMethod]
		public void TestSetAndGet()
		{
			// to test of set and get coordinates with and without null to the point 
			Point p1 = new Point();
			p1.SetCoords(1, 1);
			p1.GetCoords(out double x, out double y);
			Assert.AreEqual(1, x);
			Assert.AreEqual(1, y);
			p1.SetCoords(null, 2);
			p1.GetCoords(out x, out y);
			Assert.AreEqual(1, x);
			Assert.AreEqual(2, y);
			p1.SetCoords(2, null);
			p1.GetCoords(out x, out y);
			Assert.AreEqual(2, x);
			Assert.AreEqual(2, y);
		}
	}
	[TestClass]
	public class VectorTests
	{
		[TestMethod]
		public void TestConstructor()
		{
			// to tset vextor 
			Vector v1 = new Vector(1, -1);
			Assert.AreEqual(1, v1.DX);
			Assert.AreEqual(-1, v1.DY);
			// to test exception
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Vector(-10, 10));
		}
		[TestMethod]
		public void TestSet()
		{
			//to test exception and set coordinates
			Vector v1 = new Vector();
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => v1.Set(-1.001, 1.001));
			v1.Set(-1, 1);
			Assert.AreEqual(-1, v1.DX);
			Assert.AreEqual(1, v1.DY);
		}
	}
	[TestClass]
	public class RectangleTests
	{
		[TestMethod]
		public void TestRectangle()
		{
			// to test rectangle lenght , width and area
			Rectangle r = new Rectangle(2, 3);
			Assert.AreEqual(2, r.Length);
			Assert.AreEqual(3, r.Width);
			Assert.AreEqual(6, r.Area);
		}
	}
}


