int x = 1;
int y = 2;
int z = 3;
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i ++)
{
    System.Console.WriteLine(x+" "+y+" "+z+" PUM");
    x = x + 4;
    y = y + 4;
    z = z + 4;
}