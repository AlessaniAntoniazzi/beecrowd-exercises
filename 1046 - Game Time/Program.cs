int x, y, z;
string [] var = Console.ReadLine().Split(' ');
x = int.Parse(var[0]);
y = int.Parse(var[1]);
if (x > y)
{
    z = ((x - 24) * -1) + y; 
   System.Console.WriteLine("O JOGO DUROU " + z + " HORA(S)");
}
else if ( x == y)
{
    z = 24;
    System.Console.WriteLine("O JOGO DUROU " + z + " HORA(S)");
}
else
{
    z = y - x; 
    System.Console.WriteLine("O JOGO DUROU " + z + " HORA(S)");
}