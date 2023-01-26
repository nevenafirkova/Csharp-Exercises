//Write a C# Sharp program to accept two integers
//and check whether they are equal or not.

//INPUT
int[] numbers = new int[2];
numbers[0] = int.Parse(Console.ReadLine());
numbers[1] = int.Parse(Console.ReadLine());

//ACTION
if (numbers[0] == numbers[1])
{
    //Output
    Console.WriteLine($"Numbers {numbers[0]} and {numbers[1]} are equal.");
}
else
{
    //Output
    Console.WriteLine($"Numbers {numbers[0]} and {numbers[1]} are not equal.");
}
