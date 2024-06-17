using H2_Clock.Controllers;
using H2_Clock.Interfaces;

namespace H2_Clock.Models.Characters
{
	internal class Colon : ICharacter
	{
		private DrawController _drawController;

		internal Colon(DrawController drawController)
		{
			_drawController = drawController;
		}

		public void DrawCharacter(int characterIndex)
		{
			_drawController.DrawColon(characterIndex);
		}
	}
}
