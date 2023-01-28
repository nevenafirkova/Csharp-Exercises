//Write a program in C# Sharp to store
//elements in an array and print it.

//INPUT
int[] ints = new int[int.Parse(Console.ReadLine())];

//OUTPUT
Console.Write("Elements in the array are: ");

for (int i = 0; i < ints.Length; i++)
{
    Console.Write($"{i} ");
}
