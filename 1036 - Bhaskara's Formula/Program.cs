double A, B, C, R1, R2, x;
string [] var = Console.ReadLine().Split(' ');
A = double.Parse(var[0]);
B = double.Parse(var[1]);
C = double.Parse(var[2]);

x = B * B - 4 * A * C;

if (A == 0 || B * B - 4 * A * C < 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    double sqrt = Math.Sqrt(x);
    R1= (-B + sqrt) / (2 * A);
    R2 = (-B - sqrt) / (2 * A);
    System.Console.WriteLine("R1 = "+R1.ToString("F5"));
    System.Console.WriteLine("R2 = "+R2.ToString("F5"));
}