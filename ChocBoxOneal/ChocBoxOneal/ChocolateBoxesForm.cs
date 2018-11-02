using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocBoxOneal
{
    public partial class ChocolateBoxesForm : Form
    {
        public ChocolateBoxesForm()
        {
            InitializeComponent();
        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            const int MAX_value = 20, MIN_VALUE = 0, MED_VALUE = 10;
            int chocolatebox;

            chocolatebox = int.Parse(nudNumber.Text);

            if (MAX_value < chocolatebox)
                lblAward.Text = "you get a prize";
            else if (MED_VALUE < chocolatebox)
                lblAward.Text = "you get a small prize";
            else if (MIN_VALUE < chocolatebox)
                lblAward.Text = "Good Try";
            else if (MIN_VALUE == chocolatebox)
                lblAward.Text = "sell a chocolate box next time";
        }

        private void ChocolateBoxesForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
