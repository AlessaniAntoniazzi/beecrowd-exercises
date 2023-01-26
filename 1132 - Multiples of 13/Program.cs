int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int sum = 0;
int min = 0;
int max = 0;
if (x > y)
{
    min = y;
    max = x;
}
else
{
    min = x;
    max = y;
}
for (int i = min; i <= max; i++)
{
    if (i%13!=0)
    {
        sum +=i;
    }
}
System.Console.WriteLine(sum);