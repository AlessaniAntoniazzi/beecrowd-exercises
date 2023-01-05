double A, B, C, perimeter, area;
string [] var = Console.ReadLine().Split(' ');
A = double.Parse(var[0]);
B = double.Parse(var[1]);
C = double.Parse(var[2]);
if ((A + B > C) && (B + C > A) && (A + C > B))
{
    perimeter = A+B+C;
    Console.WriteLine("Perimetro = "+perimeter.ToString("F1"));
}
else 
{
    area = (A + B) * C / 2;
    Console.WriteLine("Area = "+area.ToString("F1"));
}