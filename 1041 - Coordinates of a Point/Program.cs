double x, y;
string [] var = Console.ReadLine().Split(' ');
x = double.Parse(var[0]);
y = double.Parse(var[1]);
if (x > 0 && y > 0)
{
    System.Console.WriteLine("Q1");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Q2");
}
else if (x < 0 && y < 0) 
{
   System.Console.WriteLine("Q3");
}
else if (x > 0 && y < 0) 
{
   System.Console.WriteLine("Q4");
}
else if (x == 0 && y == 0)
{
    System.Console.WriteLine("Origem");
}
else if (y ==0)
{
    System.Console.WriteLine("Eixo X");
}
else if (x == 0)
{
    System.Console.WriteLine("Eixo Y");
}