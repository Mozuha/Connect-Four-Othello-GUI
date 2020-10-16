/*
 * Oct 16, 2020
 * Mizuki Hashimoto
 * 
 * This is the controller class of Connect Four Othello GUI. 
 * Its role is to receive call from the main class and control Form widgets appropriately.
 * Get user entered value and pass it to the grid class; get the grid state; handle exceptions and
 * validate user input; get the drawing of the grid and print it to Form widget.
 */

/* Panel hierarchy
mainMenuPnl
-> gridSizeSelectPnl
  -> enterRCDirectlyPnl
  -> enterRCFilePnl
-> restorePnl
-> gamePnl
  -> dropPosSelectPnl
  -> resultPnl
*/

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ConnectFourOthelloGUI {
	public class Controller {
		// State names and statechart state variables
		private enum States { MainMenu, GridSizeSelect, Restore, EnterRCD, EnterRCF, StartGame, Play, Result, FileBrowse, NULL };
		private States TopLevelState = States.NULL;

		// Event names for the purpose of detecting the caller event
		private enum Events { newGameBtnEvent, restoreBtnEvent, enterRCDirectlyBtnEvent, enterRCFileBtnEvent, enterRCDefaultBtnEvent,
			back2MainFromGSSBtnEvent, startGameFromDBtnEvent, back2GSSFromDBtnEvent, gridSizeFileBrowseBtnEvent, startGameFromFBtnEvent,
			back2GSSFromFBtnEvent, restoreFileBrowseBtnEvent, startGameFromRBtnEvent, back2MainFromRBtnEvent, dropPosBtnEvent,
			saveFileBrowseBtnEvent, saveExitBtnEvent, yesBtnEvent, noBtnEvent, NULL };

		// Model interface elements
		Grid grid = null;
		Drawing drawing = new Drawing();

		// GUI elements we want to control
		private Panel mainMenuPnl = null;
		private Panel gridSizeSelectPnl = null;
		private Panel enterRCDirectlyPnl = null;
		private Panel enterRCFilePnl = null;
		private Panel restorePnl = null;
		private Panel gamePnl = null;
		private Panel dropPosSelectPnl = null;
		private Panel resultPnl = null;
		private NumericUpDown rowNUD = null;
		private NumericUpDown colNUD = null;
		private TextBox gridSizeFileTbx = null;
		private Label gridSizeFileNameErrorLbl = null;
		private OpenFileDialog openFileDialog1 = null;
		private TextBox restoreFileTbx = null;
		private Label restoreFileNameErrorLbl = null;
		private Label dropPosPromptLbl = null;
		private NumericUpDown dropPosNUD = null;
		private Label dropPosFullErrorLbl = null;
		private RichTextBox gridRTxb = null;
		private Label turnLbl = null;
		private Label turnNumLbl = null;
		private Label resultStatusLbl = null;
		private TextBox saveFileTbx = null;
		private Label saveFileNameErrorLbl = null;

		// Default constructor to grab GUI widgets to control
		public Controller(Panel mm, Panel gss, Panel ercd, Panel ercf, Panel rst, 
			Panel gm, Panel dps, Panel rslt, NumericUpDown rn, NumericUpDown cn,
			NumericUpDown dp, TextBox gsf, TextBox rstf, TextBox sf, RichTextBox gdt, Label gsfne,
			Label rfne, Label dpp, Label dpfe, Label t, Label tn, Label rs, Label sfne, OpenFileDialog ofd) {
			mainMenuPnl = mm;
			gridSizeSelectPnl = gss;
			enterRCDirectlyPnl = ercd;
			enterRCFilePnl = ercf;
			restorePnl = rst;
			gamePnl = gm;
			dropPosSelectPnl = dps;
			resultPnl = rslt;
			rowNUD = rn;
			colNUD = cn;
			dropPosNUD = dp;
			gridSizeFileTbx = gsf;
			restoreFileTbx = rstf;
			saveFileTbx = sf;
			gridRTxb = gdt;
			gridSizeFileNameErrorLbl = gsfne;
			restoreFileNameErrorLbl = rfne;
			dropPosPromptLbl = dpp;
			dropPosFullErrorLbl = dpfe;
			turnLbl = t;
			turnNumLbl = tn;
			resultStatusLbl = rs;
			saveFileNameErrorLbl = sfne;
			openFileDialog1 = ofd;

			// enter initial state
			GoMainMenuState(States.NULL, Events.NULL);
    }


		/*********************************************************************
     * S T A T E S
     *********************************************************************/
		private void GoMainMenuState(States prevState, Events evt) {
			TopLevelState = States.MainMenu;

			if (prevState == States.NULL || prevState == States.StartGame 
				|| prevState == States.Play || prevState == States.Result) {

				mainMenuPnl.Visible = true;
				gridSizeSelectPnl.Visible = false;
				enterRCDirectlyPnl.Visible = false;
				enterRCFilePnl.Visible = false;
				restorePnl.Visible = false;
				gamePnl.Visible = false;

				// if came from saveExitBtnEvent, try to save game state into chosen file
				if ((prevState == States.StartGame || prevState == States.Play
					|| prevState == States.Result) && evt == Events.saveExitBtnEvent) {

					string fileName = saveFileTbx.Text;

					// save game state into file if xml file is chosen
					if (fileName.Contains(".xml")) {
						Serialize(grid, fileName);
						resultPnl.Visible = false;
						dropPosSelectPnl.Visible = true;
						saveFileNameErrorLbl.Visible = false;
						turnNumLbl.Text = "1 (O)";
						gridRTxb.Clear();
						saveFileTbx.Clear();
					}

					// otherwise show error instead of show mainMenuPnl
					else {
						saveFileNameErrorLbl.Visible = true;
						if (prevState == States.StartGame || prevState == States.Play) GoStartGameState(States.MainMenu);
						else if (prevState == States.Result) GoResultState();
					}
				}

				// if came from noBtnEvent, reset gamePnl components
				else if ((prevState == States.StartGame || prevState == States.Play
					|| prevState == States.Result) && evt == Events.noBtnEvent) {

					resultPnl.Visible = false;
					dropPosSelectPnl.Visible = true;
					saveFileNameErrorLbl.Visible = false;
					turnNumLbl.Text = "1 (O)";
					gridRTxb.Clear();
					grid = null;
				}
			}

			// come back to mainmenuPnl from gridSizeSelectPnl or restorePnl
			else if (prevState == States.GridSizeSelect || prevState == States.Restore) {
				gridSizeSelectPnl.Visible = false;
				restorePnl.Visible = false;
				gamePnl.Visible = false;
				restoreFileNameErrorLbl.Visible = false;
			}
		}

		private void GoGridSizeSelectState(States prevState) {
			TopLevelState = States.GridSizeSelect;

			if (prevState == States.MainMenu) {
				restorePnl.Visible = false;
				gamePnl.Visible = false;
				gridSizeSelectPnl.Visible = true;
      }

			// come back to gridSizeSelectStatePnl from enterRCDirectlyPnl or enterRCFilePnl
			else if (prevState == States.EnterRCD || prevState == States.EnterRCF) {
				enterRCDirectlyPnl.Visible = false;
				enterRCFilePnl.Visible = false;
				gridSizeFileNameErrorLbl.Visible = false;
			}
		}

		private void GoEnterRCDState() {
			TopLevelState = States.EnterRCD;

			enterRCFilePnl.Visible = false;
			enterRCDirectlyPnl.Visible = true;
		}

		private void GoEnterRCFState() {
			TopLevelState = States.EnterRCF;

			enterRCDirectlyPnl.Visible = false;
			enterRCFilePnl.Visible = true;
		}

		private void GoRestoreState() {
			TopLevelState = States.Restore;

			gamePnl.Visible = false;
			restorePnl.Visible = true;
		}

		private void GoStartGameState(States prevState) {
			TopLevelState = States.StartGame;

			turnLbl.Text = "Turn: ";

			if (prevState == States.EnterRCD || prevState == States.EnterRCF || prevState == States.GridSizeSelect 
				|| prevState == States.Restore || prevState == States.MainMenu) {

				bool fileNameError = false;
				int row = 0, col = 0;

				// saveFileNameError occured at StartGameState and came back; make sure grid size remains the same as before error occured
				if (prevState == States.MainMenu) grid.GetGridSize(out row, out col);

				// start new game with grid of size that directly entered
				if (prevState == States.EnterRCD) {
					row = (int)rowNUD.Value;
					col = (int)colNUD.Value;
					grid = new Grid(row, col);  // create grid with the size entered
				}

				// start new game with grid of size that read from file
				else if (prevState == States.EnterRCF) {
					string fileName = gridSizeFileTbx.Text;

					if (fileName.Contains(".csv")) {
						var tuple = LoadCSV(fileName);
						row = tuple.Item1; 
						col = tuple.Item2;

						// value is less than expected minimum
						if (row < 6 || col < 4) {
							fileNameError = true;
							gridSizeFileNameErrorLbl.Text = "Something went wrong. Please choose other file.";
							gridSizeFileNameErrorLbl.Visible = true;
							GoEnterRCFState();
						}

						else grid = new Grid(row, col);  // create grid with the size read from file
					}

					else if (fileName.Contains(".xml")) {
						var tuple = LoadXML(fileName);
						row = tuple.Item1;
						col = tuple.Item2;

						// value is less than expected minimum
						if (row < 6 || col < 4) {
							fileNameError = true;
							gridSizeFileNameErrorLbl.Text = "Something went wrong. Please choose other file.";
							gridSizeFileNameErrorLbl.Visible = true;
							GoEnterRCFState();
						}

						else grid = new Grid(row, col);  // create grid with the size read from file
					}

					// empty or invalid filename; show error instead of show gamePnl
					else {  
						fileNameError = true;
						gridSizeFileNameErrorLbl.Visible = true;
						GoEnterRCFState();
          }
				}

				// start new game with default size grid
				else if (prevState == States.GridSizeSelect) {
					row = 6;
					col = 4;
					grid = new Grid();  // create 6*4 grid (default)
				}

				// start game from previous state read from file
				else if (prevState == States.Restore) {
					string fileName = restoreFileTbx.Text;

					if (fileName.Contains(".xml")) {
						Deserialize(ref grid, fileName);

						if (grid == null) {
							fileNameError = true;
							restoreFileNameErrorLbl.Text = "Something went wrong. Please choose other file.";
							restoreFileNameErrorLbl.Visible = true;
							GoRestoreState();
						}

						else grid.GetGridSize(out row, out col);
					}

					// empty or invalid filename; show error instead of show gamePnl
					else {
						fileNameError = true;
						restoreFileNameErrorLbl.Visible = true;
						GoRestoreState();
          }
				}

				// if no error occured, set gamePnl components appropriately and show gamePnl
				if (!fileNameError) {
					gridSizeFileTbx.Clear();
					restoreFileTbx.Clear();
					gridSizeSelectPnl.Visible = false;
					restorePnl.Visible = false;
					gamePnl.Visible = true;
					dropPosPromptLbl.Text = $"Where to drop? (0-{ col - 1 })";  // set drop pos prompt max
					dropPosNUD.Maximum = col - 1;  // set drop pos input max
					UpdateGameDisplay(grid, Events.startGameFromDBtnEvent);  // actually, any of D, F, and R is fine

					if (grid.Result != "unfinished") GoResultState();  // restored game is finished; show result
				}
			}
		}

		private void GoPlayState(States prevState) {
			TopLevelState = States.Play;

			saveFileNameErrorLbl.Visible = false;

			if (prevState == States.StartGame || prevState == States.Play) {
				dropPosFullErrorLbl.Visible = false;

				int position = (int)dropPosNUD.Value;  // column where disc will be dropped
				int top = grid.CheckStack(position);  // row where disc will be dropped

				if (top != -1) {  // the column has space for additional disc to be dropped
					// red turn
					if (grid.CurrentTurn % 2 == 1) {
						RedDisc red = new RedDisc();
						grid.PutDisc(top, position, red);  // put a disc on grid and flip as needed
						UpdateGameDisplay(grid, Events.dropPosBtnEvent);  // update grid drawing and turn number
						grid.CurrentTurn++;  // increment turn number
						if (grid.Check(red)) GoResultState();  // check whether four red sequence exists, if yes, then finish the game and show result
					}

					// yellow turn
					else {
						YellowDisc yellow = new YellowDisc();
						grid.PutDisc(top, position, yellow);  // put a disc on grid and flip as needed
						UpdateGameDisplay(grid, Events.dropPosBtnEvent);  // update grid drawing and turn number
						grid.CurrentTurn++;  // increment turn number
						if (grid.Check(yellow)) GoResultState();  // check whether four yellow sequence exists, if yes, then finish the game and show result
					}

					// if all squares of grid are filled without four disc sequence, then the result is draw
					if (grid.CheckDraw()) GoResultState();
				}

				else dropPosFullErrorLbl.Visible = true;  // if the column is full, show error message
			}
			
			// (play again?) -> yesBtn clicked
			else if (prevState == States.Result) {
				grid.Clear();  // clear discs in grid while grid size remains the same
				UpdateGameDisplay(grid, Events.yesBtnEvent);

				turnLbl.Text = "Turn: ";
				resultPnl.Visible = false;
				dropPosSelectPnl.Visible = true;
      }
    }

		private void GoResultState() {
			TopLevelState = States.Result;

			gridSizeSelectPnl.Visible = false;
			restorePnl.Visible = false;
			gamePnl.Visible = true;
			dropPosSelectPnl.Visible = false;
			resultPnl.Visible = true;

			// change "Turn: 1 (o)" label to "Took 1 turns"
			turnLbl.Text = "Took ";
			turnNumLbl.Text = $"{ grid.CurrentTurn - 1} turns";

			// update result info
			if (grid.Result == "O" || grid.Result == "X") resultStatusLbl.Text = $"{ grid.Result } win!";
			else resultStatusLbl.Text = grid.Result;
		}

		private void GoFileBrowseState(States prevState) {
			TopLevelState = States.FileBrowse;

			// browse file for grid size
			if (prevState == States.EnterRCF) {
				using (openFileDialog1) {
					//openFileDialog1.InitialDirectory = @"c:\";
					openFileDialog1.Filter = "xml files (*.xml)|*.xml|csv files (*.csv)|*.csv";
					openFileDialog1.FilterIndex = 2;
					openFileDialog1.RestoreDirectory = true;

					if (openFileDialog1.ShowDialog() == DialogResult.OK) {  // open dialog box
						gridSizeFileTbx.Text = openFileDialog1.FileName;  // put chosen file name into textbox
					}
				}

				gridSizeFileNameErrorLbl.Visible = false;
				gridSizeFileNameErrorLbl.Text = "Please choose an CSV or XML file";

				GoEnterRCFState();  // go back to state came from
			}

			// browse file for restore
			else if (prevState == States.Restore) {
				using (openFileDialog1) {
					//openFileDialog1.InitialDirectory = @"c:\";
					openFileDialog1.Filter = "xml files (*.xml)|*.xml";
					openFileDialog1.FilterIndex = 2;
					openFileDialog1.RestoreDirectory = true;

					if (openFileDialog1.ShowDialog() == DialogResult.OK) {  // open dialog box
						restoreFileTbx.Text = openFileDialog1.FileName;  // put chosen file name into textbox
					}
				}

				restoreFileNameErrorLbl.Visible = false;
				restoreFileNameErrorLbl.Text = "Please choose an XML file";

				GoRestoreState();  // go back to state came from
			}

			// browse file for save
			else if (prevState == States.StartGame || prevState == States.Play || prevState == States.Result) {
				using (openFileDialog1) {
					//openFileDialog1.InitialDirectory = @"c:\";
					openFileDialog1.Filter = "xml files (*.xml)|*.xml";
					openFileDialog1.FilterIndex = 2;
					openFileDialog1.RestoreDirectory = true;

					if (openFileDialog1.ShowDialog() == DialogResult.OK) {  // open dialog box
						saveFileTbx.Text = openFileDialog1.FileName;  // put chosen file name into textbox
					}
				}

				saveFileNameErrorLbl.Visible = false;

				// go back to state came from
				if (prevState == States.StartGame) GoStartGameState(States.FileBrowse);
				else if (prevState == States.Play) GoPlayState(States.FileBrowse);
				else if (prevState == States.Result) GoResultState();
			}
    }


		/*********************************************************************
     * E V E N T S
     *********************************************************************/

		/// mainMenuPnl ///
		public void newGameBtnEvent() {
			if (TopLevelState == States.MainMenu) GoGridSizeSelectState(TopLevelState);
    }

		public void restoreBtnEvent() {
			if (TopLevelState == States.MainMenu) GoRestoreState();
    }

		/// GSSPnl ///
		public void enterRCDirectlyBtnEvent() {
			if (TopLevelState == States.GridSizeSelect) GoEnterRCDState();
    }

		public void enterRCFileBtnEvent() {
			if (TopLevelState == States.GridSizeSelect) GoEnterRCFState();
    }

		public void enterRCDefaultBtnEvent() {
			if (TopLevelState == States.GridSizeSelect) GoStartGameState(TopLevelState);
    }

		public void back2MainFromGSSBtnEvent() {
			if (TopLevelState == States.GridSizeSelect) GoMainMenuState(TopLevelState, Events.back2MainFromGSSBtnEvent);
    }

		/// enterRCDirectlyPnl ///
		public void startGameFromDBtnEvent() {
			if (TopLevelState == States.EnterRCD) GoStartGameState(TopLevelState);
    }

		public void back2GSSFromDBtnEvent() {
			if (TopLevelState == States.EnterRCD) GoGridSizeSelectState(TopLevelState);
    }

		/// enterRCFilePnl ///
		public void gridSizeFileBrowseBtnEvent() {
			if (TopLevelState == States.EnterRCF) GoFileBrowseState(TopLevelState);
    }

		public void startGameFromFBtnEvent() {
			if (TopLevelState == States.EnterRCF) GoStartGameState(TopLevelState);
    }

		public void back2GSSFromFBtnEvent() {
			if (TopLevelState == States.EnterRCF) GoGridSizeSelectState(TopLevelState);
    }

		/// restorePnl ///
		public void restoreFileBrowseBtnEvent() {
			if (TopLevelState == States.Restore) GoFileBrowseState(TopLevelState);
    }

		public void startGameFromRBtnEvent() {
			if (TopLevelState == States.Restore) GoStartGameState(TopLevelState);
    }

		public void back2MainFromRBtnEvent() {
			if (TopLevelState == States.Restore) GoMainMenuState(TopLevelState, Events.back2MainFromRBtnEvent);
    }

		/// gamePnl ///
		public void dropPosBtnEvent() {
			if (TopLevelState == States.StartGame || TopLevelState == States.Play) GoPlayState(TopLevelState);
    }

		public void saveFileBrowseBtnEvent() {
			if (TopLevelState == States.StartGame || TopLevelState == States.Play
				|| TopLevelState == States.Result) GoFileBrowseState(TopLevelState);
    }

		public void saveExitBtnEvent() {
			if (TopLevelState == States.StartGame || TopLevelState == States.Play
				|| TopLevelState == States.Result) GoMainMenuState(TopLevelState, Events.saveExitBtnEvent);
    }

		public void yesBtnEvent() {
			if (TopLevelState == States.Result) GoPlayState(TopLevelState);
    }

		public void noBtnEvent() {
			if (TopLevelState == States.Result) GoMainMenuState(TopLevelState, Events.noBtnEvent);
    }


		/*********************************************************************
     * N O N - E V E N T   F U N C T I O N S
     *********************************************************************/

		// update grid drawing and turn number
		private void UpdateGameDisplay(Grid grid, Events evt) {
			gridRTxb.Clear();

			// draw grid
			grid.GetGridSize(out int row, out int col);
			string[,] d = drawing.GetDrawing(grid);
			for (int i = 0; i < row; i++) {
				for (int j = 0; j < col; j++) {
					gridRTxb.Text += d[i, j] + " ";
					if (j == col - 1) gridRTxb.Text += "\n";
        }
      }

			// update turn number
			if (evt == Events.yesBtnEvent || evt == Events.startGameFromDBtnEvent) {
				if (grid.CurrentTurn % 2 == 1) turnNumLbl.Text = $"{ grid.CurrentTurn } (O)";
				else turnNumLbl.Text = $"{ grid.CurrentTurn } (X)";
			}
			else {
				if (grid.CurrentTurn % 2 == 1) turnNumLbl.Text = $"{ grid.CurrentTurn + 1 } (X)";
				else turnNumLbl.Text = $"{ grid.CurrentTurn + 1 } (O)";
      }
    }
		
		
		// try to int-lize and handle error
		private int ParseInput(string input) {
			try {
				return int.Parse(input);
			}
			catch (Exception) {
				return -1;
			}
		}

		// load csv file and get the number of grid rows and columns
		private (int, int) LoadCSV(string fileName) {
			int row = 0, col = 0;
			StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("UTF-8"));

			try {
				string[] infos = reader.ReadLine().Split(',');  // get numbers separated by comma
				row = ParseInput(infos[0]);
				col = ParseInput(infos[1]);
			}
			catch (Exception e) {
				// pop error messagebox
				MessageBox.Show(e.Message, "Load CSV Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
				row = 0; col = 0;
			}
			finally {
				reader.Close();
			}

			return (row, col);
		}

		// load xml file and get the number of grid rows and columns
		private (int, int) LoadXML(string fileName) {
			int row = 0, col = 0;

			try {
				XElement xml = XElement.Load(fileName);
				row = ParseInput(xml.Element("Row").Value);  // get <Row> element
				col = ParseInput(xml.Element("Column").Value);  // get <Column> element
			}
			catch (XmlException e) {
				// pop error messagebox
				MessageBox.Show(e.Message, "Load XML Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception e) {
				// pop error messagebox
				MessageBox.Show(e.Message, "Load XML Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return (row, col);
		}

		// serialize the grid object and store it into the user specified file
		private void Serialize(Grid grid, string fileName) {
			Stream saveFileStream = File.Create(fileName);
			SoapFormatter serializer = new SoapFormatter();

			try {
				serializer.Serialize(saveFileStream, grid);
			}
			catch (SerializationException e) {
				// pop error messagebox
				MessageBox.Show(e.Message, "Serialize Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception e) {
				// pop error messagebox
				MessageBox.Show(e.Message, "Serialize Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally {
				saveFileStream.Close();
			}
		}

		// deserialize the grid object from the user specified file
		private void Deserialize(ref Grid grid, string fileName) {
			Stream loadFileStream = File.OpenRead(fileName);
			SoapFormatter deserializer = new SoapFormatter();

			try {
				grid = (Grid)(deserializer.Deserialize(loadFileStream));
			}
			catch (SerializationException e) {
				// pop error messagebox
				MessageBox.Show(e.Message, "Deserialize Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception e) {
				// pop error messagebox
				MessageBox.Show(e.Message, "Deserialize Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally {
				loadFileStream.Close();
			}
		}
	}
}