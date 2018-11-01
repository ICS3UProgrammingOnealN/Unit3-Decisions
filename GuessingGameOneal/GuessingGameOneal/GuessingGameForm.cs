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
            // declaring the constants and variable 
            int GuessNumber;
            const int NUMBER = 7;

            GuessNumber = int.Parse(txtGuess.Text);

            //if the number of student is The same as The Number Display "correct"
            if (GuessNumber == NUMBER)
            {
                lblAnswer.Text =


        }
    }
}
