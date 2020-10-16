/*
 * Oct 16, 2020
 * Mizuki Hashimoto
 * 
 * This is a class of drawing to get the state of grid and draw a grid.
 * Instead of printing directly as in console app, it now returns the grid drawing
 * as the two-dimensional array of string so the controller class can receive it and 
 * pass it to the Form widget.
 * This class work as a view class.
 */

using System;

namespace ConnectFourOthelloGUI {
	[Serializable]
  public class Drawing {
		public string[,] GetDrawing(Grid grid) {
			grid.GetGridSize(out int row, out int col);
			string[,] draw = new string[row, col];
			for (int i = 0; i < row; i++) {
				for (int j = 0; j < col; j++) {
					draw[i, j] = grid[i, j].Symbol.ToString();
					//Console.Write(grid[i, j].Symbol + " ");
					//if (j == col - 1) Console.WriteLine();
				}
			}

			return draw;
		}
	}
}