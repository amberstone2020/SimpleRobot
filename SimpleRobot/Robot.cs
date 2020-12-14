using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRobot
{

	//Set direction to appropriate arrow character code
	public enum Direction : int
	{
		West = 231,
		North = 233,
		East = 232,
		South = 234
	}

	class Robot
	{
		
		public Direction direction;

		//constructor sets initial direction to North
		public Robot()
		{
			this.location = new Point();
			direction = Direction.North;
		}
		//Gets or sets the coordinates of the upper-left corner 
		//of the control relative to the upper-left corner of its container.
		public Point location { get; set; }
		public void move(int distance)
		{
			Point change = new Point();
			switch (direction)
			{
				case Direction.North:
					change.X = this.location.X;
					change.Y = this.location.Y - distance;
					break;
				case Direction.South:
					change.X = this.location.X;
					change.Y = this.location.Y + distance;
					break;
				case Direction.East:
					change.X = this.location.X + distance;
					change.Y = this.location.Y;
					break;
				case Direction.West:
					change.X = this.location.X - distance;
					change.Y = this.location.Y;
					break;
			}
			this.location = change;
		}

	public override string ToString()
	{
		return ((char)direction).ToString();
	}

		//coordinates and what to display on form label
	public string GetFormattedLocation()
	{
		string locationString = "{X=" + Convert.ToString((int)-160 + this.location.X) + ", Y= " + Convert.ToString((int)151 - this.location.Y) + "}";
		return locationString;
	}
}
}
