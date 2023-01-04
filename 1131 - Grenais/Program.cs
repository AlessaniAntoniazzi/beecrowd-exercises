int goalInter, goalGremio, grenal, victoryInter, victoryGremio, draw, answer;
grenal = 1;
victoryGremio = 0;
victoryInter = 0;
draw = 0;
while (true)
{
    string[] var = Console.ReadLine().Split(' ');
    goalInter = int.Parse(var[0]);
    goalGremio = int.Parse(var[1]);
           
    if (goalInter > goalGremio)
    {
        victoryInter ++;
    }
    else if ( goalGremio > goalInter)
    {
        victoryGremio ++;
    }
    else if (goalInter == goalGremio)
    {
        draw ++;
    }
    System.Console.WriteLine("Novo grenal (1-sim 2-nao)");
    answer = int.Parse(Console.ReadLine());
    if (answer == 1)
    {
        grenal ++;       
    }
    else if (answer ==2)
    {
        System.Console.WriteLine(grenal+" grenais");
        System.Console.WriteLine("Inter:"+victoryInter);
        System.Console.WriteLine("Gremio:"+victoryGremio);
        System.Console.WriteLine("Empates:"+draw);
        if (victoryGremio > victoryInter)
        {
            System.Console.WriteLine("Gremio venceu mais");
        }
        else if (victoryInter > victoryGremio)
        {
            System.Console.WriteLine("Inter venceu mais");
        }
        else if (victoryGremio == victoryInter)
        {
            System.Console.WriteLine("Nao houve vencedor");
        }
        break;

    }
        
}