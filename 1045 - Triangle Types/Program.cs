string [] var = Console.ReadLine().Split(' ');
double A = double.Parse(var[0]);
double B = double.Parse(var[1]);
double C = double.Parse(var[2]);

double[] sides = new double[] { A, B, C};
Array.Sort(sides);
Array.Reverse(sides);
A = sides[0];
B = sides[1];
C = sides[2];



if (A >= B + C)
{
    System.Console.WriteLine("NAO FORMA TRIANGULO");
}
else 
{
    if ((A * A) == (B * B) + (C * C))
    {
        System.Console.WriteLine("TRIANGULO RETANGULO");
    } 
    if ((A * A) > (B * B) + (C * C))
    {
        System.Console.WriteLine("TRIANGULO OBTUSANGULO");
    }
    if ((A* A) < (B* B) + (C * C)) 
    {
    System.Console.WriteLine("TRIANGULO ACUTANGULO");
    }
    if (A == B && B == C)
    {
        System.Console.WriteLine("TRIANGULO EQUILATERO");
    }
    if (A == B && C !=A || C == A && C != B || B == C && B != A)
    {
        System.Console.WriteLine("TRIANGULO ISOSCELES");
    }
}

