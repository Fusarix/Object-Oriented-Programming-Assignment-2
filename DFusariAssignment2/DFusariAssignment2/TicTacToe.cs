using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TicTacToe.cs
// The game of tic tac toe, using picture boxes
//
// October 06 / 2016 -- Project created. Form completed and the code for one picture box to display an image completed
// October 07 / 2016 -- Added code for each picture box, wrote the new game and check winner functions, 
// as well as added comments to complete the project
//
//      Derek Fusari 7315799, 2016.10.06: Created

namespace DFusariAssignment2
{ 
    /// <summary>
    /// Creates and initializes the class frmTicTacToe
    /// </summary>
    public partial class frmTicTacToe : Form
    {

        //Two instance variables used to keep track of the player turn
        bool playerXTurn = true;
        bool playerOTurn = false;

        /// <summary>
        /// Initializes the form as well as sets the default value as a blank string instead 
        /// of null for comparison, so the program does not crash when trying to compare a null value
        /// </summary>
        public frmTicTacToe()
        {
            InitializeComponent();
            picTopLeft.Tag = "";
            picTopMid.Tag = "";
            picTopRight.Tag = "";
            picMidLeft.Tag = "";
            picMidMid.Tag = "";
            picMidRight.Tag = "";
            picBotLeft.Tag = "";
            picBotMid.Tag = "";
            picBotRight.Tag = "";
        }

        /// <summary>
        /// Re-initializes all components of the game once a player has won, to allow them to play again
        /// </summary>
        public void NewGame()
        {
            picTopLeft.Tag = "";
            picTopMid.Tag = "";
            picTopRight.Tag = "";
            picMidLeft.Tag = "";
            picMidMid.Tag = "";
            picMidRight.Tag = "";
            picBotLeft.Tag = "";
            picBotMid.Tag = "";
            picBotRight.Tag = "";

            picTopLeft.Image = null;
            picTopMid.Image = null;
            picTopRight.Image = null;
            picMidLeft.Image = null;
            picMidMid.Image = null;
            picMidRight.Image = null;
            picBotLeft.Image = null;
            picBotMid.Image = null;
            picBotRight.Image = null;

            playerXTurn = true;
            playerOTurn = false;
        }

        /// <summary>
        /// Checks each possible combonation for a winner, if all of the picture boxes
        /// contain an image, and a winner has not been declared,it is a draw
        /// </summary>
        public void CheckWinner()
        {
                //Compares each picture box tag for every combination in order to declare a winner
                if (picTopLeft.Tag.ToString() == "X" && picTopMid.Tag.ToString() == "X" && picTopRight.Tag.ToString() == "X")
                {
                    MessageBox.Show("X Wins.");
                    NewGame();
                }
                else if (picMidLeft.Tag.ToString() == "X" && picMidMid.Tag.ToString() == "X" && picMidRight.Tag.ToString() == "X")
                {
                    MessageBox.Show("X Wins.");
                    NewGame();
                }
                else if (picBotLeft.Tag.ToString() == "X" && picBotMid.Tag.ToString() == "X" && picBotRight.Tag.ToString() == "X")
                {
                    MessageBox.Show("X Wins.");
                    NewGame();
                }
                else if (picTopLeft.Tag.ToString() == "X" && picMidLeft.Tag.ToString() == "X" && picBotLeft.Tag.ToString() == "X")
                {
                    MessageBox.Show("X Wins.");
                    NewGame();
                }
                else if (picTopMid.Tag.ToString() == "X" && picMidMid.Tag.ToString() == "X" && picBotMid.Tag.ToString() == "X")
                {
                    MessageBox.Show("X Wins.");
                    NewGame();
                }
                else if (picTopRight.Tag.ToString() == "X" && picMidRight.Tag.ToString() == "X" && picBotRight.Tag.ToString() == "X")
                {
                    MessageBox.Show("X Wins.");
                    NewGame();
                }
                else if (picTopLeft.Tag.ToString() == "X" && picMidMid.Tag.ToString() == "X" && picBotRight.Tag.ToString() == "X")
                {
                    MessageBox.Show("X Wins.");
                    NewGame();
                }
                else if (picTopRight.Tag.ToString() == "X" && picMidMid.Tag.ToString() == "X" && picBotLeft.Tag.ToString() == "X")
                {
                    MessageBox.Show("X Wins.");
                    NewGame();
                }

                else if (picTopLeft.Tag.ToString() == "O" && picTopMid.Tag.ToString() == "O" && picTopRight.Tag.ToString() == "O")
                {
                    MessageBox.Show("O Wins.");
                    NewGame();
                }
                else if (picMidLeft.Tag.ToString() == "O" && picMidMid.Tag.ToString() == "O" && picMidRight.Tag.ToString() == "O")
                {
                    MessageBox.Show("O Wins.");
                    NewGame();
                }
                else if (picBotLeft.Tag.ToString() == "O" && picBotMid.Tag.ToString() == "O" && picBotRight.Tag.ToString() == "O")
                {
                    MessageBox.Show("O Wins.");
                    NewGame();
                }
                else if (picTopLeft.Tag.ToString() == "O" && picMidLeft.Tag.ToString() == "O" && picBotLeft.Tag.ToString() == "O")
                {
                    MessageBox.Show("O Wins.");
                    NewGame();
                }
                else if (picTopMid.Tag.ToString() == "O" && picMidMid.Tag.ToString() == "O" && picBotMid.Tag.ToString() == "O")
                {
                    MessageBox.Show("O Wins.");
                    NewGame();
                }
                else if (picTopRight.Tag.ToString() == "O" && picMidRight.Tag.ToString() == "O" && picBotRight.Tag.ToString() == "O")
                {
                    MessageBox.Show("O Wins.");
                    NewGame();
                }
                else if (picTopLeft.Tag.ToString() == "O" && picMidMid.Tag.ToString() == "O" && picBotRight.Tag.ToString() == "O")
                {
                    MessageBox.Show("O Wins.");
                    NewGame();
                }
                else if (picTopRight.Tag.ToString() == "O" && picMidMid.Tag.ToString() == "O" && picBotLeft.Tag.ToString() == "O")
                {
                    MessageBox.Show("O Wins.");
                    NewGame();
                }

                //If every picture box has an image, it is a draw
                else if (picTopLeft.Image != null && picTopMid.Image != null && picTopRight.Image != null &&
                    picMidLeft.Image != null && picMidMid.Image != null && picMidRight.Image != null && 
                        picBotLeft.Image != null && picBotMid.Image != null && picBotRight.Image != null)
                {
                    MessageBox.Show("It is a draw.");
                    NewGame();
                }
            }
        
        /// <summary>
        /// When top left picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picTopLeft_Click(object sender, EventArgs e)
        {
            //If its player x's turn, and there is no image in the clicked box
            //change the image, switch turns and assign the picture box tag to x
            if (playerXTurn == true && picTopLeft.Image == null)
            {
                picTopLeft.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picTopLeft.Tag = "X";
            }
            //If the picture box already has an image, tell the user to chose a different spot
            else if (picTopLeft.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }

            //If its player o's turn, and there is no image in the clicked box
            //change the image, switch turns and assign the picture box tag to o
            else if (playerOTurn == true && picTopLeft.Image == null)
            {
                picTopLeft.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picTopLeft.Tag = "O";
            }
            //If the picture box already has an image, tell the user to chose a different spot
            else if (picTopLeft.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            //Calls the check winner function to see if someone has won the game with this particular move
            CheckWinner();
        }

        /// <summary>
        /// When top mid picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picTopMid_Click(object sender, EventArgs e)
        {        
            if (playerXTurn == true && picTopMid.Image == null)
            {
                picTopMid.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picTopMid.Tag = "X";
            }
            else if (picTopMid.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            else if (playerOTurn == true && picTopMid.Image == null)
            {
                picTopMid.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picTopMid.Tag = "O";
            }
            else if (picTopMid.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            CheckWinner();
        }

        /// <summary>
        /// When top right picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picTopRight_Click(object sender, EventArgs e)
        {
            if (playerXTurn == true && picTopRight.Image == null)
            {
                picTopRight.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picTopRight.Tag = "X";
            }
            else if (picTopRight.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            else if (playerOTurn == true && picTopRight.Image == null)
            {
                picTopRight.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picTopRight.Tag = "O";
            }
            else if (picTopRight.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            CheckWinner();
        }

        /// <summary>
        /// When mid left picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMidLeft_Click(object sender, EventArgs e)
        {
            if (playerXTurn == true && picMidLeft.Image == null)
            {
                picMidLeft.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picMidLeft.Tag = "X";
            }
            else if (picMidLeft.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            else if (playerOTurn == true && picMidLeft.Image == null)
            {
                picMidLeft.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picMidLeft.Tag = "O";
            }
            else if (picMidLeft.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            CheckWinner();
        }

        /// <summary>
        /// When the center picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMidMid_Click(object sender, EventArgs e)
        {
            if (playerXTurn == true && picMidLeft.Image == null)
            {
                picMidMid.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picMidMid.Tag = "X";
            }
            else if (picMidMid.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            else if (playerOTurn == true && picMidMid.Image == null)
            {
                picMidMid.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picMidMid.Tag = "O";
            }
            else if (picMidMid.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            CheckWinner();
        }

        /// <summary>
        /// When mid right picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMidRight_Click(object sender, EventArgs e)
        {
            if (playerXTurn == true && picMidRight.Image == null)
            {
                picMidRight.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picMidRight.Tag = "X";
            }
            else if (picMidRight.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            else if (playerOTurn == true && picMidRight.Image == null)
            {
                picMidRight.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picMidRight.Tag = "O";
            }
            else if (picMidRight.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            CheckWinner();
        }

        /// <summary>
        /// When bot left picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBotLeft_Click(object sender, EventArgs e)
        {

            if (playerXTurn == true && picBotLeft.Image == null)
            {
                picBotLeft.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picBotLeft.Tag = "X";
            }
            else if (picBotLeft.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            else if (playerOTurn == true && picBotLeft.Image == null)
            {
                picBotLeft.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picBotLeft.Tag = "O";
            }
            else if (picBotLeft.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            CheckWinner();
        }

        /// <summary>
        /// When bot mid picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBotMid_Click(object sender, EventArgs e)
        {
            if (playerXTurn == true && picBotMid.Image == null)
            {
                picBotMid.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picBotMid.Tag = "X";
            }
            else if (picBotMid.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            else if (playerOTurn == true && picBotMid.Image == null)
            {
                picBotMid.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picBotMid.Tag = "O";
            }
            else if (picBotMid.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            CheckWinner();
        }

        /// <summary>
        /// When bot right picture box is clicked, it displays an x or o depending
        /// on the player's turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBotRight_Click(object sender, EventArgs e)
        {
            if (playerXTurn == true && picBotRight.Image == null)
            {
                picBotRight.Image = DFusariAssignment2.Properties.Resources.orangex;
                playerXTurn = false;
                playerOTurn = true;
                picBotRight.Tag = "X";
            }
            else if (picBotRight.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            else if (playerOTurn == true && picBotRight.Image == null)
            {
                picBotRight.Image = DFusariAssignment2.Properties.Resources.orangeo;
                playerXTurn = true;
                playerOTurn = false;
                picBotRight.Tag = "O";
            }
            else if (picBotRight.Image != null)
            {
                MessageBox.Show("That sqaure has already been chosen! Please choose a different square.");
            }
            CheckWinner();
        }
    }
}
