using System;
using System.Globalization;

namespace ConsoleApp7
{
    class Program
    {
        #region Variáveis Globais
        public static int qtdEleitores = 0;
        public static int qtdVotosBrancos = 0;
        public static int qtdVotosNulos = 0;
        public static int qtdVotosValidados = 0;

        public static double porcentualVotosBrancos = 0.0;
        public static double porcentualVotosNulos = 0.0;
        public static double porcentuaVotosValidos = 0.0;

        public static CultureInfo CI = CultureInfo.InvariantCulture;
        #endregion

        static void Main(string[] args)
        {

            RecebeQtdEleitores();
            RecebeQtdVotosBrancos();
            RecebeQtdVotosNulos();
            RecebeQtdVotosValidados();

            porcentualVotosBrancos = (double) qtdVotosBrancos / qtdEleitores * 100;
            porcentualVotosNulos = (double) qtdVotosNulos / qtdEleitores * 100;
            porcentuaVotosValidos = (double) qtdVotosValidados / qtdEleitores * 100;

            QuebraLinha();

            MostraPorcentualVotosBrancos();
            MostraPorcentualVotosNulos();
            MostraPorcentualVotosValidos();

        }

        #region Funções
        public static void RecebeQtdEleitores()
        {
            Console.Write("Informe a quantidade total " +
                "de eleitores: ");
            qtdEleitores = int.Parse(Console.ReadLine());
        }

        public static void RecebeQtdVotosBrancos()
        {
            Console.Write("Informe a quantidade de " +
                "votos brancos: ");
            qtdVotosBrancos = int.Parse(Console.ReadLine());
        }

        public static void RecebeQtdVotosNulos()
        {
            Console.Write("Informe a quantidade de " +
                "votos nulos: ");
            qtdVotosNulos = int.Parse(Console.ReadLine());
        }

        public static void RecebeQtdVotosValidados()
        {
            Console.Write("Informe a qunatidade de " +
                "votos validados: ");
            qtdVotosValidados = int.Parse(Console.ReadLine());
        }

        public static void MostraPorcentualVotosBrancos()
        {
            Console.WriteLine("Porcentual de votos brancos: " +
                porcentualVotosBrancos.ToString("F2", CI) + "%");
        }

        public static void MostraPorcentualVotosNulos()
        {
            Console.WriteLine("Porcentual de votos nulos: " +
                porcentualVotosNulos.ToString("F2", CI) + "%");
        }

        public static void MostraPorcentualVotosValidos()
        {
            Console.WriteLine("Porcentual de votos válidos: " +
                porcentuaVotosValidos.ToString("F2", CI) + "%");
        }

        public static void QuebraLinha()
        {
            Console.WriteLine();
        }
        #endregion
    }
}
