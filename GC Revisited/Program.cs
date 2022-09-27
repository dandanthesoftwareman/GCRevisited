
//excercise 1

//Console.WriteLine("Enter Some Text");
//string text = Console.ReadLine();
//Console.WriteLine(text + " ECHOOO!!");

//exercise 2

//Console.WriteLine("Enter a number");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine(number + 1);

//exercise 3

//Console.WriteLine("enter a number");
//double number = double.Parse(Console.ReadLine());
//Console.WriteLine(number + .5);

//exercise 4

//Console.WriteLine("Enter a number");
//double num1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter another number");
//double num2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Sum: " + (num1 + num2));

//exercise 5

//Console.WriteLine("Enter a number");
//double num1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter another number");
//double num2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Product: " + (num1 * num2));

//exercise 6

//do
//{
//    Console.WriteLine("Hello World");
//    Console.WriteLine("Would you like to continue (y/n)?");
//    string response = Console.ReadLine();
//    if (response.ToLower() == "y")
//    {
//        continue;
//    }
//    else if (response.ToLower() == "n")
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine("please eneter (y/n)");
//    }
//}
//while (true);

//exercise 7

//bool runProgram = true;
//do
//{
//    Console.WriteLine("Enter Some Text");
//    string text = Console.ReadLine();
//    Console.WriteLine(text + " ECHOOO!!");
//    Console.WriteLine("Would you like to continue (y/n)?");
//    string response = Console.ReadLine();
//    if (response.ToLower() == "y")
//    {
//        continue;
//    }
//    else if (response.ToLower() == "n")
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine("please eneter (y/n)");
//    }
//}
//while (runProgram);

//exercise 8

//bool runProgram = true;
//do
//{
//    Console.WriteLine("Enter a number");
//    int number = int.Parse(Console.ReadLine());
//    Console.WriteLine(number + 1);
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue (y/n)?");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {
//            break;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }
//}
//while (runProgram);
//------------------------------------------------------------------//
//bool runProgram = true;
//do
//{
//    Console.WriteLine("enter a number");
//    double number = double.Parse(Console.ReadLine());
//    Console.WriteLine(number + .5);
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue (y/n)?");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {
//            break;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }
//}
//while (runProgram);
//-------------------------------------------------------------------//
//bool runProgram = true;
//do
//{
//    Console.WriteLine("Enter a number");
//    double num1 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Enter another number");
//    double num2 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Product: " + (num1 * num2));
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue (y/n)?");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {
//            break;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }
//}
//while (runProgram);

//exercise 9

//bool runProgram = true;
//do
//{

//    Console.WriteLine("Enter A Language");
//    string language = Console.ReadLine();
//    if(language.ToLower().Trim() == "english")
//    {
//        Console.WriteLine("Hello World");
//    }
//    else if(language.ToLower().Trim() == "spanish")
//    {
//        Console.WriteLine("Hola Mundo");
//    }
//    else if (language.ToLower().Trim() == "dutch")
//    {
//        Console.WriteLine("Hallo wereld");
//    }

//    while (true)
//    {
//        Console.WriteLine("Would you like to continue (y/n)?");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {
//            break;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            Console.WriteLine("Goodbye!");
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }
//}
//while (runProgram);

//exercise 10

//bool runProgram = true;
//do
//{

//    Console.WriteLine("Your Height in Inches");
//    double height = double.Parse(Console.ReadLine());
//    if (height <= 54)
//    {
//        Console.WriteLine("You are too short to ride the raptor");
//    }
//    else if (height > 54)
//    {
//        Console.WriteLine("You can ride the raptor");
//    }
//    else if (height <= 0)
//    {
//        Console.WriteLine("You can't be that tall");
//    }
//    else if (height == null)
//    {
//        Console.WriteLine("Fine. Dont enter anthing. I see how it is.");
//    }

//    while (true)
//    {
//        Console.WriteLine("Would you like to continue (y/n)?");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {
//            break;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            Console.WriteLine("Goodbye!");
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }
//}
//while (runProgram);

//exercise 11

//bool runProgram = true;
//while (runProgram)
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine(i);
//    }
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {
//            break;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            Console.WriteLine("Goodbye!");
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }

//}

//exercise 12

//bool runProgram = true;
//while (runProgram)
//{
//    for (int i = 9; i >= 0; i--)
//    {
//        Console.WriteLine(i);
//    }
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {
//            break;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            Console.WriteLine("Goodbye!");
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }

//}

//excercise 13

//bool runProgram = true;
//while (runProgram)
//{
//    Console.WriteLine("Please enter a whole number");
//    int number = int.Parse(Console.ReadLine());

//    for (int i = number; i >= 0; i--)
//    {
//        Console.WriteLine(i);
//    }
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {
//            break;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            Console.WriteLine("Goodbye!");
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }

//}

//exercise 14  

bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please enter a whole number");
    int number = int.Parse(Console.ReadLine());

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(i * i);
    }
    while (true)
    {
        Console.WriteLine("Would you like to continue? (y/n)");
        string response = Console.ReadLine();
        if (response.Trim().ToLower() == "y")
        {
            break;
        }
        else if (response.Trim().ToLower() == "n")
        {
            Console.WriteLine("Goodbye!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("please enter (y/n)");
        }
    }
}