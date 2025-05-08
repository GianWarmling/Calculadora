using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma, Subtração, Divisão, Multiplicação, Potência, Raiz, Sair }

        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem Vindo a Calculadora, selecione uma das opções:");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

            Console.ReadLine();
        }
    }
}
