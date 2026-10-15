using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        string[] choices = {"rock", "paper", "scissors"};

        Console.Write("rock paper or scissor");
        string player = Console.ReadLine();

        string computer = choices[rnd.Next(3)];

        Console.WriteLine("pc choice" + computer);

        if (player == computer)
            Console.WriteLine("draw");
        else if ((player == "rock" && computer == "scissors") ||
                 (player == "paper" && computer == "rock") ||
                 (player == "scissors" && computer == "paper"))
            Console.WriteLine("win");
        else
            Console.WriteLine("lose");
    }
}
