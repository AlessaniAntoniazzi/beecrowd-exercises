int x;
int y;
while (true)
{
    x = int.Parse(Console.ReadLine());
    if (x == 0)
    {
        break;
    }
    else if (x%2 == 0)
    {
        y = x + (x+2)+(x+4)+(x+6)+(x+8);
        System.Console.WriteLine(y);
    }
    else if (x%2 != 0)
    {
        x = x+1;
        y = x + (x+2)+(x+4)+(x+6)+(x+8);
        System.Console.WriteLine(y);
    }
    
}