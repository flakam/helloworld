using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class HumanPick:Player
    {

        public HumanPick(string name) : base(name)
        {

        }
        public override string GetRPS()
        {
            Console.WriteLine("Hello! Please select from the following: ");
            Console.WriteLine("1)Rock");
            Console.WriteLine("2)Paper");
            Console.WriteLine("3)Scissors");
            string input = Console.ReadLine().Trim();

            if(input=="1")
            {
                return Enum.Rock.ToString();
            }
            else if (input == "2")
            {
                return Enum.Paper.ToString();
            }
            else if (input == "3")
            {
                return Enum.Scissors.ToString();
            }
            else
            {
                Console.Clear();//it clears the weird answer we got
                Console.WriteLine("I did not follow that response. Let`s try again");
                return GetRPS();
            }
        }


        
    }
}
