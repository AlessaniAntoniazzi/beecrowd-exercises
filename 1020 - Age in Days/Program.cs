int dia, mes, ano, n, resto;
n = int.Parse(Console.ReadLine());
ano = n/365;
resto = n%365;
mes = resto/30;
dia = resto%30;
System.Console.WriteLine(ano+" ano(s)");
System.Console.WriteLine(mes+" mes(es)");
System.Console.WriteLine(dia+" dia(s)");