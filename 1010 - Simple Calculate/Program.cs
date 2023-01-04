double code, unit, price, total;
string [] vet = Console.ReadLine().Split(' ');
code = double.Parse(vet[0]);
unit = double.Parse(vet[1]);
price = double.Parse(vet[2]);
double code2, unit2, price2;
string [] vet2 = Console.ReadLine().Split(' ');
code2 = double.Parse(vet2[0]);
unit2 = double.Parse(vet2[1]);
price2 = double.Parse(vet2[2]);
total = (unit * price) + (unit2 * price2);
System.Console.WriteLine("VALOR A PAGAR: R$ "+ total.ToString("F2"));

