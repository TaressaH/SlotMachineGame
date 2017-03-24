namespace HalpinTPrg3SlotMachineGame
{
    partial class SlotMachineGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playButton = new System.Windows.Forms.Button();
            this.prizeTotalsButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.newPlayerButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.playerReportButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.playerNameComboBox = new System.Windows.Forms.ComboBox();
            this.listBoxLabel = new System.Windows.Forms.Label();
            this.gamesWonListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.playerReportLabel = new System.Windows.Forms.Label();
            this.numberOfTurnsTextBox = new System.Windows.Forms.TextBox();
            this.turnsLabel = new System.Windows.Forms.Label();
            this.tossButton = new System.Windows.Forms.Button();
            this.addNewPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.pointsWonLabel = new System.Windows.Forms.Label();
            this.tossOutcomeLabel = new System.Windows.Forms.Label();
            this.numWinsCoinTossLabel = new System.Windows.Forms.Label();
            this.prizeNameLabel = new System.Windows.Forms.Label();
            this.prizesPictureBox = new System.Windows.Forms.PictureBox();
            this.spin3PictureBox = new System.Windows.Forms.PictureBox();
            this.spin2PictureBox = new System.Windows.Forms.PictureBox();
            this.spin1PictureBox = new System.Windows.Forms.PictureBox();
            this.addNewPlayerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prizesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.PaleGreen;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.playButton.Location = new System.Drawing.Point(539, 165);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(140, 52);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "&Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // prizeTotalsButton
            // 
            this.prizeTotalsButton.BackColor = System.Drawing.Color.PaleGreen;
            this.prizeTotalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeTotalsButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.prizeTotalsButton.Location = new System.Drawing.Point(1098, 50);
            this.prizeTotalsButton.Name = "prizeTotalsButton";
            this.prizeTotalsButton.Size = new System.Drawing.Size(140, 51);
            this.prizeTotalsButton.TabIndex = 10;
            this.prizeTotalsButton.Text = "P&rize Totals";
            this.prizeTotalsButton.UseVisualStyleBackColor = false;
            this.prizeTotalsButton.Click += new System.EventHandler(this.prizeTotalsButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.BackColor = System.Drawing.Color.PaleGreen;
            this.addPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addPlayerButton.Location = new System.Drawing.Point(1098, 168);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(140, 51);
            this.addPlayerButton.TabIndex = 8;
            this.addPlayerButton.Text = "&Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = false;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.BackColor = System.Drawing.Color.PaleGreen;
            this.removePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayerButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.removePlayerButton.Location = new System.Drawing.Point(1098, 231);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(140, 53);
            this.removePlayerButton.TabIndex = 9;
            this.removePlayerButton.Text = "&Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = false;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // newPlayerButton
            // 
            this.newPlayerButton.BackColor = System.Drawing.Color.PaleGreen;
            this.newPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.newPlayerButton.Location = new System.Drawing.Point(1098, 107);
            this.newPlayerButton.Name = "newPlayerButton";
            this.newPlayerButton.Size = new System.Drawing.Size(140, 52);
            this.newPlayerButton.TabIndex = 11;
            this.newPlayerButton.Text = "&New Player";
            this.newPlayerButton.UseVisualStyleBackColor = false;
            this.newPlayerButton.Click += new System.EventHandler(this.newPlayerButton_Click);
            // 
            // saveDataButton
            // 
            this.saveDataButton.BackColor = System.Drawing.Color.PaleGreen;
            this.saveDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.saveDataButton.Location = new System.Drawing.Point(1098, 304);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(140, 52);
            this.saveDataButton.TabIndex = 12;
            this.saveDataButton.Text = "&Save Data";
            this.saveDataButton.UseVisualStyleBackColor = false;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // playerReportButton
            // 
            this.playerReportButton.BackColor = System.Drawing.Color.PaleGreen;
            this.playerReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerReportButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.playerReportButton.Location = new System.Drawing.Point(1098, 375);
            this.playerReportButton.Name = "playerReportButton";
            this.playerReportButton.Size = new System.Drawing.Size(144, 39);
            this.playerReportButton.TabIndex = 13;
            this.playerReportButton.Text = "P&layer Report";
            this.playerReportButton.UseVisualStyleBackColor = false;
            this.playerReportButton.Click += new System.EventHandler(this.playerReportButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.PaleGreen;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exitButton.Location = new System.Drawing.Point(1098, 439);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 35);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titleLabel.Font = new System.Drawing.Font("Engravers MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.titleLabel.Location = new System.Drawing.Point(26, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(464, 86);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "               WELCOME: \r\nSlot----Machine----Game\r\n\r\n";
            // 
            // playerNameComboBox
            // 
            this.playerNameComboBox.FormattingEnabled = true;
            this.playerNameComboBox.Items.AddRange(new object[] {
            "John Doe, 2",
            "Mary Draper, 3 ",
            "Peter Richards, 4 ",
            "Lucy Hill, 0",
            "Greg Thompson, 5 ",
            "Heather Gorsack, 6 ",
            "Evan Johnson, 2 ",
            "Katy West, 4 "});
            this.playerNameComboBox.Location = new System.Drawing.Point(192, 37);
            this.playerNameComboBox.Name = "playerNameComboBox";
            this.playerNameComboBox.Size = new System.Drawing.Size(153, 28);
            this.playerNameComboBox.TabIndex = 4;
            this.playerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.playerNameComboBox_SelectedIndexChanged);
            // 
            // listBoxLabel
            // 
            this.listBoxLabel.AutoSize = true;
            this.listBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLabel.Location = new System.Drawing.Point(40, 272);
            this.listBoxLabel.Name = "listBoxLabel";
            this.listBoxLabel.Size = new System.Drawing.Size(124, 22);
            this.listBoxLabel.TabIndex = 5;
            this.listBoxLabel.Text = "Games Won:";
            // 
            // gamesWonListBox
            // 
            this.gamesWonListBox.FormattingEnabled = true;
            this.gamesWonListBox.ItemHeight = 20;
            this.gamesWonListBox.Location = new System.Drawing.Point(218, 272);
            this.gamesWonListBox.Name = "gamesWonListBox";
            this.gamesWonListBox.Size = new System.Drawing.Size(153, 84);
            this.gamesWonListBox.TabIndex = 6;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // playerReportLabel
            // 
            this.playerReportLabel.AutoSize = true;
            this.playerReportLabel.Location = new System.Drawing.Point(808, 247);
            this.playerReportLabel.Name = "playerReportLabel";
            this.playerReportLabel.Size = new System.Drawing.Size(51, 20);
            this.playerReportLabel.TabIndex = 15;
            this.playerReportLabel.Text = "label1";
            // 
            // numberOfTurnsTextBox
            // 
            this.numberOfTurnsTextBox.Location = new System.Drawing.Point(192, 86);
            this.numberOfTurnsTextBox.Name = "numberOfTurnsTextBox";
            this.numberOfTurnsTextBox.Size = new System.Drawing.Size(153, 26);
            this.numberOfTurnsTextBox.TabIndex = 16;
            // 
            // turnsLabel
            // 
            this.turnsLabel.AutoSize = true;
            this.turnsLabel.Location = new System.Drawing.Point(45, 74);
            this.turnsLabel.Name = "turnsLabel";
            this.turnsLabel.Size = new System.Drawing.Size(131, 20);
            this.turnsLabel.TabIndex = 17;
            this.turnsLabel.Text = "Number of Turns:";
            // 
            // tossButton
            // 
            this.tossButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossButton.Location = new System.Drawing.Point(480, 239);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(121, 34);
            this.tossButton.TabIndex = 20;
            this.tossButton.Text = "&Toss";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // addNewPlayerGroupBox
            // 
            this.addNewPlayerGroupBox.Controls.Add(this.playerNameLabel);
            this.addNewPlayerGroupBox.Controls.Add(this.numberOfTurnsTextBox);
            this.addNewPlayerGroupBox.Controls.Add(this.turnsLabel);
            this.addNewPlayerGroupBox.Controls.Add(this.playerNameComboBox);
            this.addNewPlayerGroupBox.Location = new System.Drawing.Point(26, 107);
            this.addNewPlayerGroupBox.Name = "addNewPlayerGroupBox";
            this.addNewPlayerGroupBox.Size = new System.Drawing.Size(398, 137);
            this.addNewPlayerGroupBox.TabIndex = 24;
            this.addNewPlayerGroupBox.TabStop = false;
            this.addNewPlayerGroupBox.Text = "Add New Player: ";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(46, 43);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(130, 22);
            this.playerNameLabel.TabIndex = 1;
            this.playerNameLabel.Text = "Player Name:";
            // 
            // pointsWonLabel
            // 
            this.pointsWonLabel.AutoSize = true;
            this.pointsWonLabel.Location = new System.Drawing.Point(758, 168);
            this.pointsWonLabel.Name = "pointsWonLabel";
            this.pointsWonLabel.Size = new System.Drawing.Size(51, 20);
            this.pointsWonLabel.TabIndex = 25;
            this.pointsWonLabel.Text = "label1";
            // 
            // tossOutcomeLabel
            // 
            this.tossOutcomeLabel.AutoSize = true;
            this.tossOutcomeLabel.Location = new System.Drawing.Point(476, 289);
            this.tossOutcomeLabel.Name = "tossOutcomeLabel";
            this.tossOutcomeLabel.Size = new System.Drawing.Size(0, 20);
            this.tossOutcomeLabel.TabIndex = 26;
            // 
            // numWinsCoinTossLabel
            // 
            this.numWinsCoinTossLabel.AutoSize = true;
            this.numWinsCoinTossLabel.Location = new System.Drawing.Point(26, 393);
            this.numWinsCoinTossLabel.Name = "numWinsCoinTossLabel";
            this.numWinsCoinTossLabel.Size = new System.Drawing.Size(126, 40);
            this.numWinsCoinTossLabel.TabIndex = 28;
            this.numWinsCoinTossLabel.Text = "Number of Wins \r\nfrom Coin Toss: ";
            // 
            // prizeNameLabel
            // 
            this.prizeNameLabel.AutoSize = true;
            this.prizeNameLabel.Location = new System.Drawing.Point(218, 507);
            this.prizeNameLabel.Name = "prizeNameLabel";
            this.prizeNameLabel.Size = new System.Drawing.Size(51, 20);
            this.prizeNameLabel.TabIndex = 29;
            this.prizeNameLabel.Text = "label2";
            // 
            // prizesPictureBox
            // 
            this.prizesPictureBox.Location = new System.Drawing.Point(182, 375);
            this.prizesPictureBox.Name = "prizesPictureBox";
            this.prizesPictureBox.Size = new System.Drawing.Size(207, 108);
            this.prizesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prizesPictureBox.TabIndex = 27;
            this.prizesPictureBox.TabStop = false;
            // 
            // spin3PictureBox
            // 
            this.spin3PictureBox.Image = global::HalpinTPrg3SlotMachineGame.Properties.Resources.QueenofSpades;
            this.spin3PictureBox.Location = new System.Drawing.Point(838, 27);
            this.spin3PictureBox.Name = "spin3PictureBox";
            this.spin3PictureBox.Size = new System.Drawing.Size(100, 116);
            this.spin3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spin3PictureBox.TabIndex = 23;
            this.spin3PictureBox.TabStop = false;
            // 
            // spin2PictureBox
            // 
            this.spin2PictureBox.Image = global::HalpinTPrg3SlotMachineGame.Properties.Resources.JackofDiamonds;
            this.spin2PictureBox.Location = new System.Drawing.Point(718, 27);
            this.spin2PictureBox.Name = "spin2PictureBox";
            this.spin2PictureBox.Size = new System.Drawing.Size(100, 116);
            this.spin2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spin2PictureBox.TabIndex = 22;
            this.spin2PictureBox.TabStop = false;
            // 
            // spin1PictureBox
            // 
            this.spin1PictureBox.Image = global::HalpinTPrg3SlotMachineGame.Properties.Resources.AceofHearts;
            this.spin1PictureBox.Location = new System.Drawing.Point(550, 27);
            this.spin1PictureBox.Name = "spin1PictureBox";
            this.spin1PictureBox.Size = new System.Drawing.Size(134, 116);
            this.spin1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spin1PictureBox.TabIndex = 21;
            this.spin1PictureBox.TabStop = false;
            this.spin1PictureBox.Click += new System.EventHandler(this.spin1PictureBox_Click);
            // 
            // SlotMachineGameForm
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1325, 565);
            this.Controls.Add(this.prizeNameLabel);
            this.Controls.Add(this.numWinsCoinTossLabel);
            this.Controls.Add(this.prizesPictureBox);
            this.Controls.Add(this.tossOutcomeLabel);
            this.Controls.Add(this.pointsWonLabel);
            this.Controls.Add(this.addNewPlayerGroupBox);
            this.Controls.Add(this.spin3PictureBox);
            this.Controls.Add(this.spin2PictureBox);
            this.Controls.Add(this.spin1PictureBox);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.playerReportLabel);
            this.Controls.Add(this.gamesWonListBox);
            this.Controls.Add(this.listBoxLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playerReportButton);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.newPlayerButton);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.prizeTotalsButton);
            this.Controls.Add(this.playButton);
            this.Name = "SlotMachineGameForm";
            this.Text = " Slot Machine Game W17 Program 3";
            this.Load += new System.EventHandler(this.SlotMachineGameForm_Load);
            this.addNewPlayerGroupBox.ResumeLayout(false);
            this.addNewPlayerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prizesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button prizeTotalsButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button newPlayerButton;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button playerReportButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox playerNameComboBox;
        private System.Windows.Forms.Label listBoxLabel;
        private System.Windows.Forms.ListBox gamesWonListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label playerReportLabel;
        private System.Windows.Forms.TextBox numberOfTurnsTextBox;
        private System.Windows.Forms.Label turnsLabel;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.PictureBox spin1PictureBox;
        private System.Windows.Forms.PictureBox spin2PictureBox;
        private System.Windows.Forms.PictureBox spin3PictureBox;
        private System.Windows.Forms.GroupBox addNewPlayerGroupBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label pointsWonLabel;
        private System.Windows.Forms.Label tossOutcomeLabel;
        private System.Windows.Forms.PictureBox prizesPictureBox;
        private System.Windows.Forms.Label numWinsCoinTossLabel;
        private System.Windows.Forms.Label prizeNameLabel;
    }
}

