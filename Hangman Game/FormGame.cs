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
    public partial class FormGame : Form
    {
        //some variables I need
        int remain = 8;
        int score;
        int countImage;
        int secretWordLength = 20 ;
        List<Image> imageHangman;

        public FormGame()
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
            labelRemain.Text = remain.ToString();
            secretWordHiddenSchow();

        }

        private void secretWordHiddenSchow()
        {
            HangmanPictureBox.BackgroundImage = imageHangman[countImage];
            string repeatedCharacter = new string('_', secretWordLength);
            string repeatedCharacterWithSpaces = string.Join(" ", repeatedCharacter.ToCharArray());
            labelSecretWord.Text = repeatedCharacterWithSpaces;
        }

        private void lostPoint()
        {
            remain--;
            labelRemain.Text = remain.ToString();
            countImage++;
            HangmanPictureBox.BackgroundImage = imageHangman[countImage];
            
        }

        private void choosedLetterCheck()
        {
         


        }

        private bool checkLetterIsInSecretWord()
        {
            bool isInSecretWord = false;



            return isInSecretWord;
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
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void buttonLetter_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(49, 60, 68);
            button.Enabled = false;
            lostPoint();
      
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelSecretWord_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
 
        }
    }
}
