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

namespace rpg_pa
{
    public partial class spaceAdventureUI : Form
    {

        //Transfer this to a static method
        /*
        string[,] locations = new string[,]
        {
            { "Transporter room", "Observation Deck", "Brig" },
            { "Start", "Corridor", "Escapecapsule" },
            { "Ready room", "Bridge", "Cargo Hold" }
        };
        int xCoordinate = 1;
        int yCoordinate = 0;
        */

        Player myPlayer = new Player(locations[xCoordinate, yCoordinate], 100);

        public spaceAdventureUI()
        {
            InitializeComponent();
            oxygen_Level_Box.Text = myPlayer.OxygenLevel.ToString();
            output.Text = "Your current location is " + locations[xCoordinate, yCoordinate];
        }

        private void forwards_Click(object sender, EventArgs e)
        {
            output.Text = "moving forwards\r\n";
            yCoordinate++;
            GameActions();
        }

        private void left_Click(object sender, EventArgs e)
        {
            output.Text = "moving left\r\n";
            xCoordinate--;
            GameActions();
        }

        private void right_Click(object sender, EventArgs e)
        {
            output.Text = "moving right\r\n";
            xCoordinate++;
            GameActions();
        }

        private void backwards_Click(object sender, EventArgs e)
        {
            output.Text = "moving backwards\r\n";
            yCoordinate--;
            GameActions();
        }

        private void GameActions(){

            myPlayer.OxygenLevel -= 10;
            oxygen_Level_Box.Text = myPlayer.OxygenLevel.ToString();

            myPlayer.Location = locations[xCoordinate, yCoordinate];
            output.Text += "Your new location is " + myPlayer.Location + "\r\n";

            if (myPlayer.OxygenLevel == 0){
                Environment.Exit(0);
            }

        }

        private void oxygen_Level_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
