//Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.

//ACTION
double numberInput;
double numbersSum = 0;

for (int i = 1; i < 10; i++)
{
    numberInput = double.Parse(Console.ReadLine());
    numbersSum += numberInput;
}

//OUTPUT
Console.WriteLine($"The sum of the ten numbers is: {numbersSum}");
Console.WriteLine($"The average is: {numbersSum / 10.0}");
