using System;

// Class that characterizes the dice for our game
class DiceRolling
{
    // A device from 'class System.Random', that generates pseudo-random numbers
    private Random random;
    // Quantity of dice's sides
    private int countSides;

    public DiceRolling()
    {
        countSides = 6;
        random = new Random();
    }

    // Method that returns value of countSides
    public int GetCountSides()
    {
        return countSides;
    }

    // Here we randomize our roll by using the Random.Next method. Where Next(Int32, Int32), returns a random integer that is within a specified range
    // https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=netframework-4.8
    public int Roll()
    {
        return random.Next(1, countSides + 1);
    }

    // Here we use string concatenation to display one's roll
    public override string ToString()
    {

        return String.Format("You have X rolls left. Result of your dice roll: ", countSides);
    }

    static void Main(string[] args)
    {
        // Constructor initialization
        DiceRolling dice = new DiceRolling();
        
        Console.WriteLine(dice);
        for (int i = 0; i < 5; i++)
            Console.Write(dice.Roll() + " ");
    }

}