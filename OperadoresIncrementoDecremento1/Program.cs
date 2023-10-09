Console.WriteLine("## Operadores Incremento e Decremento ##\n");

//pós-incremento -> primeiro resolve depois incrementa
Console.WriteLine("---Pós incremento--------\n");
int x1 = 0;
Console.WriteLine($"x1 = {x1}");
int resultado1 = x1++ + 10;

Console.WriteLine($"pós-incremento -> {resultado1}");
Console.WriteLine($"valor de x1 -> {x1}");

//pré-incremento -> primeiro incrementa depois resolve  
Console.WriteLine("\n------Pré incremento--------\n");
int y1 = 0;
Console.WriteLine($"y1 = {y1}");
int resultado2 = ++y1 + 10;

Console.WriteLine($"pré-incremento -> {resultado2}");
Console.WriteLine($"valor de y1 -> {y1}");

//

//pós-decremento -> primeiro resolve depois decrementa
Console.WriteLine("\n---Pós decremento--------\n");
int x2 = 0;
Console.WriteLine($"x2 = {x2}");
int resultado3 = x2-- + 10;

Console.WriteLine($"pós-decremento -> {resultado3}");
Console.WriteLine($"valor de x2 -> {x2}");

//pré-decremento -> primeiro decrementa depois resolve  
Console.WriteLine("\n------Pré decremento--------\n");
int y2 = 0;
Console.WriteLine($"y2 = {y2}");
int resultado4 = --y2 + 10;

Console.WriteLine($"pré-decremento -> {resultado4}");
Console.WriteLine($"valor de y2 -> {y2}");