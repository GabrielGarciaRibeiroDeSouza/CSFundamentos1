Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

double n1 = 1.234;
float n2 = 1.234f;

decimal n3;
n3 = 1.234m;

Console.WriteLine(n1 + " double");
Console.WriteLine(n2 + " float");
Console.WriteLine(n3 + " decimal");

Console.ReadLine();

Console.WriteLine("comparando a precisão do float, double e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine(x + " float");
Console.WriteLine(y + " double");
Console.WriteLine(z + " decimal");

Console.ReadLine();