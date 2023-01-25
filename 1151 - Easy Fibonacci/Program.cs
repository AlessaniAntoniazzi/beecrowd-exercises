string result = "";
int n, first = 0, second = 1, next;
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    if (i <= 1)
    {
        next = i;
    }
    else
    {
        next = first + second;
        first = second;
        second = next;
    }
    result += next + " ";
}
Console.WriteLine(result.TrimEnd());
