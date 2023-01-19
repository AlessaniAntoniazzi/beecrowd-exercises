
int y = 1;
int z;

int x = int.Parse(Console.ReadLine());
for (int i = 0; i < 10; i++) 
{
    z = y * x;
    System.Console.WriteLine(y+" x "+ x +" = "+z);
    y ++;  
}

