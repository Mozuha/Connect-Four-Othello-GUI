using System;

namespace ConnectFourOthelloGUI {
  partial class GameForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.welcomePromptLbl = new System.Windows.Forms.Label();
      this.newGameBtn = new System.Windows.Forms.Button();
      this.restoreBtn = new System.Windows.Forms.Button();
      this.mainMenuPnl = new System.Windows.Forms.Panel();
      this.gridSizeSelectPnl = new System.Windows.Forms.Panel();
      this.enterRCDirectlyPnl = new System.Windows.Forms.Panel();
      this.back2GSSFromDBtn = new System.Windows.Forms.Button();
      this.startGameFromDBtn = new System.Windows.Forms.Button();
      this.colLbl = new System.Windows.Forms.Label();
      this.rowLbl = new System.Windows.Forms.Label();
      this.enterRCDirectlyPromptLbl = new System.Windows.Forms.Label();
      this.colNUD = new System.Windows.Forms.NumericUpDown();
      this.rowNUD = new System.Windows.Forms.NumericUpDown();
      this.enterRCFilePnl = new System.Windows.Forms.Panel();
      this.startGameFromFBtn = new System.Windows.Forms.Button();
      this.back2GSSFromFBtn = new System.Windows.Forms.Button();
      this.gridSizeFileBrowseBtn = new System.Windows.Forms.Button();
      this.gridSizeFileTbx = new System.Windows.Forms.TextBox();
      this.gridSizeFileNameErrorLbl = new System.Windows.Forms.Label();
      this.enterRCFilePromptLbl = new System.Windows.Forms.Label();
      this.back2MainFromGSSBtn = new System.Windows.Forms.Button();
      this.enterRCDefaultBtn = new System.Windows.Forms.Button();
      this.enterRCFileBtn = new System.Windows.Forms.Button();
      this.enterRCDirectlyBtn = new System.Windows.Forms.Button();
      this.gridSizeSelectTbx = new System.Windows.Forms.Label();
      this.restorePnl = new System.Windows.Forms.Panel();
      this.startGameFromRBtn = new System.Windows.Forms.Button();
      this.back2MainFromRBtn = new System.Windows.Forms.Button();
      this.restoreFileBrowseBtn = new System.Windows.Forms.Button();
      this.restoreFileTbx = new System.Windows.Forms.TextBox();
      this.restoreFileNameErrorLbl = new System.Windows.Forms.Label();
      this.restoreFilePromptLbl = new System.Windows.Forms.Label();
      this.gamePnl = new System.Windows.Forms.Panel();
      this.dropPosSelectPnl = new System.Windows.Forms.Panel();
      this.dropPosBtn = new System.Windows.Forms.Button();
      this.dropPosNUD = new System.Windows.Forms.NumericUpDown();
      this.dropPosPromptLbl = new System.Windows.Forms.Label();
      this.dropPosFullErrorLbl = new System.Windows.Forms.Label();
      this.turnTimerLbl = new System.Windows.Forms.Label();
      this.resultPnl = new System.Windows.Forms.Panel();
      this.noBtn = new System.Windows.Forms.Button();
      this.yesBtn = new System.Windows.Forms.Button();
      this.playAgainPromptLbl = new System.Windows.Forms.Label();
      this.resultStatusLbl = new System.Windows.Forms.Label();
      this.resultLbl = new System.Windows.Forms.Label();
      this.saveExitBtn = new System.Windows.Forms.Button();
      this.saveFilePromptLbl = new System.Windows.Forms.Label();
      this.saveFileBrowseBtn = new System.Windows.Forms.Button();
      this.saveFileTbx = new System.Windows.Forms.TextBox();
      this.saveFileNameErrorLbl = new System.Windows.Forms.Label();
      this.turnNumLbl = new System.Windows.Forms.Label();
      this.turnLbl = new System.Windows.Forms.Label();
      this.gridRTxb = new System.Windows.Forms.RichTextBox();
      this.currTimeLbl = new System.Windows.Forms.Label();
      this.turnTimer = new System.Windows.Forms.Timer(this.components);
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.currTimer = new System.Windows.Forms.Timer(this.components);
      this.mainMenuPnl.SuspendLayout();
      this.gridSizeSelectPnl.SuspendLayout();
      this.enterRCDirectlyPnl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.colNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rowNUD)).BeginInit();
      this.enterRCFilePnl.SuspendLayout();
      this.restorePnl.SuspendLayout();
      this.gamePnl.SuspendLayout();
      this.dropPosSelectPnl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dropPosNUD)).BeginInit();
      this.resultPnl.SuspendLayout();
      this.SuspendLayout();
      // 
      // welcomePromptLbl
      // 
      this.welcomePromptLbl.AutoSize = true;
      this.welcomePromptLbl.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.welcomePromptLbl.Location = new System.Drawing.Point(164, 108);
      this.welcomePromptLbl.Name = "welcomePromptLbl";
      this.welcomePromptLbl.Size = new System.Drawing.Size(484, 42);
      this.welcomePromptLbl.TabIndex = 0;
      this.welcomePromptLbl.Text = "Welcome to Connect Four Othello!";
      // 
      // newGameBtn
      // 
      this.newGameBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newGameBtn.Location = new System.Drawing.Point(226, 196);
      this.newGameBtn.Name = "newGameBtn";
      this.newGameBtn.Size = new System.Drawing.Size(350, 60);
      this.newGameBtn.TabIndex = 1;
      this.newGameBtn.Text = "Start a new game";
      this.newGameBtn.UseVisualStyleBackColor = true;
      this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
      // 
      // restoreBtn
      // 
      this.restoreBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.restoreBtn.Location = new System.Drawing.Point(226, 289);
      this.restoreBtn.Name = "restoreBtn";
      this.restoreBtn.Size = new System.Drawing.Size(350, 60);
      this.restoreBtn.TabIndex = 2;
      this.restoreBtn.Text = "Restore the previous state of the game";
      this.restoreBtn.UseVisualStyleBackColor = true;
      this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
      // 
      // mainMenuPnl
      // 
      this.mainMenuPnl.Controls.Add(this.gridSizeSelectPnl);
      this.mainMenuPnl.Controls.Add(this.restorePnl);
      this.mainMenuPnl.Controls.Add(this.gamePnl);
      this.mainMenuPnl.Controls.Add(this.welcomePromptLbl);
      this.mainMenuPnl.Controls.Add(this.restoreBtn);
      this.mainMenuPnl.Controls.Add(this.newGameBtn);
      this.mainMenuPnl.Controls.Add(this.currTimeLbl);
      this.mainMenuPnl.Location = new System.Drawing.Point(0, 0);
      this.mainMenuPnl.Name = "mainMenuPnl";
      this.mainMenuPnl.Size = new System.Drawing.Size(804, 450);
      this.mainMenuPnl.TabIndex = 3;
      // 
      // gridSizeSelectPnl
      // 
      this.gridSizeSelectPnl.Controls.Add(this.enterRCDirectlyPnl);
      this.gridSizeSelectPnl.Controls.Add(this.enterRCFilePnl);
      this.gridSizeSelectPnl.Controls.Add(this.back2MainFromGSSBtn);
      this.gridSizeSelectPnl.Controls.Add(this.enterRCDefaultBtn);
      this.gridSizeSelectPnl.Controls.Add(this.enterRCFileBtn);
      this.gridSizeSelectPnl.Controls.Add(this.enterRCDirectlyBtn);
      this.gridSizeSelectPnl.Controls.Add(this.gridSizeSelectTbx);
      this.gridSizeSelectPnl.Location = new System.Drawing.Point(0, 0);
      this.gridSizeSelectPnl.Name = "gridSizeSelectPnl";
      this.gridSizeSelectPnl.Size = new System.Drawing.Size(801, 450);
      this.gridSizeSelectPnl.TabIndex = 3;
      // 
      // enterRCDirectlyPnl
      // 
      this.enterRCDirectlyPnl.Controls.Add(this.back2GSSFromDBtn);
      this.enterRCDirectlyPnl.Controls.Add(this.startGameFromDBtn);
      this.enterRCDirectlyPnl.Controls.Add(this.colLbl);
      this.enterRCDirectlyPnl.Controls.Add(this.rowLbl);
      this.enterRCDirectlyPnl.Controls.Add(this.enterRCDirectlyPromptLbl);
      this.enterRCDirectlyPnl.Controls.Add(this.colNUD);
      this.enterRCDirectlyPnl.Controls.Add(this.rowNUD);
      this.enterRCDirectlyPnl.Location = new System.Drawing.Point(0, 0);
      this.enterRCDirectlyPnl.Name = "enterRCDirectlyPnl";
      this.enterRCDirectlyPnl.Size = new System.Drawing.Size(801, 449);
      this.enterRCDirectlyPnl.TabIndex = 5;
      // 
      // back2GSSFromDBtn
      // 
      this.back2GSSFromDBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.back2GSSFromDBtn.Location = new System.Drawing.Point(204, 331);
      this.back2GSSFromDBtn.Name = "back2GSSFromDBtn";
      this.back2GSSFromDBtn.Size = new System.Drawing.Size(75, 34);
      this.back2GSSFromDBtn.TabIndex = 6;
      this.back2GSSFromDBtn.Text = "Back";
      this.back2GSSFromDBtn.UseVisualStyleBackColor = true;
      this.back2GSSFromDBtn.Click += new System.EventHandler(this.back2GSSFromDBtn_Click);
      // 
      // startGameFromDBtn
      // 
      this.startGameFromDBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startGameFromDBtn.Location = new System.Drawing.Point(498, 331);
      this.startGameFromDBtn.Name = "startGameFromDBtn";
      this.startGameFromDBtn.Size = new System.Drawing.Size(124, 34);
      this.startGameFromDBtn.TabIndex = 5;
      this.startGameFromDBtn.Text = "Start Game";
      this.startGameFromDBtn.UseVisualStyleBackColor = true;
      this.startGameFromDBtn.Click += new System.EventHandler(this.startGameFromDBtn_Click);
      // 
      // colLbl
      // 
      this.colLbl.AutoSize = true;
      this.colLbl.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.colLbl.Location = new System.Drawing.Point(287, 273);
      this.colLbl.Name = "colLbl";
      this.colLbl.Size = new System.Drawing.Size(81, 25);
      this.colLbl.TabIndex = 4;
      this.colLbl.Text = "Column: ";
      // 
      // rowLbl
      // 
      this.rowLbl.AutoSize = true;
      this.rowLbl.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rowLbl.Location = new System.Drawing.Point(287, 229);
      this.rowLbl.Name = "rowLbl";
      this.rowLbl.Size = new System.Drawing.Size(54, 25);
      this.rowLbl.TabIndex = 3;
      this.rowLbl.Text = "Row: ";
      // 
      // enterRCDirectlyPromptLbl
      // 
      this.enterRCDirectlyPromptLbl.AutoSize = true;
      this.enterRCDirectlyPromptLbl.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.enterRCDirectlyPromptLbl.Location = new System.Drawing.Point(198, 104);
      this.enterRCDirectlyPromptLbl.Name = "enterRCDirectlyPromptLbl";
      this.enterRCDirectlyPromptLbl.Size = new System.Drawing.Size(424, 66);
      this.enterRCDirectlyPromptLbl.TabIndex = 2;
      this.enterRCDirectlyPromptLbl.Text = "Enter the number of rows and columns\r\n(Row >= 6, Col >= 4)";
      // 
      // colNUD
      // 
      this.colNUD.Location = new System.Drawing.Point(375, 273);
      this.colNUD.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.colNUD.Name = "colNUD";
      this.colNUD.Size = new System.Drawing.Size(120, 25);
      this.colNUD.TabIndex = 1;
      this.colNUD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
      // 
      // rowNUD
      // 
      this.rowNUD.Location = new System.Drawing.Point(375, 232);
      this.rowNUD.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
      this.rowNUD.Name = "rowNUD";
      this.rowNUD.Size = new System.Drawing.Size(120, 25);
      this.rowNUD.TabIndex = 0;
      this.rowNUD.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
      // 
      // enterRCFilePnl
      // 
      this.enterRCFilePnl.Controls.Add(this.startGameFromFBtn);
      this.enterRCFilePnl.Controls.Add(this.back2GSSFromFBtn);
      this.enterRCFilePnl.Controls.Add(this.gridSizeFileBrowseBtn);
      this.enterRCFilePnl.Controls.Add(this.gridSizeFileTbx);
      this.enterRCFilePnl.Controls.Add(this.gridSizeFileNameErrorLbl);
      this.enterRCFilePnl.Controls.Add(this.enterRCFilePromptLbl);
      this.enterRCFilePnl.Location = new System.Drawing.Point(0, 0);
      this.enterRCFilePnl.Name = "enterRCFilePnl";
      this.enterRCFilePnl.Size = new System.Drawing.Size(798, 449);
      this.enterRCFilePnl.TabIndex = 6;
      // 
      // startGameFromFBtn
      // 
      this.startGameFromFBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startGameFromFBtn.Location = new System.Drawing.Point(490, 303);
      this.startGameFromFBtn.Name = "startGameFromFBtn";
      this.startGameFromFBtn.Size = new System.Drawing.Size(108, 38);
      this.startGameFromFBtn.TabIndex = 4;
      this.startGameFromFBtn.Text = "Start Game";
      this.startGameFromFBtn.UseVisualStyleBackColor = true;
      this.startGameFromFBtn.Click += new System.EventHandler(this.startGameFromFBtn_Click);
      // 
      // back2GSSFromFBtn
      // 
      this.back2GSSFromFBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.back2GSSFromFBtn.Location = new System.Drawing.Point(199, 303);
      this.back2GSSFromFBtn.Name = "back2GSSFromFBtn";
      this.back2GSSFromFBtn.Size = new System.Drawing.Size(75, 38);
      this.back2GSSFromFBtn.TabIndex = 3;
      this.back2GSSFromFBtn.Text = "Back";
      this.back2GSSFromFBtn.UseVisualStyleBackColor = true;
      this.back2GSSFromFBtn.Click += new System.EventHandler(this.back2GSSFromFBtn_Click);
      // 
      // gridSizeFileBrowseBtn
      // 
      this.gridSizeFileBrowseBtn.Location = new System.Drawing.Point(523, 234);
      this.gridSizeFileBrowseBtn.Name = "gridSizeFileBrowseBtn";
      this.gridSizeFileBrowseBtn.Size = new System.Drawing.Size(85, 30);
      this.gridSizeFileBrowseBtn.TabIndex = 2;
      this.gridSizeFileBrowseBtn.Text = "Browse";
      this.gridSizeFileBrowseBtn.UseVisualStyleBackColor = true;
      this.gridSizeFileBrowseBtn.Click += new System.EventHandler(this.gridSizeFileBrowseBtn_Click);
      // 
      // gridSizeFileTbx
      // 
      this.gridSizeFileTbx.Enabled = false;
      this.gridSizeFileTbx.Location = new System.Drawing.Point(199, 232);
      this.gridSizeFileTbx.Name = "gridSizeFileTbx";
      this.gridSizeFileTbx.Size = new System.Drawing.Size(318, 25);
      this.gridSizeFileTbx.TabIndex = 1;
      // 
      // gridSizeFileNameErrorLbl
      // 
      this.gridSizeFileNameErrorLbl.ForeColor = System.Drawing.Color.Red;
      this.gridSizeFileNameErrorLbl.Location = new System.Drawing.Point(199, 265);
      this.gridSizeFileNameErrorLbl.Name = "gridSizeFileNameErrorLbl";
      this.gridSizeFileNameErrorLbl.Size = new System.Drawing.Size(450, 23);
      this.gridSizeFileNameErrorLbl.TabIndex = 5;
      this.gridSizeFileNameErrorLbl.Text = "Please choose an CSV or XML file";
      this.gridSizeFileNameErrorLbl.Visible = false;
      // 
      // enterRCFilePromptLbl
      // 
      this.enterRCFilePromptLbl.AutoSize = true;
      this.enterRCFilePromptLbl.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.enterRCFilePromptLbl.Location = new System.Drawing.Point(193, 104);
      this.enterRCFilePromptLbl.Name = "enterRCFilePromptLbl";
      this.enterRCFilePromptLbl.Size = new System.Drawing.Size(405, 66);
      this.enterRCFilePromptLbl.TabIndex = 0;
      this.enterRCFilePromptLbl.Text = "Choose XML or CSV file that contains \r\nthe number of rows and columns.";
      // 
      // back2MainFromGSSBtn
      // 
      this.back2MainFromGSSBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.back2MainFromGSSBtn.Location = new System.Drawing.Point(116, 355);
      this.back2MainFromGSSBtn.Name = "back2MainFromGSSBtn";
      this.back2MainFromGSSBtn.Size = new System.Drawing.Size(75, 40);
      this.back2MainFromGSSBtn.TabIndex = 4;
      this.back2MainFromGSSBtn.Text = "Back";
      this.back2MainFromGSSBtn.UseVisualStyleBackColor = true;
      this.back2MainFromGSSBtn.Click += new System.EventHandler(this.back2MainFromGSSBtn_Click);
      // 
      // enterRCDefaultBtn
      // 
      this.enterRCDefaultBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.enterRCDefaultBtn.Location = new System.Drawing.Point(189, 279);
      this.enterRCDefaultBtn.Name = "enterRCDefaultBtn";
      this.enterRCDefaultBtn.Size = new System.Drawing.Size(400, 50);
      this.enterRCDefaultBtn.TabIndex = 3;
      this.enterRCDefaultBtn.Text = "Default (6 X 4)";
      this.enterRCDefaultBtn.UseVisualStyleBackColor = true;
      this.enterRCDefaultBtn.Click += new System.EventHandler(this.enterRCDefaultBtn_Click);
      // 
      // enterRCFileBtn
      // 
      this.enterRCFileBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.enterRCFileBtn.Location = new System.Drawing.Point(189, 213);
      this.enterRCFileBtn.Name = "enterRCFileBtn";
      this.enterRCFileBtn.Size = new System.Drawing.Size(400, 50);
      this.enterRCFileBtn.TabIndex = 2;
      this.enterRCFileBtn.Text = "Choose input file (CSV or XML)";
      this.enterRCFileBtn.UseVisualStyleBackColor = true;
      this.enterRCFileBtn.Click += new System.EventHandler(this.enterRCFileBtn_Click);
      // 
      // enterRCDirectlyBtn
      // 
      this.enterRCDirectlyBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.enterRCDirectlyBtn.Location = new System.Drawing.Point(189, 147);
      this.enterRCDirectlyBtn.Name = "enterRCDirectlyBtn";
      this.enterRCDirectlyBtn.Size = new System.Drawing.Size(400, 50);
      this.enterRCDirectlyBtn.TabIndex = 1;
      this.enterRCDirectlyBtn.Text = "Directly enter number of grid row and column";
      this.enterRCDirectlyBtn.UseVisualStyleBackColor = true;
      this.enterRCDirectlyBtn.Click += new System.EventHandler(this.enterRCDirectlyBtn_Click);
      // 
      // gridSizeSelectTbx
      // 
      this.gridSizeSelectTbx.AutoSize = true;
      this.gridSizeSelectTbx.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gridSizeSelectTbx.Location = new System.Drawing.Point(220, 94);
      this.gridSizeSelectTbx.Name = "gridSizeSelectTbx";
      this.gridSizeSelectTbx.Size = new System.Drawing.Size(319, 33);
      this.gridSizeSelectTbx.TabIndex = 0;
      this.gridSizeSelectTbx.Text = "What the grid size would be?";
      // 
      // restorePnl
      // 
      this.restorePnl.Controls.Add(this.startGameFromRBtn);
      this.restorePnl.Controls.Add(this.back2MainFromRBtn);
      this.restorePnl.Controls.Add(this.restoreFileBrowseBtn);
      this.restorePnl.Controls.Add(this.restoreFileTbx);
      this.restorePnl.Controls.Add(this.restoreFileNameErrorLbl);
      this.restorePnl.Controls.Add(this.restoreFilePromptLbl);
      this.restorePnl.Location = new System.Drawing.Point(0, 0);
      this.restorePnl.Name = "restorePnl";
      this.restorePnl.Size = new System.Drawing.Size(801, 450);
      this.restorePnl.TabIndex = 4;
      // 
      // startGameFromRBtn
      // 
      this.startGameFromRBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startGameFromRBtn.Location = new System.Drawing.Point(535, 309);
      this.startGameFromRBtn.Name = "startGameFromRBtn";
      this.startGameFromRBtn.Size = new System.Drawing.Size(116, 33);
      this.startGameFromRBtn.TabIndex = 4;
      this.startGameFromRBtn.Text = "Start Game";
      this.startGameFromRBtn.UseVisualStyleBackColor = true;
      this.startGameFromRBtn.Click += new System.EventHandler(this.startGameFromRBtn_Click);
      // 
      // back2MainFromRBtn
      // 
      this.back2MainFromRBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.back2MainFromRBtn.Location = new System.Drawing.Point(135, 306);
      this.back2MainFromRBtn.Name = "back2MainFromRBtn";
      this.back2MainFromRBtn.Size = new System.Drawing.Size(75, 33);
      this.back2MainFromRBtn.TabIndex = 3;
      this.back2MainFromRBtn.Text = "Back";
      this.back2MainFromRBtn.UseVisualStyleBackColor = true;
      this.back2MainFromRBtn.Click += new System.EventHandler(this.back2MainFromRBtn_Click);
      // 
      // restoreFileBrowseBtn
      // 
      this.restoreFileBrowseBtn.Location = new System.Drawing.Point(557, 212);
      this.restoreFileBrowseBtn.Name = "restoreFileBrowseBtn";
      this.restoreFileBrowseBtn.Size = new System.Drawing.Size(91, 39);
      this.restoreFileBrowseBtn.TabIndex = 2;
      this.restoreFileBrowseBtn.Text = "Browse";
      this.restoreFileBrowseBtn.UseVisualStyleBackColor = true;
      this.restoreFileBrowseBtn.Click += new System.EventHandler(this.restoreFileBrowseBtn_Click);
      // 
      // restoreFileTbx
      // 
      this.restoreFileTbx.BackColor = System.Drawing.SystemColors.Control;
      this.restoreFileTbx.Enabled = false;
      this.restoreFileTbx.Location = new System.Drawing.Point(135, 217);
      this.restoreFileTbx.Name = "restoreFileTbx";
      this.restoreFileTbx.ReadOnly = true;
      this.restoreFileTbx.Size = new System.Drawing.Size(408, 25);
      this.restoreFileTbx.TabIndex = 1;
      // 
      // restoreFileNameErrorLbl
      // 
      this.restoreFileNameErrorLbl.ForeColor = System.Drawing.Color.Red;
      this.restoreFileNameErrorLbl.Location = new System.Drawing.Point(135, 250);
      this.restoreFileNameErrorLbl.Name = "restoreFileNameErrorLbl";
      this.restoreFileNameErrorLbl.Size = new System.Drawing.Size(450, 23);
      this.restoreFileNameErrorLbl.TabIndex = 5;
      this.restoreFileNameErrorLbl.Text = "Please choose an XML file";
      this.restoreFileNameErrorLbl.Visible = false;
      // 
      // restoreFilePromptLbl
      // 
      this.restoreFilePromptLbl.AutoSize = true;
      this.restoreFilePromptLbl.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.restoreFilePromptLbl.Location = new System.Drawing.Point(129, 127);
      this.restoreFilePromptLbl.Name = "restoreFilePromptLbl";
      this.restoreFilePromptLbl.Size = new System.Drawing.Size(522, 33);
      this.restoreFilePromptLbl.TabIndex = 0;
      this.restoreFilePromptLbl.Text = "Choose XML file that contains the previous state";
      // 
      // gamePnl
      // 
      this.gamePnl.AutoSize = true;
      this.gamePnl.Controls.Add(this.dropPosSelectPnl);
      this.gamePnl.Controls.Add(this.resultPnl);
      this.gamePnl.Controls.Add(this.saveExitBtn);
      this.gamePnl.Controls.Add(this.saveFilePromptLbl);
      this.gamePnl.Controls.Add(this.saveFileBrowseBtn);
      this.gamePnl.Controls.Add(this.saveFileTbx);
      this.gamePnl.Controls.Add(this.saveFileNameErrorLbl);
      this.gamePnl.Controls.Add(this.turnNumLbl);
      this.gamePnl.Controls.Add(this.turnLbl);
      this.gamePnl.Controls.Add(this.gridRTxb);
      this.gamePnl.Location = new System.Drawing.Point(0, 0);
      this.gamePnl.Name = "gamePnl";
      this.gamePnl.Size = new System.Drawing.Size(799, 467);
      this.gamePnl.TabIndex = 4;
      // 
      // dropPosSelectPnl
      // 
      this.dropPosSelectPnl.Controls.Add(this.dropPosBtn);
      this.dropPosSelectPnl.Controls.Add(this.dropPosNUD);
      this.dropPosSelectPnl.Controls.Add(this.dropPosPromptLbl);
      this.dropPosSelectPnl.Controls.Add(this.dropPosFullErrorLbl);
      this.dropPosSelectPnl.Controls.Add(this.turnTimerLbl);
      this.dropPosSelectPnl.Location = new System.Drawing.Point(570, 62);
      this.dropPosSelectPnl.Name = "dropPosSelectPnl";
      this.dropPosSelectPnl.Size = new System.Drawing.Size(225, 141);
      this.dropPosSelectPnl.TabIndex = 8;
      // 
      // dropPosBtn
      // 
      this.dropPosBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dropPosBtn.Location = new System.Drawing.Point(103, 76);
      this.dropPosBtn.Name = "dropPosBtn";
      this.dropPosBtn.Size = new System.Drawing.Size(75, 33);
      this.dropPosBtn.TabIndex = 10;
      this.dropPosBtn.Text = "Drop";
      this.dropPosBtn.UseVisualStyleBackColor = true;
      this.dropPosBtn.Click += new System.EventHandler(this.dropPosBtn_Click);
      // 
      // dropPosNUD
      // 
      this.dropPosNUD.Location = new System.Drawing.Point(28, 79);
      this.dropPosNUD.Name = "dropPosNUD";
      this.dropPosNUD.Size = new System.Drawing.Size(57, 25);
      this.dropPosNUD.TabIndex = 9;
      // 
      // dropPosPromptLbl
      // 
      this.dropPosPromptLbl.AutoSize = true;
      this.dropPosPromptLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dropPosPromptLbl.Location = new System.Drawing.Point(0, 38);
      this.dropPosPromptLbl.Name = "dropPosPromptLbl";
      this.dropPosPromptLbl.Size = new System.Drawing.Size(198, 27);
      this.dropPosPromptLbl.TabIndex = 8;
      this.dropPosPromptLbl.Text = "Where to drop? (0-3)";
      // 
      // dropPosFullErrorLbl
      // 
      this.dropPosFullErrorLbl.ForeColor = System.Drawing.Color.Red;
      this.dropPosFullErrorLbl.Location = new System.Drawing.Point(50, 122);
      this.dropPosFullErrorLbl.Name = "dropPosFullErrorLbl";
      this.dropPosFullErrorLbl.Size = new System.Drawing.Size(120, 23);
      this.dropPosFullErrorLbl.TabIndex = 0;
      this.dropPosFullErrorLbl.Text = "Full column!";
      this.dropPosFullErrorLbl.Visible = false;
      // 
      // turnTimerLbl
      // 
      this.turnTimerLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.turnTimerLbl.Location = new System.Drawing.Point(80, 0);
      this.turnTimerLbl.Name = "turnTimerLbl";
      this.turnTimerLbl.Size = new System.Drawing.Size(100, 27);
      this.turnTimerLbl.TabIndex = 11;
      // 
      // resultPnl
      // 
      this.resultPnl.Controls.Add(this.noBtn);
      this.resultPnl.Controls.Add(this.yesBtn);
      this.resultPnl.Controls.Add(this.playAgainPromptLbl);
      this.resultPnl.Controls.Add(this.resultStatusLbl);
      this.resultPnl.Controls.Add(this.resultLbl);
      this.resultPnl.Location = new System.Drawing.Point(570, 62);
      this.resultPnl.Name = "resultPnl";
      this.resultPnl.Size = new System.Drawing.Size(225, 141);
      this.resultPnl.TabIndex = 9;
      this.resultPnl.Visible = false;
      // 
      // noBtn
      // 
      this.noBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.noBtn.Location = new System.Drawing.Point(117, 95);
      this.noBtn.Name = "noBtn";
      this.noBtn.Size = new System.Drawing.Size(75, 33);
      this.noBtn.TabIndex = 7;
      this.noBtn.Text = "No";
      this.noBtn.UseVisualStyleBackColor = true;
      this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
      // 
      // yesBtn
      // 
      this.yesBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.yesBtn.Location = new System.Drawing.Point(29, 95);
      this.yesBtn.Name = "yesBtn";
      this.yesBtn.Size = new System.Drawing.Size(75, 33);
      this.yesBtn.TabIndex = 6;
      this.yesBtn.Text = "Yes";
      this.yesBtn.UseVisualStyleBackColor = true;
      this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
      // 
      // playAgainPromptLbl
      // 
      this.playAgainPromptLbl.AutoSize = true;
      this.playAgainPromptLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playAgainPromptLbl.Location = new System.Drawing.Point(49, 49);
      this.playAgainPromptLbl.Name = "playAgainPromptLbl";
      this.playAgainPromptLbl.Size = new System.Drawing.Size(117, 27);
      this.playAgainPromptLbl.TabIndex = 5;
      this.playAgainPromptLbl.Text = "Play again?";
      // 
      // resultStatusLbl
      // 
      this.resultStatusLbl.AutoSize = true;
      this.resultStatusLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultStatusLbl.Location = new System.Drawing.Point(120, 11);
      this.resultStatusLbl.Name = "resultStatusLbl";
      this.resultStatusLbl.Size = new System.Drawing.Size(67, 27);
      this.resultStatusLbl.TabIndex = 3;
      this.resultStatusLbl.Text = "O win!";
      // 
      // resultLbl
      // 
      this.resultLbl.AutoSize = true;
      this.resultLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultLbl.Location = new System.Drawing.Point(30, 11);
      this.resultLbl.Name = "resultLbl";
      this.resultLbl.Size = new System.Drawing.Size(78, 27);
      this.resultLbl.TabIndex = 4;
      this.resultLbl.Text = "Result: ";
      // 
      // saveExitBtn
      // 
      this.saveExitBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.saveExitBtn.Location = new System.Drawing.Point(603, 351);
      this.saveExitBtn.Name = "saveExitBtn";
      this.saveExitBtn.Size = new System.Drawing.Size(163, 40);
      this.saveExitBtn.TabIndex = 8;
      this.saveExitBtn.Text = "Save and Exit";
      this.saveExitBtn.UseVisualStyleBackColor = true;
      this.saveExitBtn.Click += new System.EventHandler(this.saveExitBtn_Click);
      // 
      // saveFilePromptLbl
      // 
      this.saveFilePromptLbl.AutoSize = true;
      this.saveFilePromptLbl.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.saveFilePromptLbl.Location = new System.Drawing.Point(571, 221);
      this.saveFilePromptLbl.Name = "saveFilePromptLbl";
      this.saveFilePromptLbl.Size = new System.Drawing.Size(179, 44);
      this.saveFilePromptLbl.TabIndex = 7;
      this.saveFilePromptLbl.Text = "Choose XML file to save \r\ngame state...";
      // 
      // saveFileBrowseBtn
      // 
      this.saveFileBrowseBtn.Location = new System.Drawing.Point(716, 276);
      this.saveFileBrowseBtn.Name = "saveFileBrowseBtn";
      this.saveFileBrowseBtn.Size = new System.Drawing.Size(80, 30);
      this.saveFileBrowseBtn.TabIndex = 6;
      this.saveFileBrowseBtn.Text = "Browse";
      this.saveFileBrowseBtn.UseVisualStyleBackColor = true;
      this.saveFileBrowseBtn.Click += new System.EventHandler(this.saveFileBrowseBtn_Click);
      // 
      // saveFileTbx
      // 
      this.saveFileTbx.Enabled = false;
      this.saveFileTbx.Location = new System.Drawing.Point(570, 276);
      this.saveFileTbx.Name = "saveFileTbx";
      this.saveFileTbx.Size = new System.Drawing.Size(142, 25);
      this.saveFileTbx.TabIndex = 5;
      // 
      // saveFileNameErrorLbl
      // 
      this.saveFileNameErrorLbl.ForeColor = System.Drawing.Color.Red;
      this.saveFileNameErrorLbl.Location = new System.Drawing.Point(570, 308);
      this.saveFileNameErrorLbl.Name = "saveFileNameErrorLbl";
      this.saveFileNameErrorLbl.Size = new System.Drawing.Size(220, 46);
      this.saveFileNameErrorLbl.TabIndex = 10;
      this.saveFileNameErrorLbl.Text = "Please choose an XML file";
      this.saveFileNameErrorLbl.Visible = false;
      // 
      // turnNumLbl
      // 
      this.turnNumLbl.AutoSize = true;
      this.turnNumLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.turnNumLbl.Location = new System.Drawing.Point(680, 20);
      this.turnNumLbl.Name = "turnNumLbl";
      this.turnNumLbl.Size = new System.Drawing.Size(50, 27);
      this.turnNumLbl.TabIndex = 2;
      this.turnNumLbl.Text = "1 (O)";
      // 
      // turnLbl
      // 
      this.turnLbl.AutoSize = true;
      this.turnLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.turnLbl.Location = new System.Drawing.Point(614, 20);
      this.turnLbl.Name = "turnLbl";
      this.turnLbl.Size = new System.Drawing.Size(62, 27);
      this.turnLbl.TabIndex = 1;
      this.turnLbl.Text = "Turn: ";
      // 
      // gridRTxb
      // 
      this.gridRTxb.Enabled = false;
      this.gridRTxb.Location = new System.Drawing.Point(13, 13);
      this.gridRTxb.Name = "gridRTxb";
      this.gridRTxb.Size = new System.Drawing.Size(552, 425);
      this.gridRTxb.TabIndex = 0;
      this.gridRTxb.Text = "";
      // 
      // currTimeLbl
      // 
      this.currTimeLbl.Location = new System.Drawing.Point(590, 410);
      this.currTimeLbl.Name = "currTimeLbl";
      this.currTimeLbl.Size = new System.Drawing.Size(200, 23);
      this.currTimeLbl.TabIndex = 0;
      this.currTimeLbl.BringToFront();
      // 
      // turnTimer
      // 
      this.turnTimer.Interval = 1000;
      this.turnTimer.Tick += new System.EventHandler(this.turnTimer_Tick);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // currTimer
      // 
      this.currTimer.Interval = 1000;
      this.currTimer.Tick += new System.EventHandler(this.currTimer_Tick);
      // 
      // GameForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.mainMenuPnl);
      this.Name = "GameForm";
      this.Text = "Connect Four Othello";
      this.mainMenuPnl.ResumeLayout(false);
      this.mainMenuPnl.PerformLayout();
      this.gridSizeSelectPnl.ResumeLayout(false);
      this.gridSizeSelectPnl.PerformLayout();
      this.enterRCDirectlyPnl.ResumeLayout(false);
      this.enterRCDirectlyPnl.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.colNUD)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rowNUD)).EndInit();
      this.enterRCFilePnl.ResumeLayout(false);
      this.enterRCFilePnl.PerformLayout();
      this.restorePnl.ResumeLayout(false);
      this.restorePnl.PerformLayout();
      this.gamePnl.ResumeLayout(false);
      this.gamePnl.PerformLayout();
      this.dropPosSelectPnl.ResumeLayout(false);
      this.dropPosSelectPnl.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dropPosNUD)).EndInit();
      this.resultPnl.ResumeLayout(false);
      this.resultPnl.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label welcomePromptLbl;
    private System.Windows.Forms.Button newGameBtn;
    private System.Windows.Forms.Button restoreBtn;
    private System.Windows.Forms.Panel mainMenuPnl;
    private System.Windows.Forms.Panel gridSizeSelectPnl;
    private System.Windows.Forms.Button enterRCDirectlyBtn;
    private System.Windows.Forms.Label gridSizeSelectTbx;
    private System.Windows.Forms.Button back2MainFromGSSBtn;
    private System.Windows.Forms.Button enterRCDefaultBtn;
    private System.Windows.Forms.Button enterRCFileBtn;
    private System.Windows.Forms.Panel gamePnl;
    private System.Windows.Forms.Button saveExitBtn;
    private System.Windows.Forms.Button saveFileBrowseBtn;
    private System.Windows.Forms.TextBox saveFileTbx;
    private System.Windows.Forms.Label saveFileNameErrorLbl;
    private System.Windows.Forms.Label resultLbl;
    private System.Windows.Forms.Label resultStatusLbl;
    private System.Windows.Forms.Label turnNumLbl;
    private System.Windows.Forms.Label turnLbl;
    private System.Windows.Forms.RichTextBox gridRTxb;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Panel resultPnl;
    private System.Windows.Forms.Button noBtn;
    private System.Windows.Forms.Button yesBtn;
    private System.Windows.Forms.Label playAgainPromptLbl;
    private System.Windows.Forms.Panel enterRCFilePnl;
    private System.Windows.Forms.Label enterRCFilePromptLbl;
    private System.Windows.Forms.Button back2GSSFromFBtn;
    private System.Windows.Forms.Button gridSizeFileBrowseBtn;
    private System.Windows.Forms.TextBox gridSizeFileTbx;
    private System.Windows.Forms.Label gridSizeFileNameErrorLbl;
    private System.Windows.Forms.Button startGameFromFBtn;
    private System.Windows.Forms.Panel restorePnl;
    private System.Windows.Forms.Label restoreFilePromptLbl;
    private System.Windows.Forms.Button back2MainFromRBtn;
    private System.Windows.Forms.Button restoreFileBrowseBtn;
    private System.Windows.Forms.TextBox restoreFileTbx;
    private System.Windows.Forms.Label restoreFileNameErrorLbl;
    private System.Windows.Forms.Button startGameFromRBtn;
    private System.Windows.Forms.Panel enterRCDirectlyPnl;
    private System.Windows.Forms.Button back2GSSFromDBtn;
    private System.Windows.Forms.Button startGameFromDBtn;
    private System.Windows.Forms.Label colLbl;
    private System.Windows.Forms.Label rowLbl;
    private System.Windows.Forms.Label enterRCDirectlyPromptLbl;
    private System.Windows.Forms.NumericUpDown colNUD;
    private System.Windows.Forms.NumericUpDown rowNUD;
    private System.Windows.Forms.Label saveFilePromptLbl;
    private System.Windows.Forms.Panel dropPosSelectPnl;
    private System.Windows.Forms.Button dropPosBtn;
    private System.Windows.Forms.NumericUpDown dropPosNUD;
    private System.Windows.Forms.Label dropPosPromptLbl;
    private System.Windows.Forms.Label dropPosFullErrorLbl;
    private System.Windows.Forms.Timer turnTimer;
    private System.Windows.Forms.Label turnTimerLbl;
    private System.Windows.Forms.Timer currTimer;
    private System.Windows.Forms.Label currTimeLbl;
  }
}

