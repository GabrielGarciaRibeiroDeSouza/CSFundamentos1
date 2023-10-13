Console.WriteLine("## Operador uniário e ternário ##\n");

int positivo = 1;
int resultado1;

resultado1 = +positivo;
Console.WriteLine(resultado1);

Console.WriteLine("\n---------------------\n");

Console.WriteLine("Informe o número: ");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("\n---------------------\n");

Console.WriteLine("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado2 = temp > 27 ? "Quente" : "normal";
Console.WriteLine($"O tempo está {resultado2}");

Console.WriteLine("\n---------------------\n");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string resultado3 = x > y ? "x é maior que y" :
                    x < y ? "x é menor que y" :
                    x == y ? "x é igual a y" : "Sem resultado";
Console.WriteLine(resultado3);

Console.ReadKey();