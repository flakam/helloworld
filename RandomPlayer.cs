using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class RandomPlayer : Player
    {
        Random rando;
        public RandomPlayer(string name,Random rando) : base(name)
        {
            this.rando = rando;
        }
        public override string GetRPS()
        {
            int pick = rando.Next(1, 4);
            if (pick == 1)
            {
                return Enum.Rock.ToString();
            }
            else if (pick == 2)
            {
                return Enum.Rock.ToString();
            }
            else if(pick==3)
            {
                return Enum.Scissors.ToString();
            }
            return "-1";
        }
    }
}
