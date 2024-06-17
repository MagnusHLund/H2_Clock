using H2_Clock.Controllers;
using H2_Clock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Clock.Models.Characters
{
	internal class Six : ICharacter
	{
		private DrawController _drawController;

		internal Six(DrawController drawController)
		{
			_drawController = drawController;
		}

		public void DrawCharacter(int characterIndex)
		{
			_drawController.DrawTop(characterIndex);
			_drawController.DrawTopLeft(characterIndex);
			_drawController.DrawBottomLeft(characterIndex);
			_drawController.DrawBottomRight(characterIndex);
			_drawController.DrawBottom(characterIndex);
			_drawController.DrawMiddle(characterIndex);
		}
	}
}
