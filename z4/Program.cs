Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int numbers = 1;

while (numbers <= number)
{
    if (numbers % 2 == 0)
    {
        Console.Write($"{numbers} ");
    }
    numbers += 1;
}
