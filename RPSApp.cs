using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class RPSApp
    {
        private Rocky r;
        private HumanPick h;

        public RPSApp(HumanPick a,RandomPlayer b)
       {
           Console.WriteLine("Hello!You get to choose two options:");
            Console.WriteLine("1)Random Pick");
            Console.WriteLine("2)Pick from console");
            string input2 = Console.ReadLine().Trim().ToLower();

           if(input2 =="1")
            {
                b.GetRPS();
            }
            else if(input2=="2")
            {
                a.GetRPS();
            }
        }

        public RPSApp(Rocky r, HumanPick h)
        {
            this.r = r;
            this.h = h;
        }
    }
}
