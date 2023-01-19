int min, max;
int z = 0;
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x < y)
{
    min = x;
    max = y;
}
else
{
    min = y;
    max = x;
}


for (int i = min+1; i < max; i++)
{
    if (i % 2 != 0) 
    {
        z = z+ i;
    }
}
System.Console.WriteLine(z);
