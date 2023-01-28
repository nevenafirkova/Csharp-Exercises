//Write a program in C# Sharp to find the
//sum of all elements of the array.

//INPUT
int[] numbers = new int[int.Parse(Console.ReadLine())];
int numbersSum = 0;

//ACTION
for (int i = 0; i < numbers.Length; i++)
{
    //Elements Values
    numbers[i] = int.Parse(Console.ReadLine());
}

//Sum
for (int j = 0; j < numbers.Length; j++)
{
    numbersSum += numbers[j];
}

//OUTPUT
Console.WriteLine($"Sum of all elements stored in the array is: {numbersSum}");
