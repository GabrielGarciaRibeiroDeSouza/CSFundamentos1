Console.WriteLine("\n ## Entrada de dados ##");

Console.WriteLine("\nInforme seu nome:");

string nome = Console.ReadLine();

Console.WriteLine("\nInforme a sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nO seu nome é " + nome);//concatenação
Console.WriteLine($"\nA sua idade é {idade} anos");//interpolação

Console.ReadKey();