using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using engine;
using static engine.configStatic;

namespace rpg_pa
{
    public partial class spaceAdventureUI : Form
    {

        Player myPlayer = new Player(locations[xCoordinate, yCoordinate], 100);

        public spaceAdventureUI()
        {
            InitializeComponent();
            oxygen_Level_Box.Text = myPlayer.OxygenLevel.ToString();
            output.Text = "Your current location is " + locations[xCoordinate, yCoordinate];
        }

        private void forwards_Click(object sender, EventArgs e)
        {
            output.Text = "Moving forwards...\r\n\r\n";
            int cameFromX = xCoordinate;
            int cameFromY = yCoordinate;
            int moveTooX = xCoordinate;
            int moveTooY = yCoordinate++;
            GameActions(moveTooX, moveTooY, cameFromX, cameFromY);
        }

        private void left_Click(object sender, EventArgs e)
        {
            output.Text = "Moving left...\r\n\r\n";
            int cameFromX = xCoordinate;
            int cameFromY = yCoordinate;
            int moveTooX = xCoordinate--;
            int moveTooY = yCoordinate;
            GameActions(moveTooX, moveTooY, cameFromX, cameFromY);
        }

        private void right_Click(object sender, EventArgs e)
        {
            output.Text = "Moving right...\r\n\r\n";
            int cameFromX = xCoordinate;
            int cameFromY = yCoordinate;
            int moveTooX = xCoordinate++;
            int moveTooY = yCoordinate;
            GameActions(moveTooX, moveTooY, cameFromX, cameFromY);
        }

        private void backwards_Click(object sender, EventArgs e)
        {
            output.Text = "Moving backwards...\r\n\r\n";
            int cameFromX = xCoordinate;
            int cameFromY = yCoordinate;
            int moveTooX = xCoordinate;
            int moveTooY = yCoordinate--;

            GameActions(moveTooX, moveTooY, cameFromX, cameFromY);
        }

        private void GameActions(int moveTooX, int moveTooY, int cameFromX, int cameFromY){

            myPlayer.OxygenLevel -= 10;
            oxygen_Level_Box.Text = myPlayer.OxygenLevel.ToString();

           
                bool limitsCheck = IsWithinLimits(locations, xCoordinate, yCoordinate);
            if (limitsCheck == true)
            {
                myPlayer.Location = locations[moveTooX, moveTooY];
                output.Text += "Your new location is " + myPlayer.Location + "\r\n\r\n";
            }
            else
            {
                myPlayer.Location = locations[cameFromX, cameFromY];
                output.Text += "You have hit a wall, please try again. You are at:  " + myPlayer.Location + "\r\n\r\n";
            }
            
            if (myPlayer.OxygenLevel == 0){
                Environment.Exit(0);
            }

        }

        private void oxygen_Level_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
