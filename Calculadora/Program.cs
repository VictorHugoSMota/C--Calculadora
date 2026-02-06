inicio:
 Console.WriteLine("Escolha qual Operação Usar:");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Substituição");
Console.WriteLine("3 - Divisão");
Console.WriteLine("4 - Multiplicação");

var Decisao = Console.ReadLine();
int Decisao = 0;

try
{
    Decisao INT = Convert.ToInt16(Decisao);
}
catch
{
    Console.WhiteLine("Valor Invalido!");
    goto inicio;
}

// 1° Numero --

Console.WhiteLine("Digite o 1° Numero: ");
var Num1 = ConsoleColor.ReadLine();

float NumeroConvertido;

try
{
    var NumeroConvertido = float.Parse(Num1).Replace(",",",",".");
}
catch
{
    Console.Clear();
    goto inicio;
}

// 2° Numero --

Console.WhiteLine("Digite o 2° Numero: ");
var Num2 = ConsoleColor.ReadLine();

float NumeroConvertido;

try
{
    var NumeroConvertido = float.Parse(Num1).Replace(",",",",".");
}
catch
{
    Console.Clear();
    goto inicio;
}

//

