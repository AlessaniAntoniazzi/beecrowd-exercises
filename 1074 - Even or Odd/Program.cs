int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++ )
{
    int x = int.Parse(Console.ReadLine());
    if (x == 0)
    {
        System.Console.WriteLine("NULL");
    }
    else if (x%2 == 0)
    {
        if(x > 0)
        {
            System.Console.WriteLine("EVEN POSITIVE");
        }
        else
        {
            System.Console.WriteLine("EVEN NEGATIVE");
        }
    }
    else
    {
        if(x > 0)
        {
            System.Console.WriteLine("ODD POSITIVE");
        }
        else
        {
            System.Console.WriteLine("ODD NEGATIVE");
        }
    }
}    