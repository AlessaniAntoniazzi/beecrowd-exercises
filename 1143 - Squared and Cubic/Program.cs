int N = int.Parse(Console.ReadLine());
int a = 1;
int b = 1;
int c = 1;

for (int i = 0; i < N; i++)
{
    System.Console.WriteLine(a+" "+b+" "+c);
    a ++;
    b = a*a;
    c = a*a*a;
    
}