using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1, b2, altura, resultado;
            Console.WriteLine("Digite a base maior");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base menor");
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("A area do trapézio é: ");
            resultado = ((b1 + b2) * altura / 2);
            Console.WriteLine(resultado);
        }
    }
}
