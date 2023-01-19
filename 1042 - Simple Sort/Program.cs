int a, b, c;
string [] var = Console.ReadLine().Split(' ');
a = int.Parse(var[0]);
b = int.Parse(var[1]);
c = int.Parse(var[2]);
if (a > b)
{
int temp = a;
a = b;
b = temp;
}
if (b > c)
{
int temp = b;
b = c;
c = temp;
}
if (a > b)
{
int temp = a;
a = b;
b = temp;
}
Console.WriteLine(a);
Console.WriteLine(b);                  
Console.WriteLine(c);
System.Console.WriteLine();
System.Console.WriteLine(var[0]);   
System.Console.WriteLine(var[1]);
System.Console.WriteLine(var[2]);       