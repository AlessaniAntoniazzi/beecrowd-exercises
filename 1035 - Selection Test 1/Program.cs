int A, B, C, D;
string [] var = Console.ReadLine().Split(' ');
A = int.Parse(var[0]);
B = int.Parse(var[1]);
C = int.Parse(var[2]);
D = int.Parse(var[3]);
if (B>C && D>A && C+D > A+B && C > 0 && D>0 && A%2==0)
{
    System.Console.WriteLine("Valores aceitos");
}
else
{
    System.Console.WriteLine("Valores nao aceitos");
}