using System;
using Lab1_Geometry2D.Geometry2D;

namespace Lab1_Geometry2D.Particles
{
	public abstract class Particle
	{
		private Point position = new Point();
		private Vector direction = new Vector();
		public double Speed { get; protected set; }
		
		//To get and set position value of x and y
		public Point Position
		{
			get => new Point(position.X, position.Y);
			set => position = value;
		}

		//To get and set direction value of x and y
		public Vector Direction
		{
			get => new Vector(direction.DX, direction.DY);
			set => direction = value;
		}

		/// <summary>
		/// The default constructor sets the particle position and direction vector to (0,0)
		/// and the speed to 0.
		/// </summary>
		public Particle()
		{
			
		}
		//For particle position, direction and speed
		public Particle(Point position, Vector direction, double speed)
		{
			Position = position;
			Direction = direction;
			Speed = speed;
		}
		
		//Copy constructor
		public Particle(Particle p)
		{
			Position = p.Position;
			Direction = p.Direction;
			Speed = p.Speed;
		}
		/// <summary>
		/// Sets the particle's position in 2D space
		/// </summary>
		/// <param name="px">The x coordinate</param>
		/// <param name="py">The y coordinate</param>
		public void SetSpeed(double speed)
		{
			Speed = speed;

			throw new NotImplementedException();
		}
		public void SetCoords(double? px, double? py)
		{
			position.SetCoords(px,py);

			throw new NotImplementedException();	
		}
		/// <summary>
		/// Get the x and y position coordinates of the particle
		/// </summary>
		/// <param name="px">The x coordinate</param>
		/// <param name="py">The y coordinate</param>
		public void GetCoords( double px, double py)
		{
			position.GetCoords(out px,out py);
			throw new NotImplementedException();	
		}
		/// <summary>
		/// Sets the particle's direction vector
		/// </summary>
		/// <param name="dx">The x component of the direction vector</param>
		/// <param name="dy">The y component of the direction vector</param>
		/// <exception cref="ArgumentOutOfRangeException">Throws if the x or y component is > 1 or < -1."</exception>
		public void SetDirection(double dx = 0, double dy = 0)
		{
			
			bool InRange(double x) => x > 1 && x < -1;

			if (InRange(dx) && InRange(dy))
			{
				direction.Set(dx, dy);
			}
			else
			{
				throw new ArgumentOutOfRangeException("Direction components must be in the range [-1, 1]");
			}
		}
		/// <summary>
		/// Get the x and y components of the particle direction vector
		/// </summary>
		/// <param name="dx">The x coordinate</param>
		/// <param name="dy">The y coordinate</param>
		public void GetDirection(out double dx, out double dy)
		{
			direction.Get(out dx,out dy);
			throw new NotImplementedException();
		}
		/// <summary>
		/// Drifts (moves) the particle in space
		/// </summary>
		/// <param name="time">The amount of time the particle drifts</param>
		public void Drift(double time)
		{
			position.GetCoords(out double DX, out double DY);
			GetDirection(out double dx, out double dy);

			position.X += (direction.DX * Speed * time);

			position.Y += (direction.DY * Speed * time);

			position.SetCoords(dx, dy);


			throw new NotImplementedException();
		}
		/// <summary>
		/// Gives the particle a random direction vector
		/// </summary>
		/// <param name="r1">A random number  in the interval [0,1]</param>
		
		public void SetRandomDirection(double r1, double r2)
		{
			double dx = 2 * r1 - 1;
			double dy = Math.Sqrt(1 - dx * dx) * Math.Cos(2 * Math.PI * r2);
			direction.Set(dx, dy);
		}
		public abstract void Update(double frequency, double speed, Polarization pol);
		public override string ToString()
		{
			return $"Position: {Position}\n" +
				   $"Direction: {Direction}\n" +
				   $"Speed: {Speed}\n";
		}
	}
}
