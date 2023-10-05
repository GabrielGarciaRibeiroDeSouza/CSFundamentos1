Console.WriteLine("Saída de dados : Formatação\n");

int idade = 25;
string nome = "Darius";
Console.Write(nome);
Console.Write(idade);
Console.WriteLine("\n_________________________\n");

//Escreve na mesma linha 'Darius tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos");

Console.WriteLine("\n____Concatenação__________________\n");
//usar a concatenação : usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");

Console.WriteLine("\n____Interpolação__________________\n");
//usa a interpolação de strings : $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");

Console.WriteLine("\n____Place Holders__________________\n");
//usar place holders : usa {} com numeração com inicio em zero
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();