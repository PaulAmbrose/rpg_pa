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
            bool alienInRoom = checkIfAlienPresent(xCoordinate, yCoordinate);
                    
            Alien newAlien = new Alien(50);
            bool inAFightFlag = true;
            do
            {
                bool fightResult = alienFight();
                if (fightResult == true)
                {
                    newAlien.SuitIntegrity -= 20;
                    output.Text = "ALIEN HIT! Strengh = " + newAlien.SuitIntegrity.ToString();
                    if (newAlien.SuitIntegrity == 0)
                    {
                        output.Text = output.Text + "\r\n\r\nALIEN IN ROOM HAS BEEN DESTROYED";
                        removeAlienFromGrid(AlienLocations, xCoordinate, yCoordinate);
                        inAFightFlag = false;
                    }
                    }
                else
                    {
                        myPlayer.SuitIntegrity -= 20;
                        suitIntegrityBox.Text = myPlayer.SuitIntegrity.ToString();
                    if (myPlayer.SuitIntegrity == 0)
                    {
                        output.Text = output.Text + "\r\n\r\nALIEN HAS DESTROYED YOU";
                    }
                    }
            } while (inAFightFlag == true);
        }
    }
}
