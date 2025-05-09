using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração = 2, Divisão = 3, Multiplicação = 4, Potência = 5, Raiz = 6, Sair = 7 }

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja Bem Vindo a Calculadora, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtração:
                        Sub();
                        break;

                    case Menu.Divisão:
                        Div();
                        break;

                    case Menu.Multiplicação:
                        Mult();
                        break;

                    case Menu.Potência:
                        Pot();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.Clear();
            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois Números:");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();

        }

        static void Sub()
        {
            Console.WriteLine("Subtração de dois Números:");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Div()
        {
            Console.WriteLine("Divisão de dois Números:");
            Console.WriteLine("Digite o primeiro número: ");
            float a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float b = int.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois Números:");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Pot()
        {
            Console.WriteLine("Potência de um Número:");
            Console.WriteLine("Digite a base: ");
            int numBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(numBase, expoente);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um Número:");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
