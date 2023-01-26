int sum = 0;
int max = 0;
int min = 0;
string [] numbers = Console.ReadLine().Split(' ');;
int M = int.Parse(numbers[0]);
int N = int.Parse(numbers[1]);
while(M > 0 && N > 0)
{
    if (M < N)
    {
        min = M;
        max = N;
    }
    else
    {
        min = N;
        max = M;
    }
    for (int i = min; i <= max; i++ )
    {
  
        sum += i;
        System.Console.Write(i + " ");    
    }
    System.Console.WriteLine("Sum="+sum);
    sum = 0;
    numbers = Console.ReadLine().Split(' ');
    M = int.Parse(numbers[0]);
    N = int.Parse(numbers[1]);
  
}