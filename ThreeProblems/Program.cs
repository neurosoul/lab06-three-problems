int choice = 0;

// This loop will need to continue until the user chooses to end the program, so the do while loop is required.
do
{
    Console.Write("=== CSCI 1250 Lab 06 ===\n1. The Grade Checker\n2. THe Dice Table\n3. The Score Report\n4. All Three\n5. Quit\nChoose 1 through 5: ");
    Console.ReadLine();

    if (choice > 5 || choice < 1)
    {
        Console.WriteLine("Invalid input. Please try again.\n");
    }

    if (choice == 1 || choice == 4)
    {
        
    }
    if (choice == 2 || choice == 4)
    {
        
    }
    if (choice == 3 || choice == 4)
    {
        
    }


}while(choice != 5);

Console.WriteLine("Goodbye.");