/*Tyler Wiggins
This is my own work
Version 6.9
CST-227
Minesweeper Application*/

using System;
using System.Windows.Forms;

namespace MinesweeperFinal
{
    public partial class EnterNames : Form
    {
        //Variables to store information
        private string initials;
        private int difficulty;
        private TimeSpan ts;
        private bool win;

        public EnterNames(int difficulty, TimeSpan ts, bool win)
        {
          // this.ts = ts;
            this.difficulty = difficulty;
            this.win = win;
           // lbl_Time.Text = ts.ToString();
            InitializeComponent(ts);
        }

        //When submit button is clicked add new initials to highscore list.
        private void button1_Click(object sender, EventArgs e)
        {
            //if there are less than 3 characters, show error message.
            if (textBox1.TextLength > 3)
            {
                MessageBox.Show("Enter 3 characters or less");
            }
            else
            {
                //Passes the time, and difficulty to the highScore_form.
                initials = textBox1.Text;
               /* highScore_Form highScores = new highScore_Form(difficulty, ts, win, initials);
                //FormClosed += (s, args) => this.Close();*/
                highScore_Form topS = new highScore_Form();
                topS.Show();
                //highScores.Show();
                this.Hide();
            }
        }
    }
}