double x = double.Parse(Console.ReadLine());
if (x < 0.00 || x > 100)
{
    System.Console.WriteLine("Fora de intervalo");
}
else if ( x<=25)
{
    System.Console.WriteLine("Intervalo [0,25]");
}
else if (x <= 50)
{
    System.Console.WriteLine("Intervalo (25,50]");
}
else if (x <= 75)
{
    System.Console.WriteLine("Intervalo (50,75]");
}
else 
{
    System.Console.WriteLine("Intervalo (75,100]");
}
