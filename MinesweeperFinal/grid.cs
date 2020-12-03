using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperFinal
{
    public partial class grid : Form
    {
        public grid()
        {
            InitializeComponent();
        }

     

        
        public clickableCell[,] square;

        //Stores the size of the grid.
        private int size;

        // Creates a new stopwatch.
        public Stopwatch stopWatch = new Stopwatch();

        // Get difficulty from Main Menu.
        public int difficulty;

        /// <summary>
        /// Sets the difficulty.
        /// </summary>
        /// <param name="difficulty"></param>
        public grid(int difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
        }

        /// <summary>
        /// Loads the minesweeper game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_Load(object sender, EventArgs e)
        {
            // Starts the timer.
            stopWatch.Start();

            // Allows the form to automaticlly get the size to fit objects inside.
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Use the difficulty to set the size of game Grid.
            size = difficulty * 10;

            // Create an array of clickableCells.
            square = new clickableCell[size, size];

            // loop through to create game Grid
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // create new clickable Cell button
                    square[i, j] = new clickableCell();
                    int x = j * 25;
                    int y = i * 25;
                    square[i, j].Location = new System.Drawing.Point(x, y);
                    square[i, j].Size = new System.Drawing.Size(25, 25);
                    square[i, j].setRow(i);
                    square[i, j].setColumn(j);
                    square[i, j].createGrid(this);
                    this.Controls.Add(square[i, j]);
                }
            }

            // Number of Cells
            double cellNumber = size * size;

            // Get random percentage between 15-20.
            Random rnd = new Random();
            double ranPercent = rnd.Next(3, 5);

            // Use random percentage to find number of cells that will be live.
            ranPercent = ranPercent / 100;
            double randomCount = Math.Round(cellNumber * ranPercent, 0);

            int[] randomLive = new int[Convert.ToInt32(randomCount)];

            // Create Array of completely random cells to turn live.
            for (int i = 0; i < randomCount; i++)
            {
                double cellLive = rnd.Next(0, Convert.ToInt32(cellNumber));

                int pos = Array.IndexOf(randomLive, cellLive);
                if (pos > -1)
                {
                    // Check randomLive array, is number is present do not add to array.
                    return;
                }
                else
                {
                    randomLive[i] = Convert.ToInt32(cellLive);
                }
            }

            // Loop through and make cells live.
            int liveCounter = 0;
            for (int i = 0; i < square.GetLength(0); i++)
            {
                for (int j = 0; j < square.GetLength(0); j++)
                {
                    if (randomLive.Contains(liveCounter))
                    {
                        square[i, j].setLive(true);
                    }
                    liveCounter++;
                }
            }

            // Loop through and set neighbors count.
            int neighborsCounter = 0;
            for (int i = 0; i < square.GetLength(0); i++)
            {
                for (int j = 0; j < square.GetLength(0); j++)
                {
                    neighborsCounter = 0;
                    bool cellVal = square[i, j].getLive();
                    if (cellVal == false)
                    {
                        // leftNeighbor
                        if (i > 0)
                        {
                            bool val = square[i - 1, j].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // rightNeighbor
                        if (i < square.GetLength(0) - 1)
                        {
                            bool val = square[i + 1, j].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topNeighbor
                        if (j > 0)
                        {
                            bool val = square[i, j - 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomNeighbor
                        if (j < square.GetLength(0) - 1)
                        {
                            bool val = square[i, j + 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topLeftNeighbor
                        if ((i > 0) && (j > 0))
                        {
                            bool val = square[i - 1, j - 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topRightNeighbor
                        if ((i < square.GetLength(0) - 1) && (j > 0))
                        {
                            bool val = square[i + 1, j - 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomLeftNeighbor
                        if ((i > 0) && (j < square.GetLength(0) - 1))
                        {
                            bool val = square[i - 1, j + 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomRightNeighbor
                        if ((i < square.GetLength(0) - 1) && (j < square.GetLength(0) - 1))
                        {
                            bool val = square[i + 1, j + 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }
                        // setNeighbors
                        square[i, j].setNeighbors(neighborsCounter);
                    }
                    else
                    {
                        // if live setNeighbors to 9
                        square[i, j].setNeighbors(9);
                    }
                }
            }
            // Center the form on screen.
            this.CenterToScreen();
        }

        public virtual void revealGrid()
        {
            // For each Cell in the Square.
            for (int i = 0; i < square.GetLength(0); i++)
            {
                // Create counter for number of Cells in row.
                int counter = 0;
                for (int j = 0; j < square.GetLength(0); j++)
                {
                    if (counter < square.GetLength(0))
                    {
                        bool val = square[i, j].getLive();
                        if (val)
                        {
                            square[i, j].revealLive();
                        }
                        else
                        {
                            square[i, j].revealNeighbors();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Recursive algorithm that reveals blocks of cells with no live neighbors.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void revealZeros(int i, int j)
        {
            bool cellVal = square[i, j].getLive();
            if (cellVal == false)
            {
                // leftNeighbor
                if (i > 0)
                {
                    // Get Neighbors
                    double val = square[i - 1, j].getNeighbors();
                    bool visited = square[i - 1, j].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited.
                        square[i - 1, j].setVisited(true);
                        square[i - 1, j].revealNeighbors();
                        revealZeros(i - 1, j);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        square[i - 1, j].setVisited(true);
                        square[i - 1, j].revealNeighbors();
                    }
                }

                // rightNeighbor
                if (i < square.GetLength(0) - 1)
                {
                    // Get Neighbors
                    double val = square[i + 1, j].getNeighbors();
                    bool visited = square[i + 1, j].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited.
                        square[i + 1, j].setVisited(true);
                        square[i + 1, j].revealNeighbors();
                        revealZeros(i + 1, j);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        square[i + 1, j].setVisited(true);
                        square[i + 1, j].revealNeighbors();
                    }
                }

                // topNeighbor
                if (j > 0)
                {
                    // Get Neighbors
                    double val = square[i, j - 1].getNeighbors();
                    bool visited = square[i, j - 1].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited
                        square[i, j - 1].setVisited(true);
                        square[i, j - 1].revealNeighbors();
                        revealZeros(i, j - 1);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        square[i, j - 1].setVisited(true);
                        square[i, j - 1].revealNeighbors();
                    }
                }

                // bottomNeighbor
                if (j < square.GetLength(0) - 1)
                {
                    double val = square[i, j + 1].getNeighbors();
                    bool visited = square[i, j + 1].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited.
                        square[i, j + 1].setVisited(true);
                        square[i, j + 1].revealNeighbors();
                        revealZeros(i, j + 1);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        square[i, j + 1].setVisited(true);
                        square[i, j + 1].revealNeighbors();
                    }
                }
            }
            return;
        }

        /// <summary>
        /// Checks to see if user won the game.
        /// </summary>
        public void checkWin()
        {
            //Stors the cells visited.
            int cellsVisited = 0;
            int visitedcounter = size * size;

            for (int i = 0; i < size; i++)
            {
                // Create counter for number of Cells in a row.
                for (int j = 0; j < size; j++)
                {
                    // Check all cells is they have been visited.
                    if (square[i, j].getVisited())
                    {
                        cellsVisited++;
                    }
                    // Check all cells if they are a mine.
                    if (square[i, j].getLive())
                    {
                        cellsVisited++;
                    }
                }
            }
            // If you have won the game
            if (cellsVisited == visitedcounter)
            {
                // stop timer
                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                string text = "Congratulations, your have Won!" + Environment.NewLine + "Time elapsed: " + elapsedTime + "seconds.";

                // show dialog box and capture return
                DialogResult result = MessageBox.Show(text, "", MessageBoxButtons.OK);
                // if return is ok
                if (result == DialogResult.OK)
                {
                    // bool for win or lose
                    bool win = true;
                    highScore_Form highScore = new highScore_Form(difficulty, ts, win);
                    highScore.Show();
                }
                // if return is cancel or close
                else if (result == DialogResult.Cancel)
                {
                    // bool for win or lose
                    bool win = true;
                    highScore_Form highScore = new highScore_Form(difficulty, ts, win); ;
                    highScore.Show();
                }
            }
        }
    }
}
