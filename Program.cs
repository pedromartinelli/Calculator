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

        Console.WriteLine("-------------------");
        Console.Write("Selecione uma opção: ");

        short res = short.Parse(Console.ReadLine()!);

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            default: Menu(); break;
        }
    }

    static void Soma()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine()!);

        Console.Write("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine()!);

        Console.WriteLine("");

        var resultado = v1 + v2;
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
