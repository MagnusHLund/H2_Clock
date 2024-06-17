using H2_Clock.Models;
using System;
using System.Threading;
using H2_Clock.Views;
using H2_Clock.Models.Characters;

namespace H2_Clock.Controllers
{
	internal class MainController
	{
		private View _view = new View();

		internal void Main()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			DateTime time = DateTime.Now;

			Clock clock = new Clock(time);

			while(true)
			{
				Thread.Sleep(1000);

				_view.Clear();
				clock.AddSecondToClock();
				DisplayDigit(clock.ToString());
			}
		}

		private void DisplayDigit(string time)
		{
			DrawController drawController = new DrawController(_view);

			int characterIndex = 0;

			foreach (char c in time)
			{
				characterIndex++;

				switch(c) 
				{
					case '0':
						new Zero(drawController).DrawCharacter(characterIndex);
						break;
					case '1':
						new One(drawController).DrawCharacter(characterIndex);
						break;
					case '2':
						new Two(drawController).DrawCharacter(characterIndex);
						break;
					case '3':
						new Three(drawController).DrawCharacter(characterIndex);
						break;
					case '4':
						new Four(drawController).DrawCharacter(characterIndex);
						break;
					case '5':
						new Five(drawController).DrawCharacter(characterIndex);
						break;
					case '6':
						new Six(drawController).DrawCharacter(characterIndex);
						break;
					case '7':
						new Seven(drawController).DrawCharacter(characterIndex);
						break;
					case '8':
						new Eight(drawController).DrawCharacter(characterIndex);
						break;
					case '9':
						new Nine(drawController).DrawCharacter(characterIndex);
						break;
					case ':':
						new Colon(drawController).DrawCharacter(characterIndex);
						break;
				}
			}
		}
	}
}
