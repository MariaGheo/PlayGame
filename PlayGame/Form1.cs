using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of Thread.Sleep()

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            //make button "disappear"
            playGameButton.Visible = false;

            //change the countdownLabel text to begin countdown
            countdownLabel.Text = "Game starts in... 3";

            //redraw the screen to show updates then pause for 1 second 
            Refresh();
            Thread.Sleep(1000);

            //change the countdownLabel text to begin countdown
            countdownLabel.Text = "Game starts in... 2";

            //redraw the screen to show updates then pause for 1 second 
            Refresh();
            Thread.Sleep(1000);

            //change the countdownLabel text to begin countdown
            countdownLabel.Text = "Game starts in... 1";

            //redraw the screen to show updates then pause for 1 second 
            Refresh();
            Thread.Sleep(1000);

            //make the countdown label invisible, make the go label visible and change screen background to green
            countdownLabel.Visible = false;
            goLabel.Visible = true;
            BackColor = Color.Green;
        }
    }
}
