//Write a C# Sharp program to check whether
//a given number is positive or negative.

//INPUT
double number = double.Parse(Console.ReadLine());

//ACTION
if (number > 0)
{
    Console.WriteLine($"{number} is a positive number.");
}
else if (number < 0)
{
    Console.WriteLine($"{number} is a negative number.");
}
else
{
    Console.WriteLine("Your given number is 0.");
}