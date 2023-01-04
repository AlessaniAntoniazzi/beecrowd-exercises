int x = 1;
int y = 0;
while (x != y)
{
    string input = Console.ReadLine();
    string[] parts = input.Split(' ');
    x = int.Parse(parts[0]);
    y = int.Parse(parts[1]);
  

    if (x < y)
    {
        Console.WriteLine("Crescente");
    }
    else if (y < x)
    {
        Console.WriteLine("Decrescente");
    }
}   
