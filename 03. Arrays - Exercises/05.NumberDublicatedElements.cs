//Write a program in C# Sharp to count a total
//number of duplicate elements in an array.

//INPUT
int[] arrayOne = new int[int.Parse(Console.ReadLine())];
int[] arrayTwo = new int[arrayOne.Length];

//ACTION
for (int i = 0; i < arrayOne.Length; i++)
{
    arrayOne[i] = int.Parse(Console.ReadLine());
}

for (int j = 0; j < arrayOne.Length; j++)
{
    arrayTwo[j] = arrayOne[j];
}


