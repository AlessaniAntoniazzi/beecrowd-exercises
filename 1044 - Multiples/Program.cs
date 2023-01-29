int A, B;
string [] var = Console.ReadLine().Split(' ');
A = int.Parse(var[0]);
B = int.Parse(var[1]);
if (B % A == 0|| A % B ==0 )
{
    System.Console.WriteLine("Sao Multiplos");
}
else
{
    System.Console.WriteLine("Nao sao Multiplos");
}