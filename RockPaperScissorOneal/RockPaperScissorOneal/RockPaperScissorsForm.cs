/*
 * Created by: Oneal nnah
 * Created on: 16th October 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program Plays rock, paper, scissors 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorOneal
{
    public partial class frmRockPaperScissors : Form
    {
        // declare global variable or constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;


        public frmRockPaperScissors()
        {
            InitializeComponent();
        }

        private void radPlayerRock_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {
            // create the random number generator object
            randomNumberGenerator = new Random();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // declare local variable and constant
            int playerChoice = 1;
            int computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            // get the user's selection, if there is no selection set it to 0
            if (radPlayerRock.Checked == true)
            {
                playerChoice = ROCK;
                
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radPlayerScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }
            // randomly generate a number between 1 and 3 representing ROCK, PAPER or SCISSORS
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set the radio button for the computer"s choice
            if (computerChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }
            else if (computerChoice == SCISSORS)
            {
                this.radComputerScissors.Checked = true;
            }
        }
    }
}
