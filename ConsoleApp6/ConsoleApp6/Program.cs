using System;
using System.Globalization;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo r = new Retangulo();

            Console.Write("Informe a base do " +
                "retângulo: ");
            r.Base = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do " +
                "retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());

            double areaR = r.CalculaAreaRetangulo(r.Base, r.Altura);

            Console.WriteLine();

            Console.WriteLine("Área do retângulo: " +
                areaR.ToString("F2", CI));
        }
    }
}
