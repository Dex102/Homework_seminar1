Console.Write("Input number one: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number two: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number three: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max && number2 > number3)
{
    max = number2;
}
else if (number3 > max && number3 > number2) 
{
    max = number3;
}

Console.Write($"Max number is {max}");
