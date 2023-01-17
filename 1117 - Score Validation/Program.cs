double average;
double x = double.Parse(Console.ReadLine());

while (true)
{
    if (x > 10.0 || x < 0.0)
    {
        System.Console.WriteLine("nota invalida");
        x = double.Parse(Console.ReadLine());
          
    }
    else if (x < 10.0 && x > 0.0)
    {
        double y = double.Parse(Console.ReadLine());
        if (y < 0.0 || y > 10.0)
        {
            System.Console.WriteLine("nota invalida");
        }
        else if (y > 0.0 || y < 10.0)
        {
            average = (x + y)/2;
            System.Console.WriteLine("media = "+average);
            break;
        }
    }
}