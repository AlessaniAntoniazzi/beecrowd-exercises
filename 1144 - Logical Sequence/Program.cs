int b = 1;
int c = 1;
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N;i++)
{
    b = i * i;
    c = i* i* i;
    System.Console.WriteLine(i+" "+b+" "+c);
    System.Console.WriteLine(i+" "+(b+1)+" "+(c+1));
}



