/*Tyler Wiggins
This is my own work
Version 6.9
CST-227
Minesweeper Application*/

using System;
using System.Windows.Forms;

namespace MinesweeperFinal
{
    public partial class Menu : Form
    {
        private grid grid;

        public Menu()
        {
            InitializeComponent();
        }

        // Once the user chooses a difficulty and cliks the play game button, LevelForm will open.
        public void playGame_btn_Click(object sender, EventArgs e)
        {
            if (easy_btn.Checked)
            {
                // Create a new from and pass difficulty.
                grid game = new grid(1);
                // Show new game form.

                game.Show();
            }
            else if (moderate_btn.Checked)
            {
                // Create a new from and pass difficulty.
                grid game = new grid(2);
                // Show new game form.
                game.Show();
            }
            else if (difficult_btn.Checked)
            {
                // Create a new from and pass difficulty.
                grid game = new grid(3);

                // Show new game form.
                game.Show();
            }
            this.Visible = false;
        }
    }
}