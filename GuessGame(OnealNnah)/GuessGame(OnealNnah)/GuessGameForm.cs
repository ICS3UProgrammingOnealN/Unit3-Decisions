using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame_OnealNnah_
{
    public partial class GuessGameForm : Form
    {
        public GuessGameForm()
        {
            InitializeComponent();
        }

        private void GuessGameForm_Load(object sender, EventArgs e)
        {

        }

        private void lblnumber_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            // declare constant and variable
            const int integer = 7;
            int Guess;

            // get the integer from the textbox 
            Guess = int.Parse(txtGuess.Text);

            // If the number is not the correct answer display wrong
            if(integer is  incorrect)
            lblAnswer.Show();
        }
    }
}
