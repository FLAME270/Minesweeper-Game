/*Tyler Wiggins
This is my own work
Version 2.1
CST-227
Minesweeper Application*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MinesweeperFinal
{
    // Extend button Class
    public class clickableCell : Button
    {
        private double row;       // cell rowNumber
        private double column;    // cell columnNumber
        private bool visited;     // cell has been visited
        private bool live;        // cell is live
        private double neighbors; // cell live neighbors

        // Set initial count to 0
        public int count = 0;

        // On initialize
        public clickableCell()
        {
            // set starting paramaters
            this.BackColor = Color.LightBlue;
            this.Text = "";
            this.setRow(-1);
            this.setColumn(-1);
            this.setVisited(false);
            this.setLive(false);
            this.setNeighbors(0);
        }

        // get cell count
        public int getCount()
        {
            return this.count;
        }

        // set cell count
        public void setCount()
        {
            this.count = this.count + 1;
        }

        // set cell row
        public void setRow(double row)
        {
            this.row = row;
        }

        // set cell column
        public void setColumn(double column)
        {
            this.column = column;
        }

        // set cell visited
        public void setVisited(bool visited)
        {
            this.visited = visited;
        }

        // set cell live value
        public void setLive(bool live)
        {
            this.live = live;
        }

        // set cell neighbors
        public void setNeighbors(double neighbors)
        {
            this.neighbors = neighbors;
        }

        // get cell row
        public double getRow()
        {
            return this.row;
        }

        // get cell column
        public double getCloumn()
        {
            return this.column;
        }

        // get cell visited value
        public bool getVisited()
        {
            return this.visited;
        }

        // get cell live value
        public bool getLive()
        {
            return this.live;
        }

        // get cell neighbors
        public double getNeighbors()
        {
            return this.neighbors;
        }

   

        // Set Grid class for each cell
        public grid grid;
        private ImageLayout BackgroundImageLayout;
        private Color BackColor;
        private Bitmap Image;
        private string Text;
        internal Point Location;
        internal Size Size;
    

        // Have Current Grid class
        public void createGrid(grid form)
        {
            grid = form;
        }

        // Control the grid class
        public void ControlGrid(grid form)
        {
            form.revealGrid();
        }

        // use grind class to check in your have won the game
        public void winGrid(grid form)
        {
            form.checkWin();
        }

        // reveal the 0's if a 0 value is clicked
        public void revealZerosGrid(grid form)
        {
            form.revealZeros(Convert.ToInt32(this.getRow()), Convert.ToInt32(this.getCloumn()));
        }

        // Mouse controls
        protected override void OnMouseDown(MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                // On Left Mouse Click
                case MouseButtons.Left:

                    // if you hit a bomb
                    if (this.getNeighbors() == 9)
                    {
                        ControlGrid(grid);
                        string text = "Game Over";
                        DialogResult result = MessageBox.Show(text, "", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            // stop timer
                            grid.stopWatch.Stop();
                            // Get the elapsed time as a TimeSpan value.
                            TimeSpan ts = grid.stopWatch.Elapsed;
                            // bool for win or lose
                            bool win = false;
                            highScore_Form highScore = new highScore_Form(grid.difficulty, ts, win);
                            highScore.Show();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            // stop timer
                            grid.stopWatch.Stop();
                            // Get the elapsed time as a TimeSpan value.
                            TimeSpan ts = grid.stopWatch.Elapsed;
                            // bool for win or lose
                            bool win = false;
                            highScore_Form highScore = new highScore_Form(grid.difficulty, ts, win); ;
                            highScore.Show();
                        }
                    }
                    else if (this.getNeighbors() == 0)
                    {
                        // if you hit an 0
                        this.BackColor = Color.LightGray;
                        this.Image = null;
                        revealZerosGrid(grid);
                    }
                    // if you hit anything else
                    else if (this.getNeighbors() > 0)
                    {
                        this.BackColor = Color.LightGray;
                        this.Image = null;
                        this.Text = Convert.ToString(this.getNeighbors());
                    }
                    this.setVisited(true);
                    winGrid(grid);
                    break;

                // On Right Mouse Click
                case MouseButtons.Right:
                    // change text
                    this.Text = "";
                    // Assign an image to the button.
                    this.BackColor = Color.LightGray;
                    this.Image = Properties.Resources.flag;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
        }

        // reveal the bomb in cell is live
        public void revealLive()
        {
            // change text
            this.Text = "";
            // Assign an image to the button.
            this.BackColor = Color.LightGray;
            this.Image = Properties.Resources.bomb;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // reveal the Neighbors for each cell
        public void revealNeighbors()
        {
            // if button has neighbors
            if (this.getNeighbors() > 0)
            {
                this.Text = Convert.ToString(this.getNeighbors());
            }
            else
            {
                this.Text = "";
            }
            // Assign an image to the button.
            this.BackColor = Color.LightGray;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }

}




/*
using System;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MinesweeperFinal
{
    //Extend button Class.
    public class clickableCell : Button
    {
        // cell rowNumber.
        private double row;

        // cell columnNumber.
        private double column;

        // cell has been visited
        private bool visited;

        // cell is live.
        private bool live;

        // cell live neighbors.
        private double neighbors;

        // Set count to 0.
        public int count = 0;

        // On initialize
        public clickableCell()
        {
            // sets all of the starting paramaters.
            this.BackColor = Color.Cyan;
            this.Text = "";
            this.setRow(-1);
            this.setColumn(-1);
            this.setVisited(false);
            this.setLive(false);
            this.setNeighbors(0);
        }

        /// <summary>
        /// Getters and setters for neighbors, count, row, column, visited, live, value, and neighbors.
        /// </summary>
        /// <returns></returns>
        public int getCount()
        {
            return this.count;
        }

        public void setCount()
        {
            this.count = this.count + 1;
        }

        public void setRow(double row)
        {
            this.row = row;
        }

        public void setColumn(double column)
        {
            this.column = column;
        }

        public void setVisited(bool visited)
        {
            this.visited = visited;
        }

        public void setLive(bool live)
        {
            this.live = live;
        }

        public void setNeighbors(double neighbors)
        {
            this.neighbors = neighbors;
        }

        public double getRow()
        {
            return this.row;
        }

        public double getCloumn()
        {
            return this.column;
        }

        public bool getVisited()
        {
            return this.visited;
        }

        public bool getLive()
        {
            return this.live;
        }

        public double getNeighbors()
        {
            return this.neighbors;
        }

        // override the base onclick method for button class.
      *//*  protected override void OnClick(EventArgs e)
        {
        }*//*

        // Set Grid class for each cell.
        public Grid Grid;
        private Color BackColor;
        private Bitmap Image;
        private ImageLayout BackgroundImageLayout;
        private string Text;

        // Have Current Grid class.
        public void createGrid(Grid form)
        {
            Grid = form;
        }

        // Control/reveal the grid class.
        public void ControlGrid(Grid form)
        {
            form.revealGrid();
        }

        // Use grid class to check if the user won.
        public void winGrid(Grid form)
        {
            form.checkWin();
        }

        /// <summary>
        /// reveal all the touching 0's if a 0 value is clicked.
        /// </summary>
        /// <param name="form"></param>
        public void revealZerosGrid(Grid form)
        {
            form.revealZeros(Convert.ToInt32(this.getRow()), Convert.ToInt32(this.getCloumn()));
        }

        // Mouse controls.
        protected override void OnMouseDown(MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                // On Left Mouse Click.
                case MouseButtons.Left:

                    // if you hit a bomb, display a Game Over message with a frowney face :(
                    if (this.getNeighbors() == 9)
                    {
                        ControlGrid(Grid);
                        string text = "Game Over :( ";
                        MessageBox.Show(text);
                    }
                    else if (this.getNeighbors() == 0)
                    {
                        // if you hit an 0.
                        this.BackColor = Color.Lime;
                        this.Image = null;
                        //Reveal all touching 0's.
                        revealZerosGrid(Grid);
                    }
                    // if you hit anything else, gets all the neighbors.
                    else if (this.getNeighbors() > 0)
                    {
                        this.BackColor = Color.Lime;
                        this.Image = null;
                        this.Text = Convert.ToString(this.getNeighbors());
                    }
                    this.setVisited(true);
                    winGrid(Grid);
                    break;

                // On Right Mouse Click, set the cell to a picture of a flag
                case MouseButtons.Right:
                    // change text
                    this.Text = "";
                    // Assign an image to the button.
                    this.BackColor = Color.Cyan;
                    //Pulls flag image from resources and sets the layout.
                    this.Image = Properties.Resources.red_flag;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
        }

        /// <summary>
        /// reveal the bomb in cell is live.
        /// </summary>
        public void revealLive()
        {
            // change text
            this.Text = "";
            // Assign an image to the button.
            this.BackColor = Color.Cyan;
            //Pulls bomb from recources and sets the layout.
            this.Image = Properties.Resources.bomb;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // reveal the Neighbors for each .
        public void revealNeighbors()
        {
            // if a button has neighbors.
            if (this.getNeighbors() > 0)
            {
                //Print the number of neighbors in the revieled cell.
                this.Text = Convert.ToString(this.getNeighbors());
            }
            else
            {
                this.Text = "";
            }
            // Assign an image to the button.
            this.BackColor = Color.Lime;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
*/