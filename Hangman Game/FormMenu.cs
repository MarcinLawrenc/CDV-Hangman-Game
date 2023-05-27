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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSetup formSetup = new FormSetup();
            formSetup.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame();
            formGame.ShowDialog();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
