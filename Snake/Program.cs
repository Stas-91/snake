using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(1, 2, '*');
			p1.Draw();

			Point p2 = new Point(4, 5, '#');
			p2.Draw();

			HorizontallLine line = new HorizontallLine(5, 10, 8, '+');
			line.Drow();

			VerticalLine vLine = new VerticalLine(5, 8, 16, '+');
			vLine.Drow();

			Console.ReadLine();
		}

		
	}
}
