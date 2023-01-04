double A, B, weight1, weight2, average;
weight1 = 3.5;
weight2 = 7.5;
A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());
average = ((A * weight1) + (B * weight2))/(weight1 + weight2);
System.Console.WriteLine("MEDIA = "+average.ToString("F5"));