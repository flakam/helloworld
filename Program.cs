using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;





namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Enum.Paper);//cannot use .1 or []
            Rocky r = new Rocky("Rock");
            HumanPick h = new HumanPick("Dwayne Johnson");
            // string output = h.GetRPS();
            // Console.WriteLine(r.GetRPS());
            // Console.WriteLine(output);
            Random rando = new Random();
            Random randy = new Random();
            for (int i = 0; i < 100; i++)
            {
               
                int num = rando.Next(1, 4);
                Console.WriteLine("Random 1: " + num);
                int num2 = randy.Next(1, 4);
                Console.WriteLine("Random 2: " + num2);
                Console.WriteLine();
            }

            
           
        }
    }
}
