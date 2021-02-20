/*Tyler Wiggins
This is my own work
Version 6.9
CST-227
Minesweeper Application*/

using System;
using System.Windows.Forms;

namespace MinesweeperFinal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}