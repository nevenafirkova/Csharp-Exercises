//Write a program in C# Sharp to read n number
//of values in an array and display it in reverse order.

//INPUT
int[] numbers = new int[int.Parse(Console.ReadLine())];

//ACTION
for (
    int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine()); 
}

//OUTPUT

Console.Write("The values store into the array are: ");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine();
Console.Write("The values store into the array in reverse are: ");
for (int j = numbers.Length -1; j >= 0; j--)
{
    Console.Write($"{numbers[j]} ");
}