/*
 * Class name: Banking App
 * Version 1
 * Author Noah Mullen
*/

BuildBankingApp();

void BuildBankingApp()
{
    int choice;
    double depositAmount, accountBalance = 1000.00;

    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 = Deposit or withdrawl");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option via a number");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 || choice == 2)
    {
        //Valid menu choice
        if (choice == 1)
        {
            //Deposit or withdrawl
            Console.WriteLine("You have chosen to deposit or withdrawl funds");
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter amount:");

            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");

            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance was {accountBalance}");
        }
        if (choice == 2)
        {
            //View acc info
            Console.WriteLine("You have chosen to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
    }
    else
    {
        //View account info
        Console.WriteLine($"Your current account balance is {accountBalance}");
    }

}

//Read user's current choice.
//Convert string to integer using explicit typecasting

