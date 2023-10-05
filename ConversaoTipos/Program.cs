Console.WriteLine("## Conversão de tipos ##\n");

int varInt = 100;
double varDouble = varInt;

//conversão implicita : menos byte para mais byte
//byte -> 1 byte
//short -> 2 bytes
//int -> 4 bytes
//long -> 8 bytes
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

Console.WriteLine(varDouble);

int numeroInt = 21436578;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

//conversão explicita
double varDouble1 = 12.354;     //8 butes
int varInt1 = (int)varDouble1;  //4 bytes(perda de precisão)

Console.WriteLine($"Conversão explicita\n {varInt1}");

int num1 = 10;
int num2 = 4;

//se não usar '(float)' não faz a conversão, resultado = 2
float resultado = (float)num1 / num2; // 10/4 = 2.5
Console.WriteLine(resultado);

Console.WriteLine("conversão de tipos continuação:");
int valorInt = 123;
double valorDouble = 12.12;
decimal valorDecimal = 12.12344m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

//s1 = s2/s3; 

Console.WriteLine($"{s1}\n{s2}\n{s3}\n");

valorInt = 10;
valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble));

varInt = 100000;
Console.WriteLine(Convert.ToByte(varInt));//erro overflow excption apenas na execução
Console.ReadLine();