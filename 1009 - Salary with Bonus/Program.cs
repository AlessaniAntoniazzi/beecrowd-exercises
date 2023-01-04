string name;
double salary, value, finalSalary; 
name = Console.ReadLine();
salary = double.Parse(Console.ReadLine());
value = double.Parse(Console.ReadLine());
finalSalary = (value * 15)/100+ salary;
System.Console.WriteLine("TOTAL = R$ "+ finalSalary.ToString("F2"));
