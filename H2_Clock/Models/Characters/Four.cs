using H2_Clock.Controllers;
using H2_Clock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Clock.Models.Characters
{
	internal class Four : ICharacter
	{
		private DrawController _drawController;

		internal Four(DrawController drawController)
		{
			_drawController = drawController;
		}

		public void DrawCharacter(int characterIndex)
		{
			_drawController.DrawTopLeft(characterIndex);
			_drawController.DrawTopRight(characterIndex);
			_drawController.DrawBottomRight(characterIndex);
			_drawController.DrawMiddle(characterIndex);
		}
	}
}
