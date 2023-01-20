int N = int.Parse(Console.ReadLine());
double z = 0;
for (int i = 0; i < N; i++)
{
    string [] var = Console.ReadLine().Split(' ');
    int x = int.Parse(var[0]);
    int y = int.Parse(var[1]);
    
    if(y == 0)
    {
        System.Console.WriteLine("divisao impossivel");
    }
    else
    {
        z = (double)x/y;
        System.Console.WriteLine(z.ToString("F1"));
    }

}