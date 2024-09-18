using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        PrintIntro();

        // Ask for the player's name (fix the code to make it run etc)
        string name = AskForName();
        Console.WriteLine($"Welcome, {name}! Your adventure begins now...\n");

        // ROOM #1: Deadly Trap Room
        Console.WriteLine("You are now in ROOM #1: Deadly Trap Room");
        Console.WriteLine("The walls are closing in, and the room is heating up. " +
                          "Your only way out is to solve the following puzzles to uncover the password.\n");

        // Solve puzzles and check if the player passed Room #1
        if (!SolveRoom1())
        {
            // The player failed Room #1; end the game here
            Console.WriteLine("\nOh no! You failed in ROOM #1 and have turned into a ZOMBIEEE!!!!");
            EndGame();
            return; // Exit the game immediately without showing Room #2
        }

        Console.WriteLine("\nYou have successfully escaped Room #1!");

        // ROOM #2: Zombie Room (only if Room #1 is passed)
        Console.WriteLine("\nYou have successfully moved to ROOM #2: Zombie Room");
        Console.WriteLine("The room is filled with zombies! To survive, you need a weapon and must prove you are human.\n");

        // Choose your weapon
        string weapon = ChooseWeapon();
        Console.WriteLine($"You armed yourself with: {weapon}\n");

        // If all puzzles were passed, the player is human and escapes
        Console.WriteLine("Congratulations! You have proven you are human. You escaped the haunted house alive!\n");

        // End the game successfully
        EndGame();
    }

    // Function to print game introduction
    static void PrintIntro()
    {
        Console.WriteLine("Welcome, brave soul! You have entered the most spine-chilling, bone-rattling haunted house.");
        Console.WriteLine("Your only hope of survival? Complete the tasks that lie ahead. But be warned: every corner hides a new nightmare.");
        Console.WriteLine("Will you make it out alive? Let the terror begin... Good luck!\n");
    }

    // Function to ask for player's name
    static string AskForName()
    {
        Console.WriteLine("Before we begin, brave one, what should I call you?");
        string name = Console.ReadLine(); // Player can input their name
        return name;
    }

    // Function to solve Room #1 and return if the player passed the room
    static bool SolveRoom1()
    {
        // First Password
        if (!CheckPuzzleResult(GetFirst(), 666, "GetFirst"))
            return false;

        // Second Password
        if (!CheckPuzzleResult(GetSecond(), 258, "GetSecond"))
            return false;

        // Third Password
        if (!CheckPuzzleResult(GetThird(), 797, "GetThird"))
            return false;

        // Fourth Password
        if (!CheckPuzzleResult(GetFourth(), 861, "GetFourth"))
            return false;

        // All puzzles solved successfully
        Console.WriteLine("\nYou have successfully solved all puzzles in Room #1.");
        return true;
    }

    // Helper function to check if the puzzle result matches the expected value
    static bool CheckPuzzleResult(int result, int expected, string functionName)
    {
        if (result != expected)
        {
            Console.WriteLine($"You died. {functionName} failed. Expected {expected}, got {result}.");
            return false;
        }
        return true;
    }

    // Function to choose a weapon
    static string ChooseWeapon()
    {
        Console.WriteLine("You need to choose a weapon to defend yourself against the zombies. What will it be?");
        Console.WriteLine("Enter your weapon of choice (e.g., BAZUKA, SWORD, SHIELD):");
        string weapon = Console.ReadLine(); // Player can choose any weapon
        return weapon;
    }

    // Puzzle 1: Multiplication (GetFirst)
    static int GetFirst()
    {
        int num1 = 222;
        int num2 = 3;
        return num1 * num2; // Should return 666
    }

    // Puzzle 2: Division (GetSecond)
    static int GetSecond()
    {
        int num1 = 516;
        int num2 = 2;
        return num1 / num2; // Should return 258
    }

    // Puzzle 3: Addition (GetThird)
    static int GetThird()
    {
        int num1 = 97;
        int num2 = 0;
        return num1 + num2; // Should return 797
    }

    // Puzzle 4: Subtraction (GetFourth)
    static int GetFourth()
    {
        int num1 = 61;
        int num2 = 0;
        return num1 - num2; // Should return 861
    }

    // Function to end the game
    static void EndGame()
    {
        Console.WriteLine("\nGame Over. Thanks for playing!");
    }
}
