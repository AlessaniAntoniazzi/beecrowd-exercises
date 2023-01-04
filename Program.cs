int number, hours;
number = Convert.ToInt32(Console.ReadLine());
hours = Convert.ToInt32(Console.ReadLine());
float payment, salary;
payment = Convert.ToSingle(Console.ReadLine());
salary = hours * payment;
System.Console.WriteLine($"NUMBER = " + number);
System.Console.WriteLine($"SALARY = U$ "+ salary.ToString("F2"));
