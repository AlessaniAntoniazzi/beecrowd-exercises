double countNumbers = 0;
double sum = 0;
double average;


while (true)
{
    double x = double.Parse(Console.ReadLine());
    if (x > 0)
    {
        countNumbers ++;
        sum = sum + x;
    }
    else
    {
        average = sum/countNumbers;
        System.Console.WriteLine(average.ToString("F2"));
        break;
    }
    


}