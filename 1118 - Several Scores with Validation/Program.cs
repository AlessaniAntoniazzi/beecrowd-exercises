double average;
bool isProgramRunning = true;


while (isProgramRunning)
{
    bool xIsInvalid = true;
    double x = -1;   
    while (xIsInvalid)    
    {
        x = double.Parse(Console.ReadLine());        
        if (x > 10.0 || x < 0.0)
        {
            System.Console.WriteLine("nota invalida");
                     
        }
        else if (x <= 10.0 && x > 0.0)
        {
            break;
        }
    }
    bool yIsInvalid = true;
    double y = -1;
    while (yIsInvalid)    
    {
        y = double.Parse(Console.ReadLine());        
        if (y < 0.0 || y > 10.0)
        {                
            System.Console.WriteLine("nota invalida");        
        }
        else if (y > 0.0 && y <= 10.0)
        {
            break;
        }                 
    }
    average = (x + y)/2;
    System.Console.WriteLine("media = "+average.ToString("F2"));
    while (true)
    {
        System.Console.WriteLine("novo calculo (1-sim 2-nao)");
        double z = double.Parse(Console.ReadLine());
        if (z == 2 )
        {
            isProgramRunning = false;
            break;
        }
        else if (z == 1)
        {
            break;
        }
        else
        {
            continue;
        }
    }                     
     
}