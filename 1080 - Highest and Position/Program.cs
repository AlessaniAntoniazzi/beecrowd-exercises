using System.Linq;

int[] numbers = new int[1000];
for (int i = 0; i < 100; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
int max = numbers.Max();
int maxIndex = Array.IndexOf(numbers, max);
Console.WriteLine(max);
System.Console.WriteLine(maxIndex + 1);

