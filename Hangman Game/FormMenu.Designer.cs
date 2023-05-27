namespace Hangman_Game
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSetup = new System.Windows.Forms.Button();
            this.buttonProgramQuit = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HangmanPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HangmanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetup
            // 
            this.buttonSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetup.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetup.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSetup.Location = new System.Drawing.Point(31, 460);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(120, 40);
            this.buttonSetup.TabIndex = 1;
            this.buttonSetup.Text = "Setup";
            this.buttonSetup.UseVisualStyleBackColor = true;
            this.buttonSetup.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonProgramQuit
            // 
            this.buttonProgramQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProgramQuit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonProgramQuit.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonProgramQuit.Location = new System.Drawing.Point(229, 460);
            this.buttonProgramQuit.Name = "buttonProgramQuit";
            this.buttonProgramQuit.Size = new System.Drawing.Size(120, 40);
            this.buttonProgramQuit.TabIndex = 2;
            this.buttonProgramQuit.Text = "Quit";
            this.buttonProgramQuit.UseVisualStyleBackColor = true;
            this.buttonProgramQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPlay.Location = new System.Drawing.Point(108, 303);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(160, 80);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(78, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hangman Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HangmanPictureBox
            // 
            this.HangmanPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HangmanPictureBox.Image = global::Hangman_Game.Properties.Resources._8_Stage;
            this.HangmanPictureBox.Location = new System.Drawing.Point(108, 120);
            this.HangmanPictureBox.Name = "HangmanPictureBox";
            this.HangmanPictureBox.Size = new System.Drawing.Size(165, 150);
            this.HangmanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HangmanPictureBox.TabIndex = 33;
            this.HangmanPictureBox.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(381, 534);
            this.Controls.Add(this.HangmanPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonProgramQuit);
            this.Controls.Add(this.buttonSetup);
            this.Name = "FormMenu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HangmanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetup;
        private System.Windows.Forms.Button buttonProgramQuit;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HangmanPictureBox;
    }
}