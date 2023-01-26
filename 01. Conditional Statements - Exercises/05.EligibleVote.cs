//Write a C# Sharp program to read the age
//of a candidate and determine whether it is
//eligible for casting his/her own vote.

//INPUT
int age = int.Parse(Console.ReadLine());

//ACTION
if (age >= 21)
{
    Console.WriteLine("Congratulations! You are eligible for casting your vote.");
}
else if (21 - age == 1)
{
    Console.WriteLine($"Sorry, you're still not eligible for casting your vote. You need {21 - age} more year to vote.");
}
else
{
    Console.WriteLine($"Sorry, you're still not eligible for casting your vote. You need {21 - age} more years to vote.");
}
