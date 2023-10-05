Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

/*strings são imutaveis, ou seja, ela aloca uma parte da memoria
  toda vez que atribuir um valor a variavel.
    Segue o exemplo em baixo:
*/
string valor = "isto é uma string";
valor = "isto é uma string alterada";
valor = "teste";

//StringBuilder

dynamic nota = 10;
dynamic valor1 = 9.55m;
dynamic nome1 = "Maria";
dynamic ativa = true;
dynamic letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();