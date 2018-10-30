using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorsDoWhileOneal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variable
            Double factorialAnswer;
            Double factorialNumber;
            int FactorialCounter;

            // clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            // initialize the final answer to 1


            //get the number from the user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            // set the counter to 0\
            FactorialCounter = 0


            // multiply the counter by the next incremented mumber until it reaches the user's number 


            // increment the counter by 1


            // list the counter number in the listbox for the user to see


            // multiply the counter by the answer 


        } while (

            // convert the FactorialAnswer to a string and insert it into the label
            this.lblFactorialAnswer.Text = this.txtNumber.Text + "! =" + Convert.ToString(factorialAnswer);


        }
    }
}
