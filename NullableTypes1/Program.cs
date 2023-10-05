Console.WriteLine("## Nullable Types ##");

Console.WriteLine("Declaração de null \nnão vai aparecer nada pq é null");
//existe esses 2 tipos de declração de null
Nullable<int> i = null;
double? d = null;
bool? b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

//opreador de coalescêcia nula

Console.WriteLine("operador de coalescêcia nula");
int? a = null;
int b1 = a ?? 0;
/* O '??' verifica se a variável 'a' é null, se for, ele atribui o valor digitado depois
  dos '??'; caso contrário ele atribui o valor da variável 'a'
*/
Console.WriteLine(b1);

//HasValue
Console.WriteLine("\nVerifica se tem um valor na variavel(y)");
int? y = null;

if (y.HasValue)//se tiver valor mostra ele
{
    Console.WriteLine($"y = {y.Value}");
}
else//se não mostra essa mensagem
{
    Console.WriteLine("(null) y não possui um valor");
}

Console.ReadLine();