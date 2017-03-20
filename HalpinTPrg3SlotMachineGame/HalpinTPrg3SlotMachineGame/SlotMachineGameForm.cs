/*
 CIS 207: C# Winter 2017 
 Program 3: Slot Machine Game 
 Taressa Halpin 
 Date: March  2017 

 BUSINESS PURPOSE: 
 The purpose of this application is to create a slot machine game. 
 Players can play as many games as they wish to, however, 
 they must enter the number of games they wish to play at the beginning. 
 Prizes for the slot machine game are based on the number of 
 wins the player has for each game. 

 CLASSROOM PURPOSE:
 INPUT: 
 PROCESSES:
 OUTPUT:  
 ACCUMULATION: 
 LOOPS: 
 WHILE: 
 FOR: 


 Random Numbers: 
 Combo Box: 
 List Box:
 File Handling:  
 Dialog Box: 
 


 MISCELLANEOUS: 
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalpinTPrg3SlotMachineGame
{
    public partial class SlotMachineGameForm : Form
    {
        /***PROGRAM VARIABLES***/

        /*WORKING VARIABLES*/
        private int pointsWon;
        private int totalFlips; 

        /*FILE VARIABLES*/
        StreamReader inputListFile;   //Creates Readable File Name
        StreamWriter outputListFile;  //File Name that is used in the program 

        /*RANDOM NUMBER VARIABLES*/
        private Random rndNumber = new Random();
        int oneRandInteger;
        int twoRandInteger;
        int threeRandInteger; 

        private bool searchBoolean;
        int sideUp;

        /*ACCUMULATORS*/
        private int totalPointsWonInteger;//Cards 
        private int totalNumberOfWins; //Coins 

        /*CONSTANTS*/
        private const int THREE_MATCHES = 10;
        private const int TWO_MATCHES = 5; 

        /*CALCULATIONS*/
        

        /*TOTALS*/
        private int selectedPlayerPlaysLeftInt; 



        public SlotMachineGameForm()
        {
            InitializeComponent();
        }
       
        /*FORM OBJECT EVENT HANDLER*/
        private void SlotMachineGameForm_Load(object sender, EventArgs e)
        {
            playerReportLabel.ResetText(); //Resets Text on Player Report 
            playButton.Enabled = false; 
        }

        /*PLAY BUTTON EVENT HANDLER*/
        private void playButton_Click(object sender, EventArgs e)
        {
            //Represents 1 Game when selected 
            //Determines the Prize Won
            //Accumulates the prize won for management 
            //Find average points based on # of games played by each player 
            //Include the Quotient of total and input # games 
            //Count # of games and stop play -input # of names is played 
            //End of player's turn -# of games is over 
            //1st: Average used to determine # of coin flips 
            //2nd: Set # of Prize Possibilities based on quotient from step 1 
            //3rd: Randomly flip a coin based on # of flips set in step 2
            //4th: Display number of wins along with prize won--6 prizes 

            //2nd: Set the number of Prize Possibilities based on the quotient from the 1st step:
            //            1 through 9 – 1 Flip of a coin
            //            10  through 19 – 3 Flips of a coin
            //            20 through 39 – 5 Flips of a coin
            //            40 through 69 – 8 Flips of a coin
            //            70 or more    - 12 Flips of a coin
                     
           
               
                if (selectedPlayerPlaysLeftInt > 0)
                {   //This is where the spin happens...
                oneRandInteger = rndNumber.Next(3);
                twoRandInteger = rndNumber.Next(3);
                threeRandInteger = rndNumber.Next(3);
                selectedPlayerPlaysLeftInt --;
                displayCards();
                pointsWonLabel.Text = "POINTS WON 0"; 
                if (oneRandInteger == twoRandInteger && twoRandInteger == threeRandInteger)
                {
                    pointsWon = THREE_MATCHES;
                    pointsWonLabel.Text = "POINTS WON " + pointsWon;
                }

                else
                {
                    if (oneRandInteger == twoRandInteger || twoRandInteger == threeRandInteger 
                        || oneRandInteger == threeRandInteger)
                    {
                        pointsWon = TWO_MATCHES;
                        pointsWonLabel.Text = "POINTS WON " + pointsWon;  
                    }

                }

                totalPointsWonInteger += pointsWon;
                if (selectedPlayerPlaysLeftInt <= 0)
                {
                    if (totalPointsWonInteger > 0)
                    {
                        MessageBox.Show("Flip a Coin to Determine Number of Wins","FLIP A COIN MESSAGE",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                        totalNumberOfWins = 0; 
                        tossButton.Enabled = true;
                        
                    }

                }

            }

                else
                {
                    MessageBox.Show("No Plays Left.","PLAYS LEFT MESSAGE",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                playButton.Enabled = false; 
                }
            

            

            int myRandomInteger;

            myRandomInteger = rndNumber.Next();     
         
        }

        private void numberOfCoinFlips()
        {
            if (totalPointsWonInteger > 70)
            {
                totalFlips = 12;
            }
            else
            {
                if (totalPointsWonInteger > 40)
                {
                    totalFlips = 8;
                }
                else
                {
                    if (totalPointsWonInteger > 20)
                    {
                        totalFlips = 5; 
                    }
                    else
                    {
                        if (totalPointsWonInteger > 10)
                        {
                            totalFlips = 3; 
                        }
                        else
                        {
                            if (totalPointsWonInteger > 1)
                            {
                                totalFlips = 1;
                            }
                            else
                            {
                                totalFlips = 0; 
                            }
                        }
                    }
                }
            }
        }


        private void displayCards()   
        {
            switch (oneRandInteger)  
            { 
                case 0:
                    spin1PictureBox.Image = Properties.Resources.AceofHearts; 
                    break;
                case 1:
                    spin1PictureBox.Image = Properties.Resources.JackofDiamonds; 
                    break;
                case 2:
                    spin1PictureBox.Image = Properties.Resources.QueenofSpades; 
                    break; 
            }
            switch (twoRandInteger)
            {
                case 0:
                    spin2PictureBox.Image = Properties.Resources.AceofHearts;
                    break;
                case 1:
                    spin2PictureBox.Image = Properties.Resources.JackofDiamonds;
                    break;
                case 2:
                    spin2PictureBox.Image = Properties.Resources.QueenofSpades;
                    break;
            }
            switch (threeRandInteger)
            {
                case 0:
                    spin3PictureBox.Image = Properties.Resources.AceofHearts;
                    break;
                case 1:
                    spin3PictureBox.Image = Properties.Resources.JackofDiamonds;
                    break;
                case 2:
                    spin3PictureBox.Image = Properties.Resources.QueenofSpades;
                    break;
            }

        }
        

        /*SEARCH MATCH METHOD*/
        private void SearchMatch()
        {
            searchBoolean = false;
            int indexInt = 0; 
            while (indexInt < playerNameComboBox.Items.Count)
            {
                if (playerNameComboBox.Text.ToUpper() == playerNameComboBox.Items[indexInt].ToString().ToUpper())
                {
                    searchBoolean = true;
                    indexInt = playerNameComboBox.Items.Count; 

                }
                indexInt++; 
            }
        }
        /*SHOW CARD METHOD*/
        private void ShowCard()
        {
            
        }
        /*ACE OF SPADES METHOD*/
        private void AceofSpades()
        {

        }
        /*ACE OF HEARTS METHOD*/
        private void AceofHearts()
        {

        }
        /*ACE OF CLUBS METHOD*/
        private void AceofClubs()
        {

        }

        /*ADD PLAYER BUTTON EVENT HANDLER*/
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            if (playerNameComboBox.Text.Trim() != string.Empty)
          
                   
                    {
                        playerNameComboBox.Items.Add(playerNameComboBox.Text +  ", 0 ");
                        playerNameComboBox.ResetText();
                        numberOfTurnsTextBox.Text = string.Empty; 
                    }
                   

             
            else
            {
                MessageBox.Show("Enter a Player Name First", "Name Input Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                playerNameComboBox.Focus();
                playerNameComboBox.SelectAll(); 
            }
        }

        /*REMOVE PLAYER BUTTON EVENT HANDLER*/
        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            if (playerNameComboBox.SelectedIndex > -1)
                playerNameComboBox.Items.Remove(playerNameComboBox.SelectedItem);
            else
                MessageBox.Show("Select a Player Name First!","Add Name Input Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*NEW PLAYER BUTTON EVENT HANDLER*/
        private void newPlayerButton_Click(object sender, EventArgs e)
        {
            if (playerNameComboBox.SelectedIndex > -1)
            {

                if (numberOfTurnsTextBox.Text.Trim() != string.Empty)
                {
                    try
                    {
                        selectedPlayerPlaysLeftInt = int.Parse(numberOfTurnsTextBox.Text.Trim());
                        if (selectedPlayerPlaysLeftInt > 0)
                        {
                            //The spin button can work now 
                            playButton.Enabled = true;
                            totalPointsWonInteger = 0; 
                        }
                        else
                        {
                            MessageBox.Show("Number of Plays Needs to be Greater than Zero!","GREATER THAN ZERO ERROR!",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }


                    }


                    catch
                    {
                        MessageBox.Show("Please enter an Integer for Number of Turns!", "INTEGER INPUT ERRROR", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter a Numeric Value for Number of Turns!", "NUMBER INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a Player Name First", "Name Input Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                playerNameComboBox.Focus();
                playerNameComboBox.SelectAll();
            }



        }

        /*PRIZE TOTALS BUTTON EVENT HANDLER*/
        private void prizeTotalsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This message will show prize totals:","MANAGEMENT TOTALS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        }

        

        /*SAVE DATA BUTTON EVENT HANDLER*/ 
        private void saveDataButton_Click(object sender, EventArgs e)
        {
            
        }

        /*PLAYER REPORT BUTTON EVENT HANDLER*/ 
        private void playerReportButton_Click(object sender, EventArgs e)
        {
            playerReportLabel.Text = "NAME" + "              " 
                + "WINS" + 
                Environment.NewLine +   "_____________________________" + 
                Environment.NewLine +   
                Environment.NewLine +
                "Total Players: " + Environment.NewLine +
                "Total Wins: " + Environment.NewLine +
                "Average Wins: " + Environment.NewLine + Environment.NewLine;
               
        }

     

        /*TOSS BUTTTON EVENT HANDLER: Coin Toss Pictures*/
        private void tossButton_Click(object sender, EventArgs e)
        {
            numberOfCoinFlips(); 



            Random rand = new Random();
            sideUp = rand.Next(2);
            if (sideUp == 0)
            {
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false; 
            }
        }


        /*EXIT BUTTON EVENT HANDLER: Closes the Program*/
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spin1PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
