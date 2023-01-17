int sum = 0;

for (int i = 0; i < 5; i++)
{
    int number = int.Parse(Console.ReadLine());

    if(number %2 == 0)
    {
        sum += 1;
    }
}

Console.WriteLine(sum + " valores pares");

