int x = 1;
int y = 1;
while (x != 0 && y != 0)
{
    string [] var = Console.ReadLine().Split(' ');
    x = int.Parse(var[0]);
    y = int.Parse(var[1]);
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("primeiro");
    }
    else if (x > 0 && y < 0)
    {
        System.Console.WriteLine("quarto");
    }
    else if ( x < 0 && y < 0)
    {
        System.Console.WriteLine("terceiro");
    }
    else if ( x < 0 && y > 0)
    {
        System.Console.WriteLine("segundo");
    }
}