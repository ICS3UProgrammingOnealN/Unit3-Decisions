/*
 * Created by:Oneal Nnah
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Name of Program
 * This program...
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

namespace NestedLoopsOneal
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare the local variable\
            int firstLetter;
            int secondletter;

            // cleaar listbox
            this.lstNumbers.Items.Clear();

            // convert the numbers to characters

            // loop through the numbers from 0 to 10
            for (firstLetter=0; firstLetter<=20; firstLetter++)
            {
                // for each of the numbers above, loop through again writing beside it the second number from 0 to 10
                for (secondletter = 0; secondletter <= 10; secondletter++) ;
                {
                    this.lstNumbers.Items.Add(firstLetter + "->" + secondletter);
                }
            }

            }
        }
    }
}
