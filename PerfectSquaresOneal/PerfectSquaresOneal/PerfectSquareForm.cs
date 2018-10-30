using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquaresOneal
{
    public partial class frmPerfectSquare : Form
    {
        public frmPerfectSquare()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local value
            int endingValue;
            int Value;
            double squareRootAsDouble;
            int squareRootAsInteger;

            // ste initial value

            // mget the user's end value selection from the Number Up Down Box
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            // continue starting any perfect squares between the minimum and the user's selecyed end value
            while (value <= endingValue) ;

            // take the square root of the value
            squareRootAsDouble = Math.Sqrt(value);

            // convert the double to an integer 
            squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

            // the only way for both the decimal and the integer to be equal is if the value was a perfect square 
            if (squareRootAsInteger == squareRootAsDouble) 

            // the only way for both the decimal and the integer 
        }
    }
}
