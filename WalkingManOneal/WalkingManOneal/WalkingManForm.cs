﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkingManOneal
{
    public partial class WalkingManForm : Form
    {
        public WalkingManForm()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter =1


            while(pictureFrameCounter < MAX_FRAMES +1)
                if (pictureFrameCounter == 1)
                {
                    this.picWalkingMan 
                }

