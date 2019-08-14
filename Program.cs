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
            bool con = true;
            // Console.WriteLine(Enum.Paper);//cannot use .1 or []
            Rocky r = new Rocky("Rock");
            HumanPick h = new HumanPick("Dwayne Johnson");
            RPSApp Y = new RPSApp(r, h);
            Random rando = new Random();
            Random randy = new Random();
            RandomPlayer rp = new RandomPlayer("Flaka", rando);
            RandomPlayer rpp = new RandomPlayer("Drin", randy);
            int counter = 0;
            int point = 0;

            while (con)
            {
                Console.WriteLine();
                int num = rando.Next(1, 4);
                int num2 = randy.Next(1, 4);

                Console.WriteLine("Who do you want to play against?Flaka or Drin?");
                string inputanswer = Console.ReadLine().ToLower();

                if (inputanswer.Contains("Flaka") || inputanswer.Contains("flaka"))
                {
                    string output = h.GetRPS();
                    string choice = rp.GetRPS();
                    Console.WriteLine("You chose: " +output);
                    Console.WriteLine("Flaka Chose: "+choice);
                    Console.WriteLine();
                    if ((output.Contains("Scissors")) && (choice.Contains("Scissors")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("It is a tie.You get 1 point");
                        counter = counter + 1;
                    }
                    else if ((output.Contains("Scissors")) && (choice.Contains("Paper")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!.You get 2 points");
                        counter = counter + 2;

                    }
                    else if ((output.Contains("Scissors")) && (choice.Contains("Rock")))

                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose!.You get 0 points");

                    }
                    else if ((output.Contains("Paper")) && (choice.Contains("Scissors")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose.You get 0 points");

                    }
                    else if ((output.Contains("Paper")) && (choice.Contains("Paper")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("It is a tie.You get 1 point");
                        counter = counter + 1;

                    }
                    else if ((output.Contains("Paper")) && (choice.Contains("Rock")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!.You get 2 points");
                        counter = counter + 2;

                    }
                    else if ((output.Contains("Rock")) && (choice.Contains("Rock")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("It is a tie.You get 1 point");
                        counter = counter + 1;
                    }
                    else if ((output.Contains("Rock")) && (choice.Contains("Paper")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose!.You get 0 points");

                    }
                    else if ((output.Contains("Rock")) && (choice.Contains("Scissors")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!.You get 2 points");
                        counter = counter + 2;//This is the endpoint

                    }
                }
                if (inputanswer.Contains("Drin") || inputanswer.Contains("drin"))

                {
                    string output = h.GetRPS();
                    Console.WriteLine("You chose: " +output);
                    Console.WriteLine("Drin chose: "+ rpp.GetRPS());
                    Console.WriteLine();
                    if ((output.Contains("Scissors")) && (rpp.GetRPS().Contains("Scissors")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("It is a tie.You get 1 point");
                        counter = counter + 1;
                    }
                    else if ((output.Contains("Scissors")) && (rpp.GetRPS().Contains("Paper")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!.You get 2 points");
                        counter = counter + 2;

                    }
                    else if ((output.Contains("Scissors")) && (rpp.GetRPS().Contains("Rock")))

                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose!.You get 0 points");


                    }
                    else if ((output.Contains("Paper")) && (rpp.GetRPS().Contains("Scissors")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose.You get 0 points");

                    }
                    else if ((output.Contains("Paper")) && (rpp.GetRPS().Contains("Paper")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("It is a tie.You get 1 point");
                        counter = counter + 1;

                    }
                    else if ((output.Contains("Paper")) && (rpp.GetRPS().Contains("Rock")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!.You get 2 points");
                        counter = counter + 2;

                    }
                    else if ((output.Contains("Rock")) && (rpp.GetRPS().Contains("Rock")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("It is a tie.You get 1 point");
                        counter = counter + 1;
                    }
                    else if ((output.Contains("Rock")) && (rpp.GetRPS().Contains("Paper")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose!.You get 0 points");

                    }
                    else if ((output.Contains("Rock")) && (rpp.GetRPS().Contains("Scissors")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!.You get 2 points");
                        counter = counter + 2;

                    }


                }
                Console.WriteLine("Your points are: " + counter);
                Console.WriteLine("Do you want to continue?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    con = true;

                    point = point + counter;

                }
                else
                {
                    con = false;
                    Console.WriteLine("Thank you for playing.Your total points are: " + point);

                }


            }



        }
}   }

