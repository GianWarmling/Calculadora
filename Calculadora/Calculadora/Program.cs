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
            Console.WriteLine("Seja Bem Vindo a Calculadora, selecione uma das opções:");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            Console.WriteLine(opcao);

            Console.ReadLine();
        }
    }
}
