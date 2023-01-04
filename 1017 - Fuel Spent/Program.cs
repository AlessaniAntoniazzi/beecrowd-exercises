double time, speed, liters;
time = double.Parse(Console.ReadLine());
speed = int.Parse(Console.ReadLine());
liters = (speed/12) * time;
System.Console.WriteLine(liters.ToString("F3"));