int a, b, c, maiorAB, maior;
string [] vet = Console.ReadLine().Split();
a = int.Parse(vet [0]);
b = int.Parse(vet [1]);
c = int.Parse(vet [2]);
maiorAB = (a + b + Math.Abs(a - b))/2;
maior = (maiorAB + c + Math.Abs(maiorAB - c))/2;
System.Console.WriteLine(maior + " eh o maior");

