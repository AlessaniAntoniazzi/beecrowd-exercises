int sum = 0;
int max = 0;
int min = 0;
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i ++)
{
    string [] numbers = Console.ReadLine().Split(' ');
    int x = int.Parse(numbers[0]);
    int y = int.Parse(numbers[1]);
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
    for (int e = min + 1; e < max; e ++)
    {
        if (e%2 != 0)
        {
            sum +=e;
            
        }
       
    }
    System.Console.WriteLine(sum);
    sum = 0;
}
