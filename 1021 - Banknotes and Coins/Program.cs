double N = double.Parse(Console.ReadLine());
int rest = (int)((N) * 100.0 + 0.5);
Console.WriteLine("NOTAS:");
int note = 100;
int cash = rest / (note * 100);
Console.WriteLine(cash + " nota(s) de R$ 100.00");
rest = rest % (note * 100);

note = 50;
cash = rest / (note * 100);
Console.WriteLine(cash + " nota(s) de R$ 50.00");
rest = rest % (note * 100);

note = 20;
cash = rest / (note * 100);
Console.WriteLine(cash + " nota(s) de R$ 20.00");
rest = rest % (note * 100);

note = 10;
cash = rest / (note * 100);
Console.WriteLine(cash + " nota(s) de R$ 10.00");
rest = rest % (note * 100);

note = 5;
cash = rest / (note * 100);
Console.WriteLine(cash + " nota(s) de R$ 5.00");
rest = rest % (note * 100);

note = 2;
cash = rest / (note * 100);
Console.WriteLine(cash + " nota(s) de R$ 2.00");
rest = rest % (note * 100);
Console.WriteLine("MOEDAS:");

int coin = 100;
cash = rest / coin;
Console.WriteLine(cash + " moeda(s) de R$ 1.00");
rest = rest % coin;

coin = 50;
cash = rest / coin;
Console.WriteLine(cash + " moeda(s) de R$ 0.50");
rest = rest % coin;

coin = 25;
cash = rest / coin;
Console.WriteLine(cash + " moeda(s) de R$ 0.25");
rest = rest % coin;

coin = 10;
cash = rest / coin;
Console.WriteLine(cash + " moeda(s) de R$ 0.10");
rest = rest % coin;

coin = 5;
cash = rest / coin;
Console.WriteLine(cash + " moeda(s) de R$ 0.05");
rest = rest % coin;
Console.WriteLine(rest + " moeda(s) de R$ 0.01");
    