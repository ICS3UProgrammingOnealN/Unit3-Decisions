using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameOneal
{
    public partial class GuessingGameForm : Form
    {
        public GuessingGameForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare the constants and variables
            const int integer = 7;
            int Guess;

            // get the integer from the textbox 
            Guess = int.Parse(txtGuess.Text);

            // If the number is not the correct answer display wrong
            if (Guess < 7)
            if (Guess > 7)
            
        }
    }
}
