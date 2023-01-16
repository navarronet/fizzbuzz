Console.WriteLine("Enter a number: ");

var userInput = Console.ReadLine();

int num = int.Parse(userInput);

if (num % 5 == 0 && num % 3 == 0)
{
    Console.WriteLine("FizzBuzz");
} else if (num % 5 == 0)
{
    Console.WriteLine("Buzz");
} else if (num % 3 == 0)
{
    Console.WriteLine("Fizz");
} else
{
    Console.WriteLine("No FizzBuzz found.");
}