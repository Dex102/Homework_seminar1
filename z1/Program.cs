Console.Write("Input numer one: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numer two: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) 
{
    Console.WriteLine($"Max number - {number1}");
    Console.WriteLine($"Min number - {number2}");
}
else 
{
    Console.WriteLine($"Max number - {number2}");
    Console.WriteLine($"Min number - {number1}");
}
