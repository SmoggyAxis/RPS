using System.Net.Security;

namespace ConsoleApp1
{
    using System;
    // namespace main{
    class Program

    {
        public static int print;
        public static string answer;
        public static int runs = 0;
        public static int cw = 0;
        public static int t = 0;
        public static int pw = 0;

        public static void MyMethod()

        {

            Console.WriteLine("Beat me at Rock Paper Scissors");
            Console.WriteLine("p=paper s=scissors r=rock");
            answer = Console.ReadLine();
            string[] RPS = { "Rock", "Paper", "Scissors" };
            Random rd = new Random();
            print = rd.Next(0, 3);
            Console.WriteLine(RPS[print]);
            runs += 1;

            if (answer == "p" && print == 0)
            {
                Console.WriteLine("You Win!");
                pw += 1;

            }
            if (answer == "p" && print == 1)
            {
                Console.WriteLine("You Tied!");
                t += 1;

            }
            if (answer == "p" && print == 2)
            {
                Console.WriteLine("You Lose!");
                cw += 1;

            }
            if (answer == "r" && print == 0)
            {
                Console.WriteLine("You Tied!");
                t += 1;

            }
            if (answer == "r" && print == 1)
            {
                Console.WriteLine("You Lost!");
                cw += 1;

            }
            if (answer == "r" && print == 2)
            {
                Console.WriteLine("You Won!");
                pw += 1;

            }
            if (answer == "s" && print == 0)
            {
                Console.WriteLine("You Lost!");
                cw += 1;

            }
            if (answer == "s" && print == 1)
            {
                Console.WriteLine("You Won!");
                pw += 1;
            }
            if (answer == "s" && print == 2)
            {
                Console.WriteLine("You Tied!");
                t += 1;
            }
            Console.WriteLine("Overall:" + "  Losses:" + cw + "  Ties:" + t + "  Wins:" + pw);


        }
        public static void Main(string[] args)
        {



            // Console.WriteLine("what is your name");  

            // name = Console.ReadLine();

            // Console.WriteLine("hello " + name);

            // Console.WriteLine("what is your age?");  

            while (true)
            {
                MyMethod();
            }


        }

    }
}