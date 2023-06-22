using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace harlequin_cs
{
    public partial class harlequinForm : Form
    {
        Game game;
        List<PictureBox> enemyPictureBoxes;
        public harlequinForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1920, 1080);
            this.BackColor = Color.Black;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            game = new Game("Player");

            enemyPictureBoxes = new List<PictureBox>();

            foreach (var enemy in game.Enemies)
            {
                var enemyPictureBox = new PictureBox
                {
                    BackColor = Color.White,
                    Size = new Size(100, 100)
                };
                this.Controls.Add(enemyPictureBox);
                enemyPictureBoxes.Add(enemyPictureBox);
            }

            gameLoopTimer = new Timer();
            gameLoopTimer.Interval = 1000 / 60; // Approx. 60 FPS
            gameLoopTimer.Tick += GameLoopTimer_Tick;
            gameLoopTimer.Start();

            this.KeyPreview = true;
        }

        private void harlequinForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Track key presses
            game.KeyDown(e);
        }

        private void harlequinForm_KeyUp(object sender, KeyEventArgs e)
        {
            // Track key releases
            game.KeyUp(e);
        }

        private void GameLoopTimer_Tick(object sender, EventArgs e)
        {
            // Update game state
            game.Update(this.ClientSize.Width, this.ClientSize.Height);

            // Update character position on screen
            characterPictureBox.Location = new Point(game.CharacterX, game.CharacterY);

            // Update enemy positions on screen
            for (int i = 0; i < game.Enemies.Count; i++)
            {
                enemyPictureBoxes[i].Location = new Point(game.Enemies[i].X, game.Enemies[i].Y);
            }
        }
    }
}