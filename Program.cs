using System;

namespace AbilityScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ability score calculator");
            Console.WriteLine("1) I have created a class");
            Console.WriteLine("2) I instanciated the class");
            AbilityScoreCalculator MyScoreCalculator = new AbilityScoreCalculator();
        }
    }
}
