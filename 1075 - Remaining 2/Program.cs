﻿int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10000; i++)
{
    if(i%n==2)
    {
        System.Console.WriteLine(i);
    }
}