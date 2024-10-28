using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mr.T_s_Class_Escape
{
    public partial class Form1 : Form
    {

        int pageNum;
        public Form1()
        {
            InitializeComponent();
            outputLabel.ReadOnly = true;
            outputLabel.ShortcutsEnabled = false;
            pageNum = 1;
            pageSwitch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pageNum == 1)
            {
                Random rnd = new Random();
                int chance = rnd.Next(1, 100);
                if (chance > 80)
                {
                    pageNum = 98;
                    pageSwitch();
                }
                else
                {
                    pageNum = 2;
                    pageSwitch();
                }
            }

            else if (pageNum == 2)
            {
                pageNum = 3;
                pageSwitch();
            }

            else if (pageNum == 3)
            {
                pageNum = 5;
                pageSwitch();
            }

            else if (pageNum == 5)
            {
                pageNum = 7;
                pageSwitch();
            }

            else if (pageNum == 4)
            {
                pageNum = 99;
                pageSwitch();
            }

            else if (pageNum == 6)
            {
                pageNum = 7;
                pageSwitch();
            }

            else if (pageNum == 7)
            {
                pageNum = 99;
                pageSwitch();
            }

            else if (pageNum == 8)
            {
                pageNum = 98;
                pageSwitch();
            }

            else if (pageNum == 98 || pageNum == 99)
            {
                pageNum = 1;
                resetAll();
                pageSwitch();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pageNum == 1)
            {
                pageNum = 99;
                pageSwitch();
            }
            else if (pageNum == 2)
            {
                pageNum = 99;
                pageSwitch();
            }
            else if (pageNum == 3) {
                pageNum = 4;
                pageSwitch();
            }
            else if (pageNum == 5)
            {
                pageNum = 98;
                pageSwitch();
            }
            else if (pageNum == 6)
            {
                pageNum = 8;
                pageSwitch();
            }
            else if (pageNum == 98 || pageNum == 99)
            {
                resetAll();
                outputLabel.Text = "Thanks for playing!\n";
                outputLabel.Text += "Closing in 3...";
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += " 2...";
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += " 1...";
                Refresh();
                Thread.Sleep(1000);
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pageNum == 3)
            {
                pageNum = 98;
                pageSwitch();
            }
        }

        void pageSwitch()
        {
            if (pageNum != 3)
            {
                button3.Visible = false;
            }
             switch(pageNum)
            {
                case 1:
                    pictureBox.Image = Properties.Resources.page1;
                    outputLabel.ForeColor = Color.DimGray;
                    outputLabel.Text = "You are stuck inside Mr. T's class 5 minutes before the bell." +
                        "\nDo you run away or stay and wait?";
                    button1.Text = "Run";
                    button2.Text = "Stay";
                    break;
                case 2:
                    pictureBox.Image= Properties.Resources.page2;
                    outputLabel.ForeColor = Color.Red;
                    outputLabel.Text = "He saw you run! \nDo you submit to his wrath or" +
                        " do you throw a hotdog at him?";
                    button1.Text = "Throw hotdog";
                    button2.Text = "Submit to Mr. T";
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources.page3;
                    outputLabel.ForeColor = Color.DimGray;
                    outputLabel.Text = "He was stunned. \n" +
                        "Do you help him, do nothing or run away?";
                    button1.Text = "Help him";
                    button2.Text = "Do nothing";
                    button3.Visible = true;
                    button3.Text = "Run away";
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources.page41;
                    outputLabel.ForeColor = Color.Red;
                    resetAll();
                    outputLabel.Text = "He is angry.";
                    button1.Text = "Continue";
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources.page5;
                    outputLabel.ForeColor = Color.Green;
                    outputLabel.Text = "He is pleased. He offers a reward.\n" +
                        "Do you run while while he least expects or accept a reward from him?";
                    button1.Text = "Accept";
                    button2.Text = "Run";
                    break;
                case 6:
                    pictureBox.Image = Properties.Resources.page6;
                    outputLabel.ForeColor = Color.Green;
                    outputLabel.Text = "Mr. T wants to give you a McDonalds coupon\n" +
                        "Do you accept?";
                    button1.Text = "Accept";
                    button2.Text = "Decline";
                    break;
                case 7:
                    pictureBox.Image = Properties.Resources.page7;
                    outputLabel.ForeColor = Color.Red;
                    resetAll();
                    outputLabel.Text = "It was a trick! He pulls out a meter stick and\n" +
                        "beats you severely for trying to leave class 2 minutes early.";
                    button1.Text = "Continue";
                    break;
                case 8:
                    pictureBox.Image = Properties.Resources.page8;
                    outputLabel.ForeColor = Color.Green;
                    outputLabel.Text = "The bell rings. You may leave";
                    button1.Text = "Continue";
                    break;
                case 98:
                    pictureBox.Image = Properties.Resources.page98;
                    outputLabel.ForeColor = Color.Green;
                    outputLabel.Text = "You win the game!\n" +
                        "Play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    break;
                case 99:
                    pictureBox.Image = Properties.Resources.page991;
                    outputLabel.ForeColor = Color.Red;
                    outputLabel.Text = "You lose the game.\n" +
                        "Play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    break;
            }
        }
        void resetAll()
        {
            outputLabel.ForeColor = Color.DimGray;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button3.Visible = false;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
