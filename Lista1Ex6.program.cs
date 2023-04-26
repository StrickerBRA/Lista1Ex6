using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Realizando média geométrica:");
            Console.Write("Digite o primeiro valor:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor:");
            b = double.Parse(Console.ReadLine());

            c = Math.Sqrt(a*b);
            Console.WriteLine($"A Média Aritmética (dos valores {a} e {b}) é {c}.");

        }
    }
}
