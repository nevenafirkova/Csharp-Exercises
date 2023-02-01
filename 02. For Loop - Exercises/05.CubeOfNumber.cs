//Write a program in C# Sharp to display the cube of the number up to given an integer.

//INPUT
int numbersCnt = int.Parse(Console.ReadLine());

//ACTION
for (int i = 1; i <= numbersCnt; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    //OUTPUT
    Console.WriteLine($"The current number is: {currentNumber} and cube of it is: {currentNumber * currentNumber * currentNumber}");
}
