/*Tyler Wiggins
This is my own work
Version 6.9
CST-227
Minesweeper Application*/

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MinesweeperFinal
{
    public partial class highScore_Form : Form
    {
        public highScore_Form()
        {
            InitializeComponent();
        }

        //Reads list of scores from PlayerStatus.
        private List<PlayerStats> scores = new List<PlayerStats>();
        private List<PlayerStats> sortedScores = new List<PlayerStats>();
        //Makes variables that stores data.
        private int difficulty;
        private TimeSpan ts;
        private bool win;
        private string initials;

        public highScore_Form(int difficulty, int difficulty1, TimeSpan timeSpan, TimeSpan ts, bool win, string initials)
        {
            //Reads out previous high scores from txt file.

        }

        /// <summary>
        /// Adds new score to list of top players.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="difficulty"></param>
        /// <param name="time"></param>
        public highScore_Form(int difficulty, string name, int time)
        {
            //Makes new score.
            NewScore(name, difficulty, time);
            //Adds the new score to a txt file.
            using (StreamReader input = new StreamReader(Path.Combine(Environment.CurrentDirectory, "HighScores.txt")))
            {
                //Variables for adding to the file.
                string line;
                int savedtime;
                string[] split;

                while ((line = input.ReadLine()) != null)
                {
                    split = line.Split(' ');
                    Int32.TryParse(split[2], out savedtime);
                    NewScore(split[0], split[1], savedtime);
                }
            }
            //Writes new score to a txt file.
            using (StreamWriter output = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "HighScores.txt")))
            {
                foreach (var PlayerStats in scores)
                {
                    //Writes in new data.
                    output.WriteLine(PlayerStats.name + " " + PlayerStats.difficulty + " " + PlayerStats.time);
                }
            }

            //Query to sort the new score added.
            var queryScores =
                from PlayerStats in scores
                where PlayerStats.difficulty == difficulty
                orderby PlayerStats.time ascending
                select PlayerStats;

            //Add the new score to the listbox.
            foreach (var PlayerStats in queryScores)
            {
                sortedScores.Add(PlayerStats);
            }

            InitializeComponent();
        }

        private void NewScore(string v1, string v2, int savedtime)
        {
            throw new NotImplementedException();
        }

        public highScore_Form(int difficulty, TimeSpan ts, bool win)
        {
            this.difficulty = difficulty;
            this.ts = ts;
            this.win = win;
        }

        public highScore_Form(int difficulty, TimeSpan ts, bool win, string initials) : this(difficulty, ts, win)
        {
            this.initials = initials;
        }

        //Add the new score to player status.
        public void NewScore(string name, int difficulty, int time)
        {
            scores.Add(new PlayerStats(name, difficulty, time));
        }


        //Starts a new Game if the button is clicked.
        private void button1_Click(object sender, EventArgs e)
        {
            Menu newGame = new Menu();
            newGame.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void sortedScorez_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Adds new score to txtfile
            using (StreamReader input = new StreamReader(Path.Combine(Environment.CurrentDirectory, "HighScores.txt")))
            {
                string line;
                int savedtime;
                string[] split;

                while ((line = input.ReadLine()) != null)
                {
                    split = line.Split(',');
                    Int32.TryParse(split[2], out savedtime);
                    NewScore(split[0], split[1], savedtime);
                }
            }

            //Sorts the scores from highest to lowest.
            var queryScores =
                from PlayerStats in scores
                where PlayerStats.difficulty == difficulty
                orderby PlayerStats.time ascending
                select PlayerStats;
            //Prints scores in listbox
            foreach (var PlayerStats in queryScores)
            {
                sortedScores.Add(PlayerStats);
            }

            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox1.Text = "RGB, easy, 00:00:05.9036461 \n LTL, medium, 00:08:15.4536461 \n NML, hard, 00:15:25.4636319 \n TTT, medium, 00:03:25.7890250 ";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}