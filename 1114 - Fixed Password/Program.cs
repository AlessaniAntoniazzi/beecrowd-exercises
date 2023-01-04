int password = 0;
while (password != 2002)
{
    password = int.Parse(Console.ReadLine()); 
    if (password != 2002)
    {
        System.Console.WriteLine("Senha Invalida");
    }
    else if (password == 2002)
    {
        Console.WriteLine("Acesso Permitido");
    }
}
Console.ReadKey();