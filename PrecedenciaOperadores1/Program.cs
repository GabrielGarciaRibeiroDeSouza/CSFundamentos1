Console.WriteLine("## Precedência de operadores ##\n");

int x  = 10 - 2 * 3;
Console.WriteLine($"x  = 10 - 2 * 3 -> {x}");
x = (10 - 2) * 3;
Console.WriteLine($"x  = (10 - 2) * 3 -> {x}");

Console.WriteLine("\n--------------------\n");

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine($"\nbool b = !(9 != 8) && 5 >= 7 || 8 >= 6;\n{b}");

b = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine($"\nb = !(9 != 8) && (5 >= 7 || 8 >= 6);\n{b}");

Console.WriteLine("\n--------------------\n");

int a1 = 5, b1 = 6, c1 = 4;
int r = --a1 * b1 - ++c1;
Console.WriteLine("int a1 = 5, b1 = 6, c1 = 4;");
Console.WriteLine($"int r = --a1 * b1 - ++c1;\n{r}");

a1 = 5; b1 = 6; c1 = 3;
int resultado = a1 = b1 = c1;
Console.WriteLine("\na1 = 5; b1 = 6; c1 = 3;");//associatividade do operador = da direita para esquerda
Console.WriteLine($"int resultado = a1 = b1 = c1; \nresultado: {resultado}");
Console.ReadKey();