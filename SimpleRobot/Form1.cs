// Amber Holcomb-Stone
// Lab 4: Direct a Simple Robot per specs provided.
// Directional button code modified from: https://www.codeproject.com/Questions/840434/How-to-move-label-position-up-down-right-and-left
// Code modified and adapted from: https://github.com/tyang1/Microsoft-C--SWE1/blob/master/Small%20Robot/robot/Form1.cs


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRobot
{
    public partial class frmRobot : Form
    {
        Robot bot = new Robot();
        public frmRobot()
        {
            InitializeComponent();
        }

        //when clicked the arrow should face in North direction
        private void btnNorth_Click(object sender, EventArgs e)
        {
            bot.direction = Direction.North;
            lblArrow.Text = bot.ToString();
        }

        //when clicked the arrow should face in South direction
        private void btnSouth_Click(object sender, EventArgs e)
        {
            bot.direction = Direction.South;
            lblArrow.Text = bot.ToString();
        }

        //when clicked the arrow should face in East direction
        private void btnEast_Click(object sender, EventArgs e)
        {
            bot.direction = Direction.East;
            lblArrow.Text = bot.ToString();
        }

        //when clicked the arrow should face in West direction
        private void btnWest_Click(object sender, EventArgs e)
        {
            bot.direction = Direction.West;
            lblArrow.Text = bot.ToString();
        }

        //when clicked the arrow label control should advance one unit
        private void btnGo1_Click(object sender, EventArgs e)
        {
            bot.move(1);
            lblArrow.Location = bot.location;
            lblCoords.Text = bot.GetFormattedLocation();
            if (bot.location.X < 260 && bot.location.X > 60 && bot.location.Y < 251 && bot.location.Y > 51)
            {
                pnlArena.Focus();
            }
            //message box should show when arrow label control if range is met or there is an attempt to exceed range
            else
            {
                MessageBox.Show("You have reached the maximum units going " + bot.direction);
            }
        }

        //when clicked the arrow label control should advance ten units
        private void btnGo10_Click(object sender, EventArgs e)
        {
            bot.move(10);
            lblArrow.Location = bot.location;
            lblCoords.Text = bot.GetFormattedLocation();
            if (bot.location.X < 260 && bot.location.X > 60 && bot.location.Y < 251 && bot.location.Y > 51)
                {
                pnlArena.Focus();
            }
            //message box should show when arrow label control if range is met or there is an attempt to exceed range
            else
            {
                MessageBox.Show("You have reached the maximum units going " + bot.direction);
            }
        }

        //closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //instantiates a robot object
        //displays arrow in center of screen with initial coordinates 0,0
        //displays initial arrow coordinates 0,0
        private void frmRobot_Load(object sender, EventArgs e)
        {
            lblArrow.Text = bot.ToString();
            bot.location = lblArrow.Location;
            pnlArena.Controls.Add(lblArrow);
            lblCoords.Text = bot.GetFormattedLocation();
        }
    }
}
