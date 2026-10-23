using System.Runtime.CompilerServices;
using System.Xml.Schema;

/*
* Name: Zander Malone
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 23, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

int choice = 0;
Random rng = new Random(4000);

// This loop will need to continue until the user chooses to end the program, so the do while loop is required.
do
{
    Console.Write("=== CSCI 1250 Lab 06 ===\n1. The Grade Checker\n2. The Dice Table\n3. The Score Report\n4. All Three\n5. Quit\nChoose 1 through 5: ");
    
    choice = Convert.ToInt32(Console.ReadLine());

    //EXERCISE 1
    if(choice == 1 || choice == 4)
    {
        int score = -5;

        Console.Write("== Exercise 1: The Grade Checker ===\nScore: ");

        // this while loop will continue as long as the user's score is within range, and it continues to check the score before each input.
        while(score < 0 || score > 100) 
        {   
            score = Convert.ToInt32(Console.ReadLine());
            

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine($"{score} earns an A. Hooray!\n");
                Console.Write("Score: ");
            }

            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine($"{score} earns a B.\n");
                Console.Write("Score: ");
            }

            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine($"{score} earns a C.\n");
                Console.Write("Score: ");
            }

            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine($"{score} earns a D.\n");
                Console.Write("Score: ");
            }

            else if (score >= 0 && score <= 59) 
            {
                Console.WriteLine($"{score} earns an F.\n");
                Console.Write("Score: ");
            }

            else if (score < 0 || score > 100)
            {
                Console.Write("A score must be between 0 and 100.\n");
                Console.Write("Score: ");
            }

        }
    }

    //EXERCISE 2
    if(choice == 2 || choice == 4)
    {
        int rollNum = 1;
        int winNum = 0;
        string reroll = "y";

        Console.WriteLine($"=== Exercise 2: The Dice Table ===\n");

        // in this do while loop, the program checks the reroll status after each turn, 
        do
        {
            int roll1 = rng.Next(1, 7);
            int roll2 = rng.Next(1, 7);
            int rollSum = roll1 + roll2;

            Console.WriteLine($"Roll {rollNum++}: {roll1} and {roll2}, total {rollSum}.");
           
            if(roll1 == 1 && roll2 == 1)
            {
                Console.Write("Snake Eyes!\n");
            }

            if(roll1 == roll2 && rollSum != 2)
            {
                Console.Write("Doubles!\n");
            }

            if(rollSum == 7 || rollSum == 11)
            {
                Console.Write("A Winner!\n");
                winNum++;
            }

            if(reroll != "y" && reroll != "n")
            {
                Console.Write("Invalid input. Please select 'y' or 'n'.\n");
            }

            Console.Write("Roll again? (y/n) ");      
            reroll = Console.ReadLine(); 

        }while(reroll != "n");

        Console.WriteLine($"You rolled {rollNum - 1} times and won {winNum}.\n");
    }

    //EXERCISE 3
    if(choice == 3 || choice == 4)
    {
        Console.WriteLine("=== Exercise 3: The Score Report ===\n");

        int[] grades = new int[5];
        int passCount = 0;

        //this loop allows for user input for each grade, going up to 5 since grade[] is limited to 5 slots.
        for(int i= 0; i < grades.Length; i++)
        {
            Console.Write($"Score {i+1}: ");
            grades[i] = Convert.ToInt32(Console.ReadLine()); 
        }

        //this foreach loop follows up the for loop by checking the inputs in the for loop to see if the grades pass.
        foreach(int grade in grades)
        {
            if(grade > 60)
            {
                passCount++;
            }
        }

       double gradeSum = (grades[0] + grades[1] + grades[2] + grades[3] + grades[4]);

       Console.WriteLine(" ");
       Console.WriteLine($"Scores entered: {grades.Length}");
       Console.WriteLine($"Total: {gradeSum}");
       Console.WriteLine($"Average: {gradeSum / grades.Length}");
       Console.WriteLine($"Highest: {grades.Max()}");
       Console.WriteLine($"Passing: {passCount} of {grades.Length}");

    }


    if(choice > 5 || choice < 1)
    {
        Console.WriteLine("Invalid input. Please try again.\n");
    }

}while (choice != 5);

Console.WriteLine("Goodbye.");