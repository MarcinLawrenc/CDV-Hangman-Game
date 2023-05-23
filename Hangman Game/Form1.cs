using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Game
{
    public partial class Form1 : Form
    {
        //some variables I need
        int remain;
        int score;
        int countImage;
        List<Image> imageHangman;

        public Form1()
        {
            InitializeComponent();
            imageHangman = new List<Image>()
            {
                Properties.Resources._1_Stage,
                Properties.Resources._2_Stage,
                Properties.Resources._3_Stage,
                Properties.Resources._4_Stage,
                Properties.Resources._5_Stage,
                Properties.Resources._6_Stage,
                Properties.Resources._7_Stage,
                Properties.Resources._8_Stage,
            };

            initialize();
        }

        private void initialize()
        {
            countImage = 0;
            score = 0;
            HangmanPictureBox.BackgroundImage = imageHangman[countImage];
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void buttonLetter_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Black;
            countImage++;
            HangmanPictureBox.BackgroundImage = imageHangman[countImage];

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
