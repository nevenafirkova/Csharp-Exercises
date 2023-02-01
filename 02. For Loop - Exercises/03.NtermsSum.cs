//Write a program in C# Sharp to display n terms of natural number and their sum.

//INPUT
int inputNumber = int.Parse(Console.ReadLine());

//CHANGEABLE
int numbersSum = 0;

//ACTION
for (int i = 1; i <= inputNumber; i++)
{
    numbersSum += i;
}

//OUTPUT
Console.WriteLine($"The sum of all natural numbers up to {inputNumber} terms is: {numbersSum}.");
