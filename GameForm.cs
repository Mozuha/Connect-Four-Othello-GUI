/*
 * Oct 19, 2020
 * Mizuki Hashimoto
 * 
 * This is the main class of Connect Four Othello GUI. 
 * Its role is to handle events (receive event and call controller event). 
 * 
 * [Updates] (Oct 19, 2020)
 * Added two timer widgets. One for update current date and time. 
 * Another for update time remaining for a turn.
 */


using System;
using System.Windows.Forms;

namespace ConnectFourOthelloGUI {
  public partial class GameForm : Form {
    Controller ctrl = null;

    public GameForm() {
      InitializeComponent();
      ctrl = new Controller(mainMenuPnl, gridSizeSelectPnl, enterRCDirectlyPnl, enterRCFilePnl, restorePnl, gamePnl,
        dropPosSelectPnl, resultPnl, rowNUD, colNUD, dropPosNUD, gridSizeFileTbx, restoreFileTbx, saveFileTbx,
        gridRTxb, gridSizeFileNameErrorLbl, restoreFileNameErrorLbl, dropPosPromptLbl, dropPosFullErrorLbl, turnLbl,
        turnNumLbl, turnTimerLbl, resultStatusLbl, saveFileNameErrorLbl, currTimeLbl, turnTimer, currTimer, openFileDialog1);
    }

    /*********************************************************************
     * mainMenuPnl
     *********************************************************************/

    // "Start a new game" button clicked. Show grid size select panel.
    private void newGameBtn_Click(object sender, EventArgs e) {
      ctrl.newGameBtnEvent();
    }

    // "Restore the previous state of the game" button clicked. Show choose restore file panel.
    private void restoreBtn_Click(object sender, EventArgs e) {
      ctrl.restoreBtnEvent();
    }


    /*********************************************************************
     * gridSizeSelectPnl
     *********************************************************************/

    // "Directly enter number of grid rows and columns" button clicked. Show enter grid size panel.
    private void enterRCDirectlyBtn_Click(object sender, EventArgs e) {
      ctrl.enterRCDirectlyBtnEvent();
    }

    // "Choose input file" button clicked. Show choose input file panel.
    private void enterRCFileBtn_Click(object sender, EventArgs e) {
      ctrl.enterRCFileBtnEvent();
    }

    // "Default" button clicked. Start new game. Show game panel.
    private void enterRCDefaultBtn_Click(object sender, EventArgs e) {
      ctrl.enterRCDefaultBtnEvent();
    }

    // "Back" button clicked. Back to main menu. Show main panel.
    private void back2MainFromGSSBtn_Click(object sender, EventArgs e) {
      ctrl.back2MainFromGSSBtnEvent();
    }


    /*********************************************************************
     * enterRCDirectlyPnl
     *********************************************************************/

    // "Start game" button clicked. Start new game. Show game panel.
    private void startGameFromDBtn_Click(object sender, EventArgs e) {
      ctrl.startGameFromDBtnEvent();
    }

    // "Back" button clicked. Back to grid size select panel. Show grid size select panel.
    private void back2GSSFromDBtn_Click(object sender, EventArgs e) {
      ctrl.back2GSSFromDBtnEvent();
    }


    /*********************************************************************
     * enterRCFilePnl
     *********************************************************************/

    // "Browse" button clicked. Open dialog box and let user choose a file that contains grid size info.
    private void gridSizeFileBrowseBtn_Click(object sender, EventArgs e) {
      ctrl.gridSizeFileBrowseBtnEvent();
    }

    // "Start game" button clicked. Start new game. Show game panel.
    private void startGameFromFBtn_Click(object sender, EventArgs e) {
      ctrl.startGameFromFBtnEvent();
    }

    // "Back" button clicked. Back to grid size select panel. Show grid size select panel.
    private void back2GSSFromFBtn_Click(object sender, EventArgs e) {
      ctrl.back2GSSFromFBtnEvent();
    }


    /*********************************************************************
     * restorePnl
     *********************************************************************/

    // "Browse" button clicked. Open dialog box and let user choose a file that contains the previous state.
    private void restoreFileBrowseBtn_Click(object sender, EventArgs e) {
      ctrl.restoreFileBrowseBtnEvent();
    }

    // "Start game" button clicked. Start game from the previous state. Show game panel.
    private void startGameFromRBtn_Click(object sender, EventArgs e) {
      ctrl.startGameFromRBtnEvent();
    }

    // "Back" button clicked. Back to main menu. Show main panel.
    private void back2MainFromRBtn_Click(object sender, EventArgs e) {
      ctrl.back2MainFromRBtnEvent();
    }


    /*********************************************************************
     * gamePnl
     *********************************************************************/

    // "Drop" button clicked. Update grid and turn. Show result panel if game ends.
    private void dropPosBtn_Click(object sender, EventArgs e) {
      ctrl.dropPosBtnEvent();
    }

    // "Browse" button clicked. Open dialog box and let user choose a file to store the game state.
    private void saveFileBrowseBtn_Click(object sender, EventArgs e) {
      ctrl.saveFileBrowseBtnEvent();
    }

    // "Save and Exit" button clicked. Save the game state into file and go back to main menu. Show main panel.
    private void saveExitBtn_Click(object sender, EventArgs e) {
      ctrl.saveExitBtnEvent();
    }

    // "Yes" button clicked. Reset grid and turn.
    private void yesBtn_Click(object sender, EventArgs e) {
      ctrl.yesBtnEvent();
    }

    // "No" button clicked. Go to main menu. Show main panel.
    private void noBtn_Click(object sender, EventArgs e) {
      ctrl.noBtnEvent();
    }

    // currTimer ticked. Update current date and time.
    private void currTimer_Tick(object sender, EventArgs e) {
      ctrl.currTimer_Tick();
    }

    // turnTimer ticked. Update time remaining for that turn.
    private void turnTimer_Tick(object sender, EventArgs e) {
      ctrl.turnTimer_Tick();
    }
  }
}
