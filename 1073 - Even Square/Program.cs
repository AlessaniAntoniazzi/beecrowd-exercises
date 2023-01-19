int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if ( i%2 == 0)
    { 
        System.Console.WriteLine(i+"^2 = "+Math.Pow(i,2));   
    }
}