using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachOneal
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            // loop through each object on the form and make it green
            foreach  (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;

                //if the object is a label, make it yellow
                if (aControlObject.GetType() == typeof(Object)) ;
                {
                    aControlObject.BackColor = Color.Yellow;
                }
            }
            
        }

        private void Object_Click(object sender, EventArgs e)
        {
            //if the object is a label, make it blue
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.;
                if (aControlObject.GetType() == typeof(object)) ;
            {
                    aControlObject.BackColor = Color.Blue;
            }

        }
        



