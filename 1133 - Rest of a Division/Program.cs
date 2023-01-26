int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int min = 0;
int max = 0;
if (x > y)
{
    min = y;
    max = x;
}

for (int i = min+ 1; i < max; i++)
{
    
    if (i%5 ==2 || i%5==3)
    {
        System.Console.WriteLine(i);
    }

}