double numberCounter = 0;
for (double i = 0; i < 6; i++)
{
    double number = double.Parse(Console.ReadLine());
    if (number > 0)
    {
        numberCounter ++;
    }
}

Console.WriteLine(numberCounter+ " valores positivos");