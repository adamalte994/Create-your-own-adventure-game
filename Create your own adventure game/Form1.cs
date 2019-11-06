using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_your_own_adventure_game
{
    public partial class Form1 : Form
    {
        int scene = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (scene == 1) { scene = 2; }
            else if (scene == 2) { scene = 4; }
            else if (scene == 3) { scene = 1; }
            else if (scene == 4) { scene = 6; }
            else if (scene == 5) { scene = 1; }
            else if (scene == 6) { scene = 8; }
            else if (scene == 7) { scene = 1; }
            else if (scene == 8) { scene = 10; }
            else if (scene == 9) { scene = 1; }
            else if (scene == 10) { scene = 12; }
            else if (scene == 11) { scene = 1; }
            else if (scene == 12) { scene = 1; }
            else if (scene == 13) { scene = 1; }

            SceneOutput();
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            if (scene == 1) { scene = 1; }
            else if (scene == 2) { scene = 5; }
            else if (scene == 3) { scene = 99; } // may not need
            else if (scene == 4) { scene = 7; }
            else if (scene == 5) { scene = 99; }
            else if (scene == 6) { scene = 9; }
            else if (scene == 7) { scene = 99; }
            else if (scene == 8) { scene = 11; }
            else if (scene == 9) { scene = 99; }
            else if (scene == 10) { scene = 13; }
            else if (scene == 11) { scene = 99; }
            else if (scene == 12) { scene = 99; }
            else if (scene == 13) { scene = 99; }

            SceneOutput();
        }

        private void SceneOutput()
        {
            //put case statements here
            switch (scene)
            {
                case 1:
                    sceneImages.BackgroundImage = Properties.Resources.gaetano_caltabiano_dungeon_s_entrance;
                    outputLabel.Text = "You are in a dungeon";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "Back";
                    break;
                case 2:
                    sceneImages.BackgroundImage = Properties.Resources.Skeleton_archer;
                    outputLabel.Text = "While going forwards you encounter a skeleton with a bow. What do you do?";
                    redLabel.Text = "Fight Back";
                    blueLabel.Text = "Run";
                    break;
                case 3:
                    outputLabel.Text = "You tried to go back but the doors are locked";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 4:
                    sceneImages.BackgroundImage = Properties.Resources.shep_mix_looking_up_21047;
                    outputLabel.Text = "You fight back ferociously and beat the skeleton. \nFor beating the skeleton you take the skull as a trophy. \nWhile continuing through the dungeon you encounter \na lost dog what do you do?";
                    redLabel.Text = "Follow";
                    blueLabel.Text = "Ignore";
                    break;
                case 5:
                    sceneImages.BackgroundImage = Properties.Resources.body_with_arrows;
                    outputLabel.Text = "You tried to run past the skeleton but you were shot by \nan arrow and die. You lose! Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 6:
                    sceneImages.BackgroundImage = Properties.Resources.active_mines;
                    outputLabel.Text = "You decide to follow the dog through the dungeon. \nThe dog lead you to a door with a sign that \nsays warning landmines ahead. What do you do?";
                    redLabel.Text = "Throw the skull into the room";
                    blueLabel.Text = "Tell the dog to go in there";
                    break;
                case 7:
                    sceneImages.BackgroundImage = Properties.Resources.dog_attack;
                    outputLabel.Text = "You casually Ignore the dog and keep walking \nthen the dog attacks you for ignoring it. You lose! Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 8:
                    sceneImages.BackgroundImage = Properties.Resources.dog_treats;
                    outputLabel.Text = "You throw the skull into the room and took cover. You cleared the room of land mines. \nAfter the landmines blew up you cross the room to see \nbehind a door to find a plate of dog treats. What do you do?";
                    redLabel.Text = "Take the treats";
                    blueLabel.Text = "Leave the treats";
                    break;
                case 9:
                    sceneImages.BackgroundImage = Properties.Resources.dead_body;
                    outputLabel.Text = "You tell the dog to go in there and the dog was heard exploding all over the room. \nYou have then became depressed and died. You lose! Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 10:
                    sceneImages.BackgroundImage = Properties.Resources.key_on_collar;
                    outputLabel.Text = "You decide to take the dog treats and put them in your backpack. \nYou keep going forward to then come across a bridge and a bottomless hole. \nWhat do you do? Since you decided to take the dog treats you give the treats to the dog \nand the dog goes through the hole in the wall and \nout the other side and then the dog lowers the bridge. \nYou then cross the bridge to see a large iron door \nstanding in your way what do you do? \nYou just notice this but you see a sliver key on the dogs collar.";
                    redLabel.Text = "Pet the dog";
                    blueLabel.Text = "Take the key";
                    break;
                case 11:
                    sceneImages.BackgroundImage = Properties.Resources.bottomless_hole;
                    outputLabel.Text = "You decide not to take the dog treats. You keep going forward to \nthen come across a bridge and a bottomless hole. What do you do? \nSince you didn't take treat you you decide to take the \nleap of faith but you end up falling down the pit to your death. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 12:
                    sceneImages.BackgroundImage = Properties.Resources.person_scracthing_dog_ears;
                    outputLabel.Text = "You decide to scratch the dog behind the ears \nand the dog enjoys the scratch and gives you the key. \nThen you open the door and leave the dungeon. You win play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 13:
                    sceneImages.BackgroundImage = Properties.Resources.dog_bite;
                    outputLabel.Text = "You decide to try and take the key from the dogs collar and \nthe dog bites your hand off and you die due to blood lost. You died play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 99:
                    sceneImages.BackgroundImage = Properties.Resources.thanks_for_playing;
                    outputLabel.Text = "Thanks for playing";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                default :
                    break;
            }
        }
    }
}
