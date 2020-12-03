using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        // Once the user chooses a difficulty and cliks the play game button, LevelForm will open.
        private void playGame_btn_Click(object sender, EventArgs e)
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
        }
    }
}
