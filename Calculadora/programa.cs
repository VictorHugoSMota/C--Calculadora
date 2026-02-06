using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha qual operação usar:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");

        int decisao;

        while (!int.TryParse(Console.ReadLine(), out decisao) || decisao < 1 || decisao > 4)
        {
            Console.WriteLine("Opção inválida! Escolha de 1 a 4:");
        }

        float num1 = LerNumero("Digite o 1º número:");
        float num2 = LerNumero("Digite o 2º número:");

        float resultado = 0;

        switch (decisao)
        {
            case 1:
                resultado = Adicao(num1, num2);
                break;

            case 2:
                resultado = Subtracao(num1, num2);
                break;

            case 3:
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: divisão por zero.");
                    return;
                }
                resultado = Divisao(num1, num2);
                break;

            case 4:
                resultado = Multiplicacao(num1, num2);
                break;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }

    static float LerNumero(string mensagem)
    {
        float numero;

        Console.WriteLine(mensagem);

        while (!float.TryParse(
            Console.ReadLine().Replace(",", "."),
            NumberStyles.Any,
            CultureInfo.InvariantCulture,
            out numero))
        {
            Console.WriteLine("Número inválido. Tente novamente:");
        }

        return numero;
    }

    static float Adicao(float a, float b)
    {
        return a + b;
    }

    static float Subtracao(float a, float b)
    {
        return a - b;
    }

    static float Divisao(float a, float b)
    {
        return a / b;
    }

    static float Multiplicacao(float a, float b)
    {
        return a * b;
    }
}
