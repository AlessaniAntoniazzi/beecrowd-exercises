int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    double x = double.Parse(input[0]);
    double y = double.Parse(input[1]);
    double z = double.Parse(input[2]);
    double total = (x * 2) + (y * 3) + (z * 5);
    double weightTotal = 2 + 3 + 5;
    double average = total / weightTotal;
Console.WriteLine(average.ToString("F1"));
}