string FizzBuzz = "FizzBuzz";
int input;
string selection;

do
{
    Console.Clear();
    Console.WriteLine("What do you want to execute?");
    Console.WriteLine("============================");
    Console.WriteLine();
    Console.WriteLine("0. Calculate Circle Area");
    Console.WriteLine("1. Random in Range");
    Console.WriteLine("2. To FizzBuzz");
    Console.WriteLine("3. Fibonacci by Index");
    Console.WriteLine("4. Ask for Number in Range");
    Console.WriteLine("5. Is palindrome?");
    Console.WriteLine("6. Is palindrome? (advanced)");
    Console.WriteLine("7. Chart Bar");
    Console.WriteLine("8. Count Smiling Faces");
    Console.WriteLine("q to Quit");
    selection = Console.ReadLine()!;

    if (selection != "q")
    {
        Console.Clear();
        switch (selection)
        {
            case "0": RunCalculateCircleArea(); break;
            case "1": RunRandomInRage(); break;
            case "2": RunFizzBuzz(); break;
            case "3": RunFibonacciByIndex(); break;
            case "4": AskForNumberInRage(5, 10); break;
            case "5": RunIsPalindrome(); break;
            case "6": RunIsPalindrome(); break;
            // TODO: Add additional cases for other methods here

            default: break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
while (selection != "q");
// TODO: Create one code region for each level
#region Calculate Circle Area
void RunCalculateCircleArea()
{
    Console.Write("Enter radius:");
    var radius = double.Parse(Console.ReadLine()!);
    var area = CalculateCircleArea(radius);
    Console.WriteLine($"Area of circle with radius {radius} is {area}");
}

double CalculateCircleArea(double radius)
{
    return radius * radius * Math.PI;
}
#endregion

#region Random Inrage
int RandomInRage(int minimum, int maximum)
{
    return Random.Shared.Next(minimum, maximum + 1);
}

void RunRandomInRage()
{
    int count0 = 0;
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i < 1000000; i++)
    {
        int randomnumber = RandomInRage(0, 2);
        System.Console.Write($"{randomnumber}");
        if (randomnumber == 0)
        {
            count0++;
        }
        else if (randomnumber == 1)
        {
            count1++;
        }
        else
        {
            count2++;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{count0} {count1} {count2}");
}
#endregion

#region ToFizzBuzz
string ToFizzBuzz(int input)
{
    if (input % 3 == 0 && input % 5 == 0)
    {
        FizzBuzz = "FizzBuzz";
    }
    else if (input % 3 == 0)
    {
        FizzBuzz = "Fizz";
    }
    else if (input % 5 == 0)
    {
        FizzBuzz = "Buzz";
    }
    else
    {
        FizzBuzz = "";
    }
    return FizzBuzz;
}

void RunFizzBuzz()
{
    System.Console.WriteLine("Enter a number");
    int number = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine(ToFizzBuzz(number));
}
#endregion

#region Fibonacci By Index
int FibonacciByIndex(int index)
{
    int temp = 0;
    int first = 0;
    int second = 1;
    int next = first + second;
    do
    {
        first = second;
        second = next;
        next = first + second;
        temp++;
    }
    while (temp < index);
    return first;
}

void RunFibonacciByIndex()
{
    System.Console.WriteLine("Enter a number");
    int numberindex = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine(FibonacciByIndex(numberindex));
}
#endregion

#region AskForNumberInRage
int AskForNumberInRage(int minimum, int maximum)
{
    System.Console.WriteLine($"Enter a number between {minimum} and {maximum}");
    do
    {
        input = int.Parse(Console.ReadLine()!);

        if (input > maximum)
        {
            System.Console.WriteLine($"Wrong number. Your input is too high. The maximum is {maximum}. Try again!");
        }
        else if (input < minimum)
        {
            System.Console.WriteLine($"Wrong number. Your input is too low. The minimum is {minimum}. Try again!");
        }
        else
        {
            System.Console.WriteLine("Thank you, your input is valid.");
        }
    }
    while (input < minimum || input > maximum);
    return input;
}

#endregion


#region Is Palindrome
bool IsPalindrome(string word)
{
    if (word == "")
    {
        return false;
    }
    word.Replace(",", "");
    word.Replace(".", "");
    word.Replace("-", "");
    word.Replace(" ", "");
    word.ToLower();

    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

void RunIsPalindrome()
{
    System.Console.WriteLine("Enter a word");
    string wordpalindrome = (Console.ReadLine()!);
    System.Console.Write("The text is ");
    if (!IsPalindrome(wordpalindrome))
    {
        System.Console.Write("not ");
    }
    System.Console.Write("a palindrome");

}
#endregion