double x, y, z;
x = double.Parse(Console.ReadLine());
if (x > 0 && x <= 400.00)
{
    y = (x * 0.15);
    z = x + y;
    System.Console.WriteLine("Novo salario: " + z.ToString("F2"));
    System.Console.WriteLine("Reajuste ganho: " + y.ToString("F2"));
    System.Console.WriteLine("Em percentual: 15 %");
}
else if (x <= 400.01 && x <= 800.00)
{
    y = (x * 0.12);
    z = x + y;
    System.Console.WriteLine("Novo salario: " + z.ToString("F2"));
    System.Console.WriteLine("Reajuste ganho: " + y.ToString("F2"));
    System.Console.WriteLine("Em percentual: 12 %");
}
else if (x >= 800.01 && x <= 1200.00)
{
    y = (x * 0.10);
    z = x + y;
    System.Console.WriteLine("Novo salario: " + z.ToString("F2"));
    System.Console.WriteLine("Reajuste ganho: " + y.ToString("F2"));
    System.Console.WriteLine("Em percentual: 10 %");
}
else if (x >= 1200.01  && x <= 2000.00)
{
    y = (x * 0.07);
    z = x + y;
    System.Console.WriteLine("Novo salario: " + z.ToString("F2"));
    System.Console.WriteLine("Reajuste ganho: " + y.ToString("F2"));
    System.Console.WriteLine("Em percentual: 7 %");
}
else if ( x >= 2000.01)
{
    y = (x * 0.04);
    z = x + y;
    System.Console.WriteLine("Novo salario: " + z.ToString("F2"));
    System.Console.WriteLine("Reajuste ganho: " + y.ToString("F2"));
    System.Console.WriteLine("Em percentual: 4 %");
}