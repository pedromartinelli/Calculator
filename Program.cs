namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("-------------------");
        Console.Write("Selecione uma opção: ");

        short res = short.Parse(Console.ReadLine()!);

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: Exit(); break;
            default: Menu(); break;
        }
    }

    static void Exit()
    {
        Console.Clear();
        Console.WriteLine("Obrigado por utilizar nossa aplicação! Aperte qualquer tecla para sair.");
        Console.ReadKey();

        System.Environment.Exit(0);
    }

    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Quantos números você deseja somar?");
        short n = short.Parse(Console.ReadLine()!);

        float resultado = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            float valor = float.Parse(Console.ReadLine()!);
            resultado += valor;
        }

        Console.WriteLine("");

        Console.WriteLine($"O resultado da soma é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine()!);

        Console.Write("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine()!);

        Console.WriteLine("");

        var resultado = v1 - v2;
        Console.WriteLine($"O resultado da subtração é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        var v1 = float.Parse(Console.ReadLine()!);

        Console.Write("Segundo valor: ");
        var v2 = float.Parse(Console.ReadLine()!);

        Console.WriteLine("");

        var resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        var v1 = float.Parse(Console.ReadLine()!);

        Console.Write("Segundo valor: ");
        var v2 = float.Parse(Console.ReadLine()!);

        Console.WriteLine("");

        var resultado = v1 / v2;
        Console.WriteLine($"O resultado da divisão é: {resultado}");
        Console.ReadKey();
        Menu();
    }
}
