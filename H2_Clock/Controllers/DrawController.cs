using System;
using H2_Clock.Views;

namespace H2_Clock.Controllers
{
	internal class DrawController
	{
		private const int _characterSpace = 10;
		private const int _segmentHeight = 7;
		private const int _segmentWidth = 7;
		private const int _spaceForBottomSegments = 1;

		private View _view;

		internal DrawController(View view) 
		{
			_view = view;
		}

		internal void DrawTop(int characterPosition)
		{
			for(int i = 1; i < _segmentWidth; i++)
			{
				int x = _characterSpace * characterPosition + i;
				int y = _characterSpace - 1;

				_view.CreateSquares(x, y);
			}
		}

		internal void DrawBottom(int characterPosition) 
		{
			for (int i = 1; i < _segmentWidth; i++)
			{
				int x = _characterSpace * characterPosition + i;
				int y = _characterSpace + (_segmentHeight * 2) + _spaceForBottomSegments;

				_view.CreateSquares(x, y);
			}
		}

		internal void DrawBottomLeft(int characterPosition)
		{
			for (int i = 0; i < _segmentHeight; i++)
			{
				int x = _characterSpace * characterPosition;
				int y = _characterSpace + i + _spaceForBottomSegments + _segmentHeight;

				_view.CreateSquares(x, y);
			}
		}

		internal void DrawBottomRight(int characterPosition)
		{
			for (int i = 0; i < _segmentHeight; i++)
			{
				int x = _characterSpace * characterPosition + _segmentWidth;
				int y = _characterSpace + i + _spaceForBottomSegments + _segmentHeight;

				_view.CreateSquares(x, y);
			}
		}

		internal void DrawTopLeft(int characterPosition)
		{
			for (int i = 0; i < _segmentHeight; i++)
			{
				int x = _characterSpace * characterPosition;
				int y = _characterSpace + i;

				_view.CreateSquares(x, y);
			}
		}

		internal void DrawTopRight(int characterPosition)
		{
			for (int i = 0; i < _segmentHeight; i++)
			{
				int x = _characterSpace * characterPosition + _segmentHeight;
				int y = _characterSpace + i;

				_view.CreateSquares(x, y);
			}
		}

		internal void DrawMiddle(int characterPosition)
		{
			for (int i = 1; i < _segmentWidth; i++)
			{
				int x = _characterSpace * characterPosition + i;
				int y = _characterSpace + _segmentHeight;

				_view.CreateSquares(x, y);
			}
		}

		internal void DrawColon(int characterPosition)
		{
			int x1 = characterPosition * _characterSpace + _characterSpace / 2  ;
			int y1 = _segmentHeight + _characterSpace / 2 ;

			_view.CreateSquares(x1, y1);

			int x2 = characterPosition * _characterSpace + _characterSpace / 2;
			int y2 = y1 + _segmentHeight;

			_view.CreateSquares(x2, y2);
		}
	}
}
