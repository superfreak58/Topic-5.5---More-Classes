using System;

namespace Topic_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Console.WriteLine("Dice Roller");
            Console.WriteLine($"Die 1 = {die1}");   
            die1.DrawRoll();
            Console.WriteLine("Rolling");
            Thread.Sleep(750);
            Console.WriteLine($"Die 2 = {die2}");
            die2.DrawRoll();
            if (die1.Roll == die2.Roll)
            {
                Console.WriteLine("Wow you rolled doubles!");
            }
            else if (die1.Roll + die2.Roll == 7)
            { 
            Console.WriteLine("Getting a sum of seven is not hard but its still cool!");
            }
            if (die1.Roll + die2.Roll == 2) 
            { 
            Console.WriteLine("Snake eyes!");
            }
            if ((die1.Roll + die2.Roll) % 2 == 0) 
            { 
            Console.WriteLine("Even sum! Cool");
            }
            if (die1.Roll > die2.Roll) 
            {
                Console.WriteLine("Your first die is bigger than the other one");
            }
            else if ((die1.Roll < die2.Roll)) 
            {
                Console.WriteLine("Your second die is bigger than the other one");
            }







        }
    }
}
