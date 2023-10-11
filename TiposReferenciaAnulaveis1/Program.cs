Console.WriteLine("## Tipos de referêcia anulável\n");

string? nome = null;
 // O '?.' verifica se a variavel nome é null, se não for null ele executa o metodo 'ToUpper()'
Console.WriteLine(nome?.ToUpper());

Console.ReadKey();