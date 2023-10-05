Console.WriteLine("Saida de dados : usando sequência de escapes\n");
//sequencia de escapes é os '\n', '\\', '\t',etc
string local = "c:\\dados\\poesias.txt";
string frase = "ele falou:\"não fui eu\"";
Console.WriteLine($"{local}\n{frase}");

string pizza = "\nPizza\nde\nMussarela";
string bolo = "\nBolo\tde\tChocolate";

Console.WriteLine(pizza);
Console.WriteLine(bolo);

Console.ReadLine();