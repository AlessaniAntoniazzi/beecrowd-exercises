int positive = 0;
int even = 0;
int negative = 0;
int odd = 0;

for (int i = 0; i < 5; i++)
{
    int number = int.Parse(Console.ReadLine());

    if(number > 0)
    {
        positive++;
    }
    if(number < 0)
    {
        negative++;
    } 
    if(number %2 == 0)
    {
        even++;
    } 
    if(number %2 != 0)
    {
        odd++;
    }

    
}
System.Console.WriteLine(even + " valor(es) par(es)");
System.Console.WriteLine(odd + " valor(es) impar(es)");
System.Console.WriteLine(positive + " valor(es) positivo(s)");
System.Console.WriteLine(negative + " valor(es) negativo(s)");

