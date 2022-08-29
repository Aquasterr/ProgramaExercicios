using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            double lado1, lado2, vezes;
            Console.WriteLine("Coloque o Primeiro Lado");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque o Segundo Lado");
            lado2 = double.Parse(Console.ReadLine());
            vezes = lado1 * lado2;
            Console.WriteLine("A Area do quadrado é de: ");
            Console.WriteLine(vezes);
        }
    }
}
