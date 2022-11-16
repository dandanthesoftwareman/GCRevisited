
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

//bool runProgram = true;
//while (runProgram)
//{
//    Console.WriteLine("Please enter a whole number");
//    int number = int.Parse(Console.ReadLine());

//    for (int i = 1; i <= number; i++)
//    {
//        Console.WriteLine(i * i);
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

//exercise 15

//bool runProgram = true;
//while (runProgram)
//{
//    Console.WriteLine("Please enter a whole number");
//    int number = int.Parse(Console.ReadLine());

//    for (int i = 1; i <= number; i++)
//    {
//        Console.WriteLine(i * i * i);
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

//exercise 16

//string asterisks = "*";
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(asterisks);
//    asterisks += "*";
//}

//exercise 17

//string asterisks = " *";
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(asterisks);
//    asterisks += " *";
//}

//exercise 18

//bool runProgram = true;
//while (runProgram)
//{
//    Console.WriteLine("Please enter a whole number");
//    int number = int.Parse(Console.ReadLine());
//    int sum = 0;

//    for (int i = 1; i <= number; i++)
//    {
//        sum += i;
//    }
//    Console.WriteLine(sum);

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

//exercise 19


//bool runProgram = true;
//while (runProgram)
//{
//    Console.WriteLine("enter a number");
//    int num1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("enter a higher number");
//    int num2 = int.Parse(Console.ReadLine());
//    int sum = 0;
//    for (int i = num1; i <= num2; i++)
//    {
//        sum += i;
//    }
//    Console.WriteLine($"The sum of all the numbers from {num1} to {num2} is {sum}");

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

//exercise 20

//bool runProgram = true;
//while (runProgram)
//{
//    Console.WriteLine("Enter a number");
//    int num = int.Parse(Console.ReadLine());
//    int product = 1;
//    for (int i = num; i >= (num - 2); i--)
//    {
//        product *= i;
//    }
//    Console.WriteLine($"The product of {num}, {num -1}, and {num -2} is {product}");

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

//exercise 21

//bool runProgram = true;

//while (runProgram)
//{
//    string sentence = "";
//    while (true)
//    {
//        Console.WriteLine("Enter a word:");
//        string word = Console.ReadLine().Trim();
//        sentence += word + " ";
//        Console.WriteLine("Would you like to enter another word? (y/n)");
//        string response = Console.ReadLine();
//        if (response.Trim().ToLower() == "y")
//        {

//            continue;
//        }
//        else if (response.Trim().ToLower() == "n")
//        {
//            break;
//        }
//        else
//        {
//            Console.WriteLine("please enter (y/n)");
//        }
//    }
//    Console.WriteLine(sentence);
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue (y/n)");
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

//exercise 22

//bool runProgram = true;
//bool verifyRange = true;
//while (runProgram)
//{
//    int num1 = 0;
//    int num2 = 0;
//    while (true)
//    {
//        Console.WriteLine("enter a number");
//        num1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter another number");
//        num2 = int.Parse(Console.ReadLine());
//        if (num1 > num2)
//        {
//            Console.WriteLine($"Your range is {num2}-{num1}");
//            break;
//        }
//        else if (num1 < num2)
//        {
//            Console.WriteLine($"Your range is {num1}-{num2}");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter two different numbers");
//        }
//    }

//    while (verifyRange)
//    {
//        Console.WriteLine("Enter a number to verify it is in range");
//        int num = int.Parse(Console.ReadLine());

//        if (num1 > num2)
//        {
//            if (num >= num2 && num <= num1)
//            {
//                Console.WriteLine("Number is in range");
//            }
//            else
//            {
//                Console.WriteLine("Number is out of range");
//            }
//        }
//        else if (num1 < num2)
//        {
//            if (num <= num2 && num >= num1)
//            {
//                Console.WriteLine("Number is in range");
//            }
//            else
//            {
//                Console.WriteLine("Number is out of range");
//            }
//        }
//        while (true)
//        {
//            Console.WriteLine("Would you like to continue? (y/n)");
//            string response = Console.ReadLine();
//            if (response.Trim().ToLower() == "y")
//            {
//                break;
//            }
//            else if (response.Trim().ToLower() == "n")
//            {
//                Console.WriteLine("Goodbye!");
//                verifyRange = false;
//                runProgram = false;
//                break;
//            }
//            else
//            {
//                Console.WriteLine("please enter (y/n)");
//            }
//        }
//    }
//}


//exercise 23

//bool runProgram = true;

//while (runProgram)
//{
//    Console.WriteLine("Enter some text");
//    string text = Console.ReadLine().Trim();
//    text = text.Substring(0, 10);
//    Console.WriteLine($"the first 10 characters are {text}");
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}

//exercise 24

//bool runProgram = true;

//while (runProgram)
//{
//    Console.WriteLine("Enter some text");
//    string text = Console.ReadLine();
//    text = text.Substring(text.Length - 10, 10);
//    Console.WriteLine($"The last 10 characters are {text}");
//while (true)
//{
//    Console.WriteLine("Would you like to continue? (y/n)");
//    string response = Console.ReadLine().Trim().ToLower();
//    if (response == "y")
//    {
//        break;
//    }
//    else if (response == "n")
//    {
//        runProgram = false;
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Please enter y/n");
//    }
//}
//}

//exercise 25

//bool runProgram = true;

//while (runProgram)
//{
//    Console.WriteLine("Enter a sentence");
//    string sentence = Console.ReadLine();
//    string[] arr = sentence.Split(' ');
//    foreach(string s in arr)
//    {
//        Console.WriteLine(s);
//    }
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}

//exercise 26

//bool runProgram = true;

//while (runProgram)
//{
//    Console.WriteLine("Enter some text");
//    string text = Console.ReadLine().ToLower();
//    int vowels = 0;
//    foreach(char c in text)
//    {
//        if (c == 'a')
//        {
//            vowels++;
//        }
//        if(c == 'e')
//        {
//            vowels++;
//        }
//        if(c == 'i')
//        {
//            vowels++;
//        }
//        if(c == 'o')
//        {
//            vowels++;
//        }
//        if(c == 'u')
//        {
//            vowels++;
//        }
//    }
//    Console.WriteLine($"There were {vowels} vowels");
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }

//}

//exercise 27

//bool runProgram = true;

//while (runProgram)
//{
//    Console.WriteLine("Enter some text");
//    string text = Console.ReadLine().ToLower();
//    int consonants = 0;
//    foreach (char c in text)
//    {
//        if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
//        {
//            consonants++;
//        }
//    }
//    Console.WriteLine($"There were {consonants} consonants");
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }

//}

//exercise 28

//bool runProgram = true;

//while (runProgram)
//{
//    Console.WriteLine("Enter some text");
//    string text = Console.ReadLine().ToLower();
//    text = text.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
//    Console.WriteLine(text);
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}

//exercise 29 I'M COMING BACK TO THIS ONE

//bool runProgram = true;

//while (runProgram)
//{
//    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
//    Console.WriteLine("Enter some text");
//    string text = Console.ReadLine();
//    string[] words = text.Split(' ').ToArray();
//    for(int i = 0; i < words.Length; i++)
//    {
//        if ((words[i].StartsWith("a") || words[i].StartsWith("e") || words[i].StartsWith("i") || words[i].StartsWith("o") || words[i].StartsWith("u")) && )
//        words[i] = words[i].Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", ""); ;
//    }
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}

//exercise 30

//bool runProgram = true;

//while (runProgram)
//{
//    Console.WriteLine("Enter some text");
//    string text = Console.ReadLine();
//    char [] reversed = text.Reverse().ToArray();
//    string reversedText = "";
//    foreach(char c in reversed)
//    {
//        reversedText += c;
//    }
//    Console.WriteLine(reversedText);
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}

//exercise 31

//bool runProgram = true;

//while (runProgram)
//{
//    int[] arr = { 2, 8, 0, 24, 51 };
//    Console.WriteLine("Enter an array index");
//    int num = int.Parse(Console.ReadLine());
//    if (num > arr.Length || num < 0)
//    {
//        Console.WriteLine("Not A valid index");
//    }
//    else
//    {
//        Console.WriteLine($"the value at index {num} is {arr[num]}");
//    }

//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}

// exercise 32

//bool runProgram = true;

//while (runProgram)
//{
//    int[] arr = { 2, 8, 0, 24, 51 };
//    Console.WriteLine("Enter number");
//    int num = int.Parse(Console.ReadLine());
//    int index = Array.IndexOf(arr, num);
//    if (!arr.Contains(num))
//    {
//        Console.WriteLine("Value could not be found in the array");
//    }
//    else
//    {
//        Console.WriteLine($"the value {num} is {index}");
//    }

//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}

//exercise 33

//bool runProgram = true;
//int[] arr = { 2, 8, 0, 24, 51 };

//while (runProgram)
//{
//    Console.WriteLine("Enter an index number");
//    int num = int.Parse(Console.ReadLine());
//    int index = Array.IndexOf(arr, num);
//    if (num > arr.Length || num < 0)
//    {
//        Console.WriteLine("Index not available");
//    }
//    else
//    {
//        Console.WriteLine($"The value at index {num} is {arr[num]}. Would you like to change it? y/n");
//        while (true)
//        {
//            string response = Console.ReadLine().Trim().ToLower();
//            if (response == "y")
//            {
//                Console.WriteLine($"Please enter a new value for index {num}");
//                int newValue = int.Parse(Console.ReadLine());
//                arr[num] = newValue;
//                Console.WriteLine($"The value at index {num} is now {arr[num]}");
//                break;
//            }
//            else if (response == "n")
//            {
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Please enter y/n");
//            }
//        }
//    }
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}

// exercise 34

//bool runProgram = true;
//double[] arr = { 16, 32, 64, 128, 256 };

//while (runProgram)
//{
//    string arrContent = "";

//    Console.WriteLine("Please enter a command (half/double)");

//    while (true)
//    {
//        string choice = Console.ReadLine().ToLower().Trim();
//        if (choice == "double")
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] *= 2;
//                arrContent += arr[i].ToString() + ", ";
//            }
//            break;
//        }
//        else if (choice == "half")
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] /= 2;
//                arrContent += arr[i].ToString() + ", ";
//            }
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter (double/half)");
//        }
//    }

//    Console.WriteLine($"The array now conatins: {arrContent.Trim()}");

//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }

//}

// exercise 35

//bool runProgram = true;
//string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };

//while (runProgram)
//{
//    Console.WriteLine("Please enter two space-seperated whole numbers (ex 1 3)");
//    string entry = Console.ReadLine();
//    int[] nums = entry.Split(' ').Select(x => int.Parse(x)).ToArray();
//    if(nums[0] > animals.Length || nums[0] < 0 || nums[1] > animals[nums[0]].Length || nums[1] < 0)
//    {
//        Console.WriteLine("Invalid Indices");
//    }
//    else
//    {
//        Console.WriteLine($"The value at index {nums[0]} is {animals[nums[0]]}. The letter at index {nums[1]} is {animals[nums[0]][nums[1]]}");
//    }
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? (y/n)");
//        string response = Console.ReadLine().Trim().ToLower();
//        if (response == "y")
//        {
//            break;
//        }
//        else if (response == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Please enter y/n");
//        }
//    }
//}


bool runProgram = true;
string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };

while (runProgram)
{
    Console.WriteLine("Please enter two space-seperated whole numbers (ex 1 3)");
    string entry = Console.ReadLine();
    int[] nums = entry.Split(' ').Select(x => int.Parse(x)).ToArray();
    int animalsIndex = nums[0];
    string theAnimal = animals[animalsIndex];
    
    if (animalsIndex > animals.Length || animalsIndex < 0 ||
        nums[1] > animals[animalsIndex].Length || nums[1] < 0)
    {
        Console.WriteLine("Invalid Indices");
    }
    else
    {
        Console.WriteLine($"The value at index {nums[0]} is {animals[animalsIndex]}. The letter at index {nums[1]} is {animals[animalsIndex][nums[1]]}");
    }
    while (true)
    {
        Console.WriteLine("Would you like to continue? (y/n)");
        string response = Console.ReadLine().Trim().ToLower();
        if (response == "y")
        {
            break;
        }
        else if (response == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please enter y/n");
        }
    }
}