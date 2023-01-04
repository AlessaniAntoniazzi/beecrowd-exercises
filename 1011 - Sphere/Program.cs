double pi, R, volume;
pi = 3.14159;
R = double.Parse(Console.ReadLine());
volume = (4/3.0) * pi * Math.Pow(R,3);
System.Console.WriteLine("VOLUME = "+ volume.ToString("F3"));
