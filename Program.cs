// See https://aka.ms/new-console-template for more information

using Mission2Assignment;

public class Program
{
    private static void Main(string[] args)
    {
        int rolls;
        
        Console.WriteLine("Welcome to the dice throwing simulator!");
        while (true)
        {
            Console.Write("How many dice rolls would you like to simulate? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out rolls))
            {
                Console.WriteLine("Please enter a valid whole number.");
                continue;
            }

            if (rolls <= 0)
            {
                Console.WriteLine("Please enter a number greater than zero.");
                continue;
            }
            
            RollDice rd = new RollDice();
            int[] results = rd.RollDiceSim(rolls);
            
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls + ".");
            
            for (int sum = 2; sum <= 12; sum++)
            {
                int count = results[sum];
                double percentage = (double)count / rolls * 100;
                int stars = (int)Math.Round(percentage);
                string starString = new string('*', stars);
                Console.WriteLine($"{sum}: {starString}");
            }
            
            break;
        }
        
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}