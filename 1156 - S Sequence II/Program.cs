double S = 0;
double j = 1;
for (int i = 1; i <= 39; i +=2)
{
    S += i/j;
    j = j*2;
   
}
System.Console.WriteLine(S.ToString("F2"));