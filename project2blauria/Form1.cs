using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Brandi Lauria
//COP 2010 - Project 2
//
//Player 1 Inputs Word to guess and number of guesses given to player 2 clears the field of the word player 1 entered that player 2 must guess.
//Puts equals signs in the amount per the length of the Word player 1 entered so player 2 can see the length of the word and displays 
//the amount of incorrect guess allowed by Player 2.
//allows Player 1 to enter the letter they would like to guess but only allows one character to go through the program.
//if two characters entered error message appears.
//if player 2 enters the correct letter replace letter in position in the textbox displaying equal signs characters for word entered by Player 1 
//and display message saying you have chosen the correct letter in the listbox.
//If player enters the wrong letter output in listbox wrong letter chosen and countdown the number of guesses
//When the Word has been unhidden meaning changed from equals signs to complete word output message box you won.
//When guess countdown reaches 0 output error message telling the player that they have lost.
//
//March 7, 2017
namespace project2blauria
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        //Variables Declared for Switch
        int intNumberOfGuesses;
        int intGuessesRemaining;
        //Variables Declared for Word to be guessed


        private void cboNumberOfGuesses_SelectedIndexChanged(object sender, EventArgs e)
        {//begin method

            //Number of Guesses to integers
            intNumberOfGuesses = int.Parse(cboNumberOfGuesses.Text);

            //Switch statement for Combobox to pull Guess allowed
            switch (intNumberOfGuesses)
            {//begin switch statement for cbo box
                case 3:
                    intGuessesRemaining = 3;
                    break;
                case 5:
                    intGuessesRemaining = 5;
                    break;
                case 10:
                    intGuessesRemaining = 10;
                    break;
                case 15:
                    intGuessesRemaining = 15;
                    break;
            }//end switch statement for cbo box

            //Display result
           txtGuessesRemaining.Text = intGuessesRemaining.ToString();

        }//end method
        //field variables
        string strEnterWord = "";
        string strnewDash = "";
        private void btnEnterWordToGuess_Click(object sender, EventArgs e)
        {//begin method


            //Get input data from textbox
            strEnterWord = (txtEnterWordToGuess.Text);
            strEnterWord.ToString();
            //retrieve the length of the word
            strEnterWord.Substring(strEnterWord.Length);

            //put in = sign for string length
            strnewDash = new string('=', strEnterWord.Length);
            // display = in length of word entered
            (txtWordToGuess.Text) = strnewDash;
            //Clear text so Player 2 can't see
            txtEnterWordToGuess.Clear();

        }//end method


        private void btnEnterLetter_Click(object sender, EventArgs e)
        {//begin method

            //local variables
            string strLetterEntered = "";
            string strWord;
            int position;
            bool blnGameOver;
            //get text from box text box
            strLetterEntered = (txtEnterLetter.Text);
            strWord = (strEnterWord);

            



            //if text is not one character loop- error message
            if ((txtEnterLetter.Text.Length == 0 || (txtEnterLetter.Text.Length >= 2)))
            {// if decision begins if letter longer than one character display an error message
                MessageBox.Show("Enter one character only please try again");
                return;
            }//if decision statement end


            //Local Variables
            int intGuessCountDown;
            intGuessCountDown = int.Parse(txtGuessesRemaining.Text);
            if (!strWord.Contains(strLetterEntered) && intGuessCountDown > 0)

            { // if letter entered is not contained in word
                //listbox message letter wasn't found please guess again
                lstYouGuessed.Items.Add(strLetterEntered + " wasn't found - please guess again");
                //remaining guesses count--
                intGuessCountDown--;
                //Display countdown
                txtGuessesRemaining.Text = intGuessCountDown.ToString();
            }//if decision statement end

            if (intGuessCountDown == 0)
            {//if decision statement begins if - guess countdown reaches zero 
            //game over you lost
                MessageBox.Show("Game Over - You Lost");
          
                blnGameOver = true;
                return;
            }//if decision statement end



            //if letter guessed is in mysteryword
            if (strWord.Contains(strLetterEntered) && txtEnterWordToGuess.Text != strWord)

            {// begin decision of if statement if the letter is contained in the word and is not unhidden then
                //tell them they guessed correctly and make a new string that recieves the letter entered in hidden word
                // and output correct guess
                lstYouGuessed.Items.Add(" You guessed the letter " + strLetterEntered + " correctly!");

                StringBuilder sb = new StringBuilder(txtWordToGuess.Text);
                position = strEnterWord.IndexOf(strLetterEntered);
                sb.Remove(position, 1);
                sb.Insert(position, strLetterEntered);
                txtWordToGuess.Text = sb.ToString();

            }//end decision of if statement

            //listbox message you guessed the letter "" correctly!
            if (txtWordToGuess.Text == strWord)
            {//begin decision of if statement if Word to guess is uncovered they won
                MessageBox.Show("You Won - Congratulations");
                return;
            }//end decision of if statement

        }//end method


    }//end class
}//namespace