Console.WriteLine("## Inferência Tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");//o "c" apresenta a moeda localizada

//var limittações
//var salario = null; -> cannot assign <null> to an implicitly-type variable
//var titulo; -> implicitly-type variables must be initialized
//var num1, total, imposto; -> implicitly-type variavles cannot have multiple declarators

//não posso mudar o tipo após inicializar
var num = 10;
num = num + 20;
//num = "teste"; -> cannot implicitly convert type 'string' to 'int'

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método!");
    }
}