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

        Player myPlayer = new Player(locations[xCoordinate, yCoordinate], 1000, 100);
        private bool alienInRoom;

        public spaceAdventureUI()
        {
            InitializeComponent();
            oxygen_Level_Box.Text = myPlayer.OxygenLevel.ToString();
            suitIntegrityBox.Text = myPlayer.SuitIntegrity.ToString();

            generateAliens();

            output.Text = "Your current location is " + locations[xCoordinate, yCoordinate];
            //initial update incase Alien is in start location, i.e. before player has moved
            updateForAlien();
        }

        private void forwards_Click(object sender, EventArgs e)
        {
            output.Text = "Moving forwards...\r\n\r\n";

            yCoordinate++;
            bool limitsCheck = IsWithinLimits(locations, xCoordinate, yCoordinate);
            if (limitsCheck == true)
            {
                outputSuccess();
            }
            else
            {
                yCoordinate--;
                outputFailure();
            }
            GameActions();
        }

        private void left_Click(object sender, EventArgs e)
        {
            output.Text = "Moving left...\r\n\r\n";
            xCoordinate--;
            bool limitsCheck = IsWithinLimits(locations, xCoordinate, yCoordinate);
            if (limitsCheck == true)
            {
                outputSuccess();
            }
            else
            {
                xCoordinate++;
                outputFailure();
            }
            GameActions();
        }

        private void right_Click(object sender, EventArgs e)
        {
            output.Text = "Moving right...\r\n\r\n";
            xCoordinate++;
            bool limitsCheck = IsWithinLimits(locations, xCoordinate, yCoordinate);
            if (limitsCheck == true)
            {
                outputSuccess();
            }
            else
            {
                xCoordinate--;
                outputFailure();
            }
            GameActions();
        }

        private void backwards_Click(object sender, EventArgs e)
        {
            output.Text = "Moving backwards...\r\n\r\n";
            yCoordinate--;
            bool limitsCheck = IsWithinLimits(locations, xCoordinate, yCoordinate);
            if (limitsCheck == true)
            {
                outputSuccess();
            }
            else
            {
                yCoordinate++;
                outputFailure();
            }
            GameActions();
        }

        private void GameActions()
        {

            myPlayer.OxygenLevel -= 10;
            oxygen_Level_Box.Text = myPlayer.OxygenLevel.ToString();

            updateForAlien();

            if (myPlayer.OxygenLevel == 0)
            {
                Environment.Exit(0);
            }

        }

        public void updateForAlien()
        {
            bool alienInRoom = checkIfAlienPresent(xCoordinate, yCoordinate);
            if (alienInRoom == true)
            { output.Text = output.Text + "\r\n\r\nALIEN IN ROOM!"; }

        }

        private void outputSuccess()
        {
            output.Text = "You have moved into  " + locations[xCoordinate, yCoordinate];
        }

        private void outputFailure()
        {
            output.Text = "You have hit a wall.  Try again, your location is - " + locations[xCoordinate, yCoordinate];
        }

        private void oxygen_Level_Box_TextChanged(object sender, EventArgs e)
        {

        }

        public void shoot_Click(object sender, EventArgs e)
        {
            if (alienInRoom == true)
            {
                //Yes
                    //Fight
                        //Update space suit integrity by 1 for loser
                            //Is alien space suit intergrity 0?
                                //confirm alien destroyed and remove from display and config map
                            //If not pass
                            //Is player space suit integrity 0?
                                //end game
                            //if not pass    
            }
            else
            {
                //pass
            }
        }
    }
}
