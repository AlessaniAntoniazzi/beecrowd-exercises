int coelhoCount =0;
int ratoCount =0;
int sapoCount =0;
int total= 0;
double percentualCoelho, percentualRato, percentualSapo; 
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string [] species = Console.ReadLine().Split(' ');
    int a = int.Parse(species[0]);
    string b = species[1];

    total += a;
    if (b == "C")
    {
        coelhoCount += a;
    }
    else if (b=="R")
    {
        ratoCount += a;
    }
    else
    {
        sapoCount += a;
    }
}
System.Console.WriteLine("Total: "+total+" cobaias");
System.Console.WriteLine("Total de coelhos: "+coelhoCount);
System.Console.WriteLine("Total de ratos: "+ratoCount);
System.Console.WriteLine("Total de sapos: "+sapoCount);

percentualCoelho = (coelhoCount*100)/(double)(total);
System.Console.WriteLine("Percentual de coelhos: "+percentualCoelho.ToString("F2")+" %");

percentualRato = (ratoCount*100)/(double)(total);
System.Console.WriteLine("Percentual de ratos: "+percentualRato.ToString("F2")+" %");

percentualSapo = (sapoCount*100)/(double)(total);
System.Console.WriteLine("Percentual de sapos: "+percentualSapo.ToString("F2")+" %");

