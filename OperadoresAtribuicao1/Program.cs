﻿Console.WriteLine("## Operadores de atribuição ##\n");

//usando operadores atribuição com tipos numéricos
float x = 10;
x = 20;
Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x += 5 --> {x += 5}");
Console.WriteLine($"x -= 5 --> {x -= 5}");
Console.WriteLine($"x *= 5 --> {x *= 5}");
Console.WriteLine($"x /= 5 --> {x /= 5}");
Console.WriteLine($"x %= 5 --> {x %= 5}");

Console.WriteLine("\n---------------------\n");

string y = "123s";
Console.WriteLine($"Valor inicial de y = {y}");
y += "456";
Console.WriteLine($"y += \"456\" --> {y}");

Console.ReadKey();