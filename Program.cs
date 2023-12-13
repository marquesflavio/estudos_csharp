using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
            Subtracao();
            Divisao();
            Multiplicacao();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float soma = valor1 + valor2;
            Console.WriteLine($"A soma de {valor1} com o {valor2} é = {soma}");
            Console.ReadKey();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float subtracao = valor1 - valor2;
            Console.WriteLine($"A diferença de {valor1} com o {valor2} é = {subtracao}");
            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            if (valor2 == null || valor2 == 0)
            {
                Console.WriteLine("Impossível dividir por zero");

            }
            float divisao = valor1 / valor2;
            Console.WriteLine($"A divisao de {valor1} com o {valor2} é = {divisao}");
            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float multiplicacao = valor1 * valor2;
            Console.WriteLine($"A multiplicacao de {valor1} com o {valor2} é = {multiplicacao}");
            Console.ReadKey();
        }
    }
}


