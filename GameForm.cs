/*
 * Sep 29, 2020
 * Mizuki Hashimoto
 * 
 * This is the prototype of Connect Four Othello GUI. It only contains the panel flow and 
 * actual game functionalities are not implemented yet.
 * Please ignore the comment out-ed codes. Those are the progress of the game implementation.
 */

/* Panel hierarchy
mainMenuPnl
-> gridSizeSelectPnl
  -> enterRCDirectlyPnl
  -> enterRCFilePnl
-> restorePnl
-> gamePnl
  -> gridPnl
  -> dropPosSelectPnl
  -> resultPnl
*/


using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ConnectFourOthelloGUI {
  public partial class GameForm : Form {
    //private Grid grid = null;
    //private Rectangle[] gridColumns;
    //private Graphics g = null;
    public GameForm() {
      InitializeComponent();
      //ClientSize = new Size(800, 460);  // form size upon startup
      mainMenuPnl.Visible = true;
      gridSizeSelectPnl.Visible = false;
      enterRCDirectlyPnl.Visible = false;
      enterRCFilePnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = false;
      //mainMenuPnl.Location = new Point(130, 65);
      //mainMenuPnl.Size = new Size(700, 400);
    }

    // "Start a new game" button clicked. Show grid size select panel.
    private void newGameBtn_Click(object sender, EventArgs e) {
      restorePnl.Visible = false;
      gamePnl.Visible = false;
      gridSizeSelectPnl.Visible = true;
    }

    // "Default" button clicked. Start new game. Show game panel.
    private void enterRCDefaultBtn_Click(object sender, EventArgs e) {
      //gridSizeSelectPnl.Visible = false;
      gridSizeSelectPnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = true;
      //resultPnl.Visible = true;
      //grid_Paint(6, 4);
    }

    // "Back" button clicked. Back to main menu. Show main panel.
    private void back2MainFromGSSBtn_Click(object sender, EventArgs e) {
      gridSizeSelectPnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = false;
      mainMenuPnl.Visible = true;
    }


    /*********************************************************************
     * enter grid size directly panel
     *********************************************************************/

    // "Directly enter number of grid rows and columns" button clicked. Show enter grid size panel.
    private void enterRCDirectBtn_Click(object sender, EventArgs e) {
      //gridSizeSelectPnl.Visible = false;
      enterRCFilePnl.Visible = false;
      enterRCDirectlyPnl.Visible = true;
    }

    // "Back" button clicked. Back to grid size select panel. Show grid size select panel.
    private void back2GSSFromDBtn_Click(object sender, EventArgs e) {
      enterRCDirectlyPnl.Visible = false;
      enterRCFilePnl.Visible = false;
      //gridSizeSelectPnl.Visible = true;
    }

    // "Start game" button clicked. Start new game. Show game panel.
    private void startGameFromDBtn_Click(object sender, EventArgs e) {
      gridSizeSelectPnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = true;

      /*
       * Receive the values entered. 
       * Create a grid of selected size. 
       * Start game.
       */
    }


    /*********************************************************************
     * select grid size from file panel
     *********************************************************************/

    // "Choose input file" button clicked. Show choose input file panel.
    private void enterRCFileBtn_Click(object sender, EventArgs e) {
      //gridSizeSelectPnl.Visible = false;
      enterRCDirectlyPnl.Visible = false;
      enterRCFilePnl.Visible = true;
    }

    // "Browse" button clicked. Open dialog box and let user choose a file that contains grid size info.
    private void gridSizeFileBrowseBtn_Click(object sender, EventArgs e) {
      using (openFileDialog1) {
        //openFileDialog1.InitialDirectory = @"c:\";
        openFileDialog1.Filter = "xml files (*.xml)|*.xml|csv files (*.csv)|*.csv"; 
        openFileDialog1.FilterIndex = 2;
        openFileDialog1.RestoreDirectory = true;

        if (openFileDialog1.ShowDialog() == DialogResult.OK) {  // open dialog box
          // get the path of specified file
          // var filePath = openFileDialog1.Filename;

          // read the contents of the file into a stream
          // var fileStream = openFileDialog1.OpenFile();

          /*
          using (StreamReader reader = new StreamReader(fileStream)) {
            var fileContent = reader.ReadToEnd();
          }
          */

          gridSizeFileTbx.Text = openFileDialog1.FileName;  // put chosen file name into textbox
        }
      }
    }

    // "Back" button clicked. Back to grid size select panel. Show grid size select panel.
    private void back2GSSFromFBtn_Click(object sender, EventArgs e) {
      enterRCFilePnl.Visible = false;
      enterRCFilePnl.Visible = false;
      //gridSizeSelectPnl.Visible = true;
    }

    // "Start game" button clicked. Start new game. Show game panel.
    private void startGameFromFBtn_Click(object sender, EventArgs e) {
      gridSizeSelectPnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = true;

      /*
       * Receive the values in the file selected.
       * Create a grid of selected size.
       * Start game.
       */
    }


    /*********************************************************************
     * select file contains previous state panel
     *********************************************************************/

    // "Restore the previous state of the game" button clicked. Show choose restore file panel.
    private void restoreBtn_Click(object sender, EventArgs e) {
      //mainMenuPnl.Visible = false;
      restorePnl.Visible = true;
    }

    // "Browse" button clicked. Open dialog box and let user choose a file that contains the previous state.
    private void restoreFileBrowseBtn_Click(object sender, EventArgs e) {
      using (openFileDialog1) {
        //openFileDialog1.InitialDirectory = @"c:\";
        openFileDialog1.Filter = "xml files (*.xml)|*.xml";
        openFileDialog1.FilterIndex = 2;
        openFileDialog1.RestoreDirectory = true;

        if (openFileDialog1.ShowDialog() == DialogResult.OK) {  // open dialog box
          // get the path of specified file
          // var filePath = openFileDialog1.Filename;

          // read the contents of the file into a stream
          // var fileStream = openFileDialog1.OpenFile();

          /*
          using (StreamReader reader = new StreamReader(fileStream)) {
            var fileContent = reader.ReadToEnd();
          }
          */

          restoreFileTbx.Text = openFileDialog1.FileName;  // put chosen file name into textbox
        }
      }
    }

    // "Back" button clicked. Back to main menu. Show main panel.
    private void back2MainFromRBtn_Click(object sender, EventArgs e) {
      gridSizeSelectPnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = false;
      //mainMenuPnl.Visible = true;
    }

    // "Start game" button clicked. Start game from the previous state. Show game panel.
    private void startGameFromRBtn_Click(object sender, EventArgs e) {
      gridSizeSelectPnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = true;

      /*
       * Receive the previous game state stored in the selected file.
       * Start game with the previous game state.
       */
    }


    /*********************************************************************
     * game panel
     *********************************************************************/

    // "Drop" button clicked. Update grid and turn. Show result panel if game ends.
    private void dropPosBtn_Click(object sender, EventArgs e) {
      DialogResult dr = MessageBox.Show("Drop a disc into selected position. " +
        "Appropriate drawing will be provided left. 'Turn' text will be updated." +
        "Once the game end, the result panel will appear.",
        "Drop event");
      turnNumLbl.Text = "2 (Yellow)";
      dropPosSelectPnl.Visible = false;
      resultPnl.Visible = true;

      /*
       * Receive the value entered.
       * Update grid.
       * Update grid drawing and turn number.
       * Check whether game ends. If true, show result panel with the result status.
       */
    }

    // "Save and Exit" button clicked. Save the game state into file and go back to main menu. Show main panel.
    private void saveExitBtn_Click(object sender, EventArgs e) {
      gridSizeSelectPnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = false;

      /*
       * Store the game state into selected file.
       * Show main panel.
       */
    }

    // "Browse" button clicked. Open dialog box and let user choose a file to store the game state.
    private void saveFileBrowseBtn_Click(object sender, EventArgs e) {
      using (openFileDialog1) {
        //openFileDialog1.InitialDirectory = @"c:\";
        openFileDialog1.Filter = "xml files (*.xml)|*.xml";
        openFileDialog1.FilterIndex = 2;
        openFileDialog1.RestoreDirectory = true;

        if (openFileDialog1.ShowDialog() == DialogResult.OK) {  // open dialog box
          // get the path of specified file
          // var filePath = openFileDialog1.Filename;

          // read the contents of the file into a stream
          // var fileStream = openFileDialog1.OpenFile();

          /*
          using (StreamReader reader = new StreamReader(fileStream)) {
            var fileContent = reader.ReadToEnd();
          }
          */

          saveFileTbx.Text = openFileDialog1.FileName;  // put chosen file name into textbox
        }
      }
    }

    // "Yes" button clicked. Reset grid and turn.
    private void yesBtn_Click(object sender, EventArgs e) {
      DialogResult dr = MessageBox.Show("Start new game with the same grid size. Disc drawings will be cleared.",
        "Play again yes event");
      turnNumLbl.Text = "1 (Red)";
      resultPnl.Visible = false;
      dropPosSelectPnl.Visible = true;

      /*
       * Reset grid.
       * Reset grid drawing and turn number.
       * Hide result panel.
       */
    }

    // "No" button clicked. Go to main menu. Show main panel.
    private void noBtn_Click(object sender, EventArgs e) {
      gridSizeSelectPnl.Visible = false;
      restorePnl.Visible = false;
      gamePnl.Visible = false;
    }


    //private void grid_Paint(int row, int col) {
    //  grid = new Grid(row, col);
    //  gridColumns = new Rectangle[col];
    //  g = gamePnl.CreateGraphics();
    //  g.FillRectangle(Brushes.Blue, 0, 0, gamePnl.Width - 20, gamePnl.Height - 20);
    //  for (int i = 0; i < row; i++) {
    //    for (int j = 0; j < col; j++) {
    //      if (i == 0) {
    //        gridColumns[j] = new Rectangle(32 + 48 * j, 24, 32, 300);
    //      }
    //      g.FillEllipse(Brushes.White, 16 + (gamePnl.Width/col)* j, 16 + 48 * i, (gamePnl.Width/(col+5)), 32);
    //    }
    //  }
    //}
  }
}
