//Write a C# Sharp program to check whether
//a given number is even or odd.

//INPUT
int number = int.Parse(Console.ReadLine());

//ACTION
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is an even number.");
}
else
{
    Console.WriteLine($"{number} is an odd number.");
}
