namespace ConsoleApp6
{
    class Retangulo
    {
        public double Base;
        public double Altura;

        public Retangulo()
        {
        }

        public double CalculaAreaRetangulo(double b, double a)
        {
            b = Base;
            a = Altura;
            return Base * Altura;
        }
    }
}
