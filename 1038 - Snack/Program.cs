double price, cachorroQuente, xSalada, xBacon, torrada, refri;
cachorroQuente = 4.00;
xSalada = 4.50;
xBacon = 5.00;
torrada = 2.00;
refri = 1.50;
string [] var = Console.ReadLine().Split(' ');
int x = int.Parse(var[0]);
int y = int.Parse(var[1]);
if (x==1)
{
    price = y * cachorroQuente;
    System.Console.WriteLine("Total: R$ "+price.ToString("F2"));
}
else if (x==2)
{
    price = y * xSalada;
    System.Console.WriteLine("Total: R$ "+price.ToString("F2"));
}
else if (x==3)
{
    price = y * xBacon;
    System.Console.WriteLine("Total: R$ "+price.ToString("F2"));
}
else if (x==4)
{
    price = y * torrada;
    System.Console.WriteLine("Total: R$ "+price.ToString("F2"));
}
else
{
    price = y * refri;
    System.Console.WriteLine("Total: R$ "+price.ToString("F2"));
}