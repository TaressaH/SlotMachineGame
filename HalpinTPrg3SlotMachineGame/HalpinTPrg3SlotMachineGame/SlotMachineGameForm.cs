/*
 CIS 207: C# Winter 2017 
 Program 3: Slot Machine Game 
 Taressa Halpin 
 Date: March 28 2017 

 BUSINESS PURPOSE: 
 THE PURPOSE OF THIS APPLICATION IS TO CREATE A SLOT MACHINE GAME. 
 PLAYERS CAN PLAY AS MANY GAMES AS THEY WISH TO, HOWEVER, 
 THEY MUST ENTER THE NUMBER OF GAMES THEY WISH TO PLAY AT THE BEGINNING. 
 PRIZES FOR THE SLOT MACHINE GAME ARE BASED ON THE NUMBER OF 
 WINS THE PLAYER HAS FOR EACH GAME. 

 CLASSROOM PURPOSE:

 INPUTS: Combo Box, List Box, TextBox, Buttons 
 PROCESSES: 
 OUTPUT:  
 ACCUMULATION: 
 LOOPS: 
 WHILE: 
 FOR: 
 SWITCH STATEMENTS: 
 RANDOM NUMBERS: 
 COMBO BOX: 
 LIST BOX: 
 FILE HANDLING: 
 DIALOG BOX: 
 
 EXTRA: 
 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;       // File Use 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // Enables Thread  

namespace HalpinTPrg3SlotMachineGame
{
    public partial class SlotMachineGameForm : Form
    {
        /***PROGRAM VARIABLES***/

        /*WORKING VARIABLES*/
        private int pointsWon;                 //Points Won Integer 
        private int totalFlips;                //Total Flips Integer 
        private int numberOfPlaysInteger;      //Number of Plays Integer 
        int playerSelectedIndexInteger;        //Player Selected Index Integer 

        /*FILE VARIABLES*/
        StreamReader inputListFile;           //Creates Readable File Name
        StreamWriter outputListFile;          //File Name that is used in the program 
        private String NameFileString;        // Name of File 


        /*RANDOM NUMBER VARIABLES*/
        private Random rndNumber = new Random();    //Creates Random Number Method 
        Random rand = new Random();                 //Random Number Method 
        int oneRandInteger;                         //First Random Number Integer 
        int twoRandInteger;                         //Second Random Number Integer 
        int threeRandInteger;                       //Third Random Number Integer 

        private bool searchBoolean;                 //Search Boolean Variable 
        int sideUp;                                 //Side Up Integer 

        /*ACCUMULATORS*/
        private int totalPointsWonInteger;          //Total Points Won Integer for Cards 
        private int totalNumberOfWins;              //Total Number of Wins for Coins 
        private int totalAmazonGiftcardWonInteger;  //Prize: Total Amazon Gift Card Won Integer 
        private int totalHeadPhonesWonInteger;      //Prize: Total Head Phones Won Integer 
        private int totalAppleTVsWonInteger;        //Prize: Total Apple TVs Won Integer 
        private int totalGoogleIHomesWonInteger;    //Prize: Total Google I-Homes Won Integer 
        private int totalIPadsWonInteger;           //Prize: Total I-Pads Won Integer 
        private int totalAcerLaptopsWonInteger;     //Prize: Total Acer Laptops Won Integer 

        /*CONSTANTS*/
        private const int THREE_MATCHES = 10;      //CONSTANT VARIABLE: Three Matches 
        private const int TWO_MATCHES = 5;         //CONSTANT VARIABLE: Two Matches 
        
        /*CALCULATIONS*/
        
        /*TOTALS*/
        private int selectedPlayerPlaysLeftInt;    //Selected Player Plays Left Integer 

        /*SLOT MACHINE GAME FORM: INITIALIZES COMPONENT*/
        public SlotMachineGameForm()
        {
            InitializeComponent();
        }
       
        /*FORM OBJECT EVENT HANDLER*/
        private void SlotMachineGameForm_Load(object sender, EventArgs e)
        {
            playerReportLabel.ResetText();        //Resets Text on Player Report 
            playButton.Enabled = false;           //Play Button is Disabled 
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
                               
               //IF STATEMENT: SELECTED PLAYER PLAYS LEFT INTEGER 
                if (selectedPlayerPlaysLeftInt > 0)
                {   //This is where the spin happens...

                oneRandInteger = rndNumber.Next(3);     //FIRST RANDOM INTEGER WITH NEXT METHOD 
                twoRandInteger = rndNumber.Next(3);     //SECOND RANDOM INTEGER WITH NEXT METHOD 
                threeRandInteger = rndNumber.Next(3);   //THIRD RANDOM INTEGER WITH NEXT METHOD 

                selectedPlayerPlaysLeftInt --;          //SELECTED PLAYERS PLAYS LEFT INTEGER DECREMENTED 

                displayCards();  // DISPLAY CARDS METHOD 

                pointsWonLabel.Text = "POINTS WON 0";    //POINTS WON LABEL TEXT  
                
                //IF STATEMENT: 3 RANDOM INTEGER VALUES 
                if (oneRandInteger == twoRandInteger && twoRandInteger == threeRandInteger)
                {
                    //CONSTANT VARIABLE AND ACCUMULATOR VARIABLE 
                    pointsWon = THREE_MATCHES;
                    totalPointsWonInteger += pointsWon;                    
                }

                else
                {
                    //IF STATEMENT: 3 RANDOM INTEGER VARIABLES 
                    if (oneRandInteger == twoRandInteger || twoRandInteger == threeRandInteger 
                        || oneRandInteger == threeRandInteger)
                    {
                        //CONSTANT VARIABLE AND ACCUMULATOR VARIABLE 
                        pointsWon = TWO_MATCHES;
                        totalPointsWonInteger += pointsWon;
                      }
                }

                //POINTS WON ACCUMULATION 
                totalPointsWonInteger += pointsWon;
                if (selectedPlayerPlaysLeftInt <= 0)   //SELECTED PLAYERS PLAYS LEFT <= 0 
                {
                    if (totalPointsWonInteger > 0)     //TOTAL POINTS WON INTEGER > 0 
                    {
                        //MESSAGE BOX: COIN FLIP MESSAGE 
                        MessageBox.Show("Flip a Coin to Determine Number of Wins","FLIP A COIN MESSAGE",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                        totalNumberOfWins = 0;       //SETS TOTAL NUMBER OF WINS TO 0  
                        tossButton.Enabled = true;   //TOSS BUTTON IS ENABLED  
                    }
                }
            }
                else
                {
                    //MESSAGE BOX: NO PLAYS LEFT MESSAGE 
                    MessageBox.Show("No Plays Left.","PLAYS LEFT MESSAGE",
                                     MessageBoxButtons.OK,MessageBoxIcon.Information);
                    playButton.Enabled = false;   //PLAY BUTTON IS DISABLED 
                }

            //POINTS WON LABEL 
            pointsWonLabel.Text = "POINTS WON " + totalPointsWonInteger;

            int myRandomInteger;      //ACCEPTS MY RANDOM INTEGER 

            //TOTAL POINTS WON AVERAGE 
            myRandomInteger = rndNumber.Next();
        }

        //NUMBER OF COIN FLIPS METHOD 
        private void numberOfCoinFlips()
        {  
            if (totalPointsWonInteger > 70)        //TOTAL POINTS WON INTEGER > 70 
            {
                totalFlips = 12;                   //TOTAL FLIPS = 12 
            }
            else
            {
                if (totalPointsWonInteger > 40)   //TOTAL POINTS WON INTEGER > 40 
                {
                    totalFlips = 8;               //TOTAL FLIPS = 8
                }
                else
                {
                    if (totalPointsWonInteger > 20) //TOTAL POINTS WON INTEGER > 20 
                    {
                        totalFlips = 5;             //TOTAL FLIPS = 5 
                    } 
                    else
                    {
                        if (totalPointsWonInteger > 10) //TOTAL POINTS WON INTEGER > 10
                        {
                            totalFlips = 3;             //TOTAL FLIPS = 3 
                        }
                        else
                        {
                            if (totalPointsWonInteger > 1) //TOTAL POINTS WON INTEGER > 1 
                            {
                                totalFlips = 1;            //TOTAL FLIPS = 1 
                            }
                            else
                            {
                                totalFlips = 0;           //TOTAL FLIPS = 0 
                            }
                        }
                    }
                }
            }
        } 

        //DISPLAY CARDS METHOD                 
        private void displayCards()   
        {
            //CASE SWITCH 1ST RANDOM INTEGER 
            switch (oneRandInteger)  
            { 
                case 0:
                    spin1PictureBox.Image = Properties.Resources.AceofHearts; 
                    //SPIN 1: ACE OF HEARTS CARD 
                    break;
                case 1:
                    spin1PictureBox.Image = Properties.Resources.JackofDiamonds; 
                    //SPIN 1: JACK OF DIAMONDS 
                    break;
                case 2:
                    spin1PictureBox.Image = Properties.Resources.QueenofSpades; 
                    //SPIN 1: QUEEN OF SPADES 
                    break; 
            }

            //CASE SWITCH 2ND RANDOM INTEGER 
            switch (twoRandInteger)
            {
                case 0:
                    spin2PictureBox.Image = Properties.Resources.AceofHearts;
                    //SPIN 2: ACE OF HEARTS 
                    break;
                case 1:
                    spin2PictureBox.Image = Properties.Resources.JackofDiamonds;
                    //SPIN 2: JACK OF DIAMONDS 
                    break;
                case 2:
                    spin2PictureBox.Image = Properties.Resources.QueenofSpades;
                    //SPIN 2: QUEEN OF SPADES 
                    break;
            }

            //CASE SWITCH 3RD RANDOM INTEGER 
            switch (threeRandInteger)
            {
                case 0:
                    spin3PictureBox.Image = Properties.Resources.AceofHearts;
                    //SPIN 3: ACE OF HEARTS 
                    break;
                case 1:
                    spin3PictureBox.Image = Properties.Resources.JackofDiamonds;
                    //SPIN 3: JACK OF DIAMONDS 
                    break;
                case 2:
                    spin3PictureBox.Image = Properties.Resources.QueenofSpades;
                    //SPIN 3: QUEEN OF SPADES 
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
                //IF STATEMENT: COMBOBOX ITEMS PLUS INDEX AND TOUPPER METHOD 
                if (playerNameComboBox.Text.ToUpper() == playerNameComboBox.Items[indexInt].
                    ToString().ToUpper())
                {
                    searchBoolean = true;      //SETS BOOLEAN SEARCH TO TRUE 
                    indexInt = playerNameComboBox.Items.Count; 
                    //COMBOBOX INDEX...ITEMS...COUNT 
                }  
                indexInt++;   //INCREMENTS INDEX INTEGER 
            }
        }

        /*ADD PLAYER BUTTON EVENT HANDLER*/
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            //IF STATEMENT: PLAYER NAME COMBOBOX 
            if (playerNameComboBox.Text.Trim() != string.Empty)
                    {
                        //ADDING ITEMS TO THE PLAYER NAME COMBOBOX 
                        //COMBO BOX RESET TEXT 
                        //NUMBER OF TURNS TEXT BOX = EMPTY 
                        playerNameComboBox.Items.Add(playerNameComboBox.Text +  ", 0 ");
                        playerNameComboBox.ResetText();
                        numberOfTurnsTextBox.Text = string.Empty; 
                    }
            else
            {
                //MESSAGE BOX: NAME INPUT ERROR & FOCUSES COMBO BOX 
                MessageBox.Show("Enter a Player Name First", "Name Input Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                playerNameComboBox.Focus();     //FOCUSES METHOD COMBO BOX 
                playerNameComboBox.SelectAll(); //SELECTS ALL METHOD COMBO BOX 
            }
        }

        /*REMOVE PLAYER BUTTON EVENT HANDLER*/
        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            //IF STATEMENT: COMBO BOX INDEX SELECTION 
            if (playerNameComboBox.SelectedIndex > -1)
                playerNameComboBox.Items.Remove(playerNameComboBox.SelectedItem);
            else
                //MESSAGE BOX: NAME INPUT ERROR 
                MessageBox.Show("Select a Player Name First!","Add Name Input Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*NEW PLAYER BUTTON EVENT HANDLER*/
        private void newPlayerButton_Click(object sender, EventArgs e)
        {
            //COMBO BOX --SELECTED INDEX > -1 
            if (playerNameComboBox.SelectedIndex > -1)
            {
                //TURNS TEXT BOX = EMPTY 
                if (numberOfTurnsTextBox.Text.Trim() != string.Empty)
                {
                    try
                    {
                        //NUMBER OF PLAYS INTEGER - PARSE METHOD TEXTBOX 
                        numberOfPlaysInteger = int.Parse(numberOfTurnsTextBox.Text.Trim());
                        selectedPlayerPlaysLeftInt = numberOfPlaysInteger;   

                        if (selectedPlayerPlaysLeftInt > 0)
                        {
                            //The spin button can work now 
                            playerSelectedIndexInteger = playerNameComboBox.SelectedIndex; 
                            playButton.Enabled = true;
                            playerNameComboBox.Enabled = false;
                            numberOfTurnsTextBox.Enabled = false; 
                            totalPointsWonInteger = 0; 
                        }
                        else   
                        {
                            //MESSAGE BOX: NUMBER OF PLAYS GREATER THAN 0 
                            MessageBox.Show("Number of Plays Needs to be Greater than Zero!",
                                "GREATER THAN ZERO ERROR!",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                     }
                       catch
                    {
                        //MESSAGE BOX: NUMBER OF TURNS INTEGER 
                        MessageBox.Show("Please enter an Integer for Number of Turns!", "INTEGER INPUT ERRROR", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //MESSAGE BOX: NUMBER OF TURNS NUMBER ERROR 
                    MessageBox.Show("Please Enter a Numeric Value for Number of Turns!", "NUMBER INPUT ERROR", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MESSAGE BOX: PLAYER NAME INPUT ERROR 
                MessageBox.Show("Enter a Player Name First", "Name Input Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                playerNameComboBox.Focus();
                playerNameComboBox.SelectAll();
            }
          }

        /*PRIZE TOTALS BUTTON EVENT HANDLER*/
        private void prizeTotalsButton_Click(object sender, EventArgs e)
        {  
           //MESSAGE BOX: MANAGEMENT TOTALS INCLUDES ACCUMULATION INTEGERS 
           DialogResult dialogResult = MessageBox.Show("This message will show prize totals:" + 
               Environment.NewLine + 
               Environment.NewLine + 
               "Amazon Gift Card:  " + totalAmazonGiftcardWonInteger + Environment.NewLine + 
               "Headphones:  "+ totalHeadPhonesWonInteger + Environment.NewLine + 
               "Apple TV:  " + totalAppleTVsWonInteger + Environment.NewLine + 
               "Google I-Home:  " + totalGoogleIHomesWonInteger + Environment.NewLine + 
               "I-Pad:  " + totalIPadsWonInteger + Environment.NewLine + 
               "Acer Laptop:  " + totalAcerLaptopsWonInteger + 
               Environment.NewLine + Environment.NewLine + "Do You Wish to Reset Prize Totals to 0?" + 
               Environment.NewLine, 
               "MANAGEMENT TOTALS", 
               MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //IF STATEMENT DIALOG RESULT RESETS ACCUMULATORS TO ZERO 
            if (dialogResult == DialogResult.Yes)
            {
                totalAmazonGiftcardWonInteger = 0;
                totalHeadPhonesWonInteger = 0;
                totalAppleTVsWonInteger = 0;
                totalGoogleIHomesWonInteger = 0;
                totalIPadsWonInteger = 0;
                totalAcerLaptopsWonInteger = 0; 
            }
         }
        
        /*SAVE DATA BUTTON EVENT HANDLER*/
        private void saveDataButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = "*.txt";

            DialogResult saveDialogResult; 
            saveDialogResult = saveFileDialog.ShowDialog();

            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (saveDialogResult == DialogResult.OK)

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputListFile = File.CreateText(saveFileDialog.FileName);
                    NameFileString = saveFileDialog.FileName;
                    outputListFile.Close();
                }
                else
                {
                    MessageBox.Show("This Save is Cancelled!","SAVE CANCELLED MESSAGE!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 

        /*PLAYER REPORT BUTTON EVENT HANDLER*/ 
        private void playerReportButton_Click(object sender, EventArgs e)
        {
            //PLAYER REPORT LABEL: OUTPUTS TOTAL PLAYERS, TOTAL WINS, AND AVERAGE WINS 
            playerReportLabel.Text = "NAME" + "              " 
                + "WINS" + 
                Environment.NewLine +   "_____________________________" + 
                Environment.NewLine +   
                Environment.NewLine +
                "Total Players: " + Environment.NewLine +
                "Total Wins: " + Environment.NewLine +
                "Average Wins: " + Environment.NewLine + Environment.NewLine;
        }
          
        /*TOSS BUTTTON EVENT HANDLER: COIN TOSS PICTURES*/
        private void tossButton_Click(object sender, EventArgs e)
        {
            //NUMBER OF COIN FLIPS METHOD 
            numberOfCoinFlips();
            totalNumberOfWins = 0; 
            tossButton.Enabled = false; //SETS TOSS BUTTON TO FALSE 
            playerNameComboBox.Enabled = true;
            numberOfTurnsTextBox.Enabled = true; 
            int coinX = 0;
            tossOutcomeLabel.Text = "Toss Outcome Report: " + Environment.NewLine + Environment.NewLine; 
            do
            {
                coinX++; // COIN X INCREMENT...
                //TOSS LABEL 
                tossOutcomeLabel.Text += "Toss Number: " + coinX;
                sideUp = rand.Next(2);

                //IF STATEMENT 
                if (sideUp == 1)  
                {
                   tossOutcomeLabel.Text += "Toss Lost " + Environment.NewLine; 
                 }
                else  
                {
                   
                    totalNumberOfWins++;  
                    tossOutcomeLabel.Text += " This is a Win! " + totalNumberOfWins + Environment.NewLine;   
                }
                        

            }
            while (coinX < totalFlips);
            prizeMethod();
            updatePlayerWins();
            playerNameComboBox.Focus(); 
            numberOfTurnsTextBox.Text = string.Empty; 
        }

        //PLAYER WINS METHOD 
        private void updatePlayerWins()
        {
            if (totalNumberOfWins > 0)
            {
                //SPLIT METHOD USED FOR COMBOBOX 
                var fields = playerNameComboBox.Items[playerSelectedIndexInteger].ToString().Split(',');
                string nameString = fields[0]; 
                int winInteger = int.Parse(fields[1]);
                winInteger++; 
              
                playerNameComboBox.Items.RemoveAt(playerSelectedIndexInteger);
                playerNameComboBox.Items.Add(nameString + ", " + winInteger);
                

            }

        }
        //PRIZE METHOD 
        private void prizeMethod()
        {
            if (totalNumberOfWins > 0)
            {


                //SWITCH STATEMENT TOTAL NUMBER OF WINS 
                switch (totalNumberOfWins / 2)
                {
                    case 0:
                        prizesPictureBox.Image = Properties.Resources.Amazon_Giftcard_prize1;
                        prizeNameLabel.Text = "You won an Amazon Gift Card!";
                        totalAmazonGiftcardWonInteger++;
                        break;
                    case 1:
                        prizesPictureBox.Image = Properties.Resources.Headphoneprize2;
                        prizeNameLabel.Text = "You won a Headphone Set!";
                        totalHeadPhonesWonInteger++;
                        break;
                    case 2:  
                        prizesPictureBox.Image = Properties.Resources.AppleTV_prize3;
                        prizeNameLabel.Text = "You won an Apple TV!";
                        totalAppleTVsWonInteger++;
                        break;
                    case 3:
                        prizesPictureBox.Image = Properties.Resources.Google_IHome_prize4;
                        prizeNameLabel.Text = "You won a Google I-Home!";
                        totalGoogleIHomesWonInteger++;
                        break;
                    case 4:
                        prizesPictureBox.Image = Properties.Resources.I_Pad_Prize5;
                        prizeNameLabel.Text = "You won an I-Pad!";
                        totalIPadsWonInteger++;
                        break;
                    default:
                        prizesPictureBox.Image = Properties.Resources.ACER_Laptop_Prize6;
                        prizeNameLabel.Text = "You won an ACER Laptop!";
                        totalAcerLaptopsWonInteger++;
                        break;

                }
            }
            else
            {
                prizesPictureBox.Image = Properties.Resources.Lost_Game; 
                prizeNameLabel.Text = "Sorry, You Lost!"; 
            } 
        }


        private void playerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spin1PictureBox_Click(object sender, EventArgs e)
        {

        }
        /*EXIT BUTTON EVENT HANDLER: Closes the Program*/
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
