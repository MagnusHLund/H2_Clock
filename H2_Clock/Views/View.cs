using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Clock.Views
{
	internal class View
	{
		internal void CreateSquares(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(Convert.ToChar(9608));
		}

		internal void Clear()
		{
			Console.Clear();
		}
	}
}
