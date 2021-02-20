/*Tyler Wiggins
This is my own work
Version 6.9
CST-227
Minesweeper Application*/

using System;

namespace MinesweeperFinal
{
    // Create PlayerStats Class and make in Comparable
    public class PlayerStats : IComparable<PlayerStats>
    {
        // initials, level and time
        public string name { get; set; }

        public int difficulty { get; set; }
        public int time { get; set; }

        // Constructor for new playerstats
        public PlayerStats(string name, int difficulty, int time)
        {
            this.name = name;
            this.difficulty = difficulty;
            this.time = time;
        }

        // Compare the time to another PlayerStats object
        public int CompareTo(PlayerStats other)
        {
            return time.CompareTo(other.time);
        }

        public override String ToString()
        {
            return name + difficulty + time.ToString();
        }
    }
}