//Write a C# Sharp program to find whether
//a given year is a leap year or not.

//INPUT
int year = int.Parse(Console.ReadLine());

//ACTION
if (year % 4 == 0)
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is not a leap year.");
}