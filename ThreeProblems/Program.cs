using System.Runtime.CompilerServices;

int choice = 0;
Random rng = new Random(4000);

// This loop will need to continue until the user chooses to end the program, so the do while loop is required.
do
{
    Console.Write("=== CSCI 1250 Lab 06 ===\n1. The Grade Checker\n2. The Dice Table\n3. The Score Report\n4. All Three\n5. Quit\nChoose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());


    if (choice > 5 || choice < 1)
    {
        Console.WriteLine("Invalid input. Please try again.\n");
    }


    if (choice == 1 || choice == 4)
    {
        int score = 1;

        Console.Write("== Exercise 1: The Grade Checker ===\nScore: ");

        while(score >= 0 || score <=100) 
        {   
        
            score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine($"{score} earns an A. Hooray!\n");
            }

            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine($"{score} earns a B.\n");
            }

            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine($"{score} earns a C.\n");
            }

            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine($"{score} earns a D.\n");
            }

            else if (score >= 0 && score <= 59) 
            {
                Console.WriteLine($"{score} earns an F.\n");
            }
            
            Console.Write("A score must be between 0 and 100.\nScore: ");

        }
    }


    if (choice == 2 || choice == 4)
    {
        int rollNum = 0;
        int winNum = 0;
        int roll1 = rng.Next(1, 7);
        int roll2 = rng.Next(1, 7);
        int rollSum = roll1 + roll2;
        bool reroll = Convert.ToBoolean(Console.ReadLine());
        bool y = true;
        bool n = false;

        Console.Write($"=== Exercise 2: The Dice Table ===\nRoll {rollNum + 1}: {roll1} and {roll2}, total {rollSum}.");

        do
        {
            if(roll1 == 1 && roll2 == 1)
            {
                Console.Write("Snake Eyes!\n");
                Console.Write("Roll again? y/n ");
            }

            if(roll1 == roll2)
            {
                Console.Write("Doubles!");
                Console.Write("Roll again? y/n ");
            }

            if(rollSum == 7 || rollSum == 11)
            {
                Console.Write("A Winner!");
                winNum++;
                Console.Write("Roll again? y/n ");
            }

            if(reroll != y || reroll != n)
            {
                Console.Write("Invalid input. Please select 'y' or 'n'.");
                Console.Write("Roll again? y/n ");
            }


        }while(reroll != n);
    }

    if (choice == 3 || choice == 4)
    {
        
    }


}while (choice != 5);

Console.WriteLine("Goodbye.");