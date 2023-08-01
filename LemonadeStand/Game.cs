using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        Day day1 = new Day();
        public Player player;
        public List<Day> Days = new List<Day>
        {
            Day day1=new Day();
        };
        public int currentDay;
        public Game() 
        {
            Days.Add(new Day day1)
        }
    }
}
