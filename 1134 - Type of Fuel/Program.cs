int countAlcool = 0;
int countGasolina = 0;
int countDiesel = 0;
while (true)
{
    int x = int.Parse(Console.ReadLine());
    if (x ==1)
    {
        countAlcool ++;
    }
    else if ( x == 2)
    {
        countGasolina ++;
    }
    else if ( x == 3)
    {
        countDiesel ++;
    }
    else if (x == 4)
    {
        System.Console.WriteLine("MUITO OBRIGADO");
        System.Console.WriteLine("Alcool: "+countAlcool);
        System.Console.WriteLine("Gasolina: "+countGasolina);
        System.Console.WriteLine("Diesel: "+countDiesel);
        break;
    }
    else
    {
        continue;
    }
}