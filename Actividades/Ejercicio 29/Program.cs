using System.Globalization;

namespace Ejercicio_29
{
    class Program
    {
        const double EURO_A_YEN = 129.852;
        const double EURO_A_LIBRA = 0.86;
        const double EURO_A_DOLAR = 1.28611;



        static bool wellWriten = true;
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            double euros = Euros();
            string moneda = Moneda();
            Operacion(euros, moneda);
        }

        static void Operacion(double euros, string moneda)
        {
            switch (moneda)
            {
                case "libras":
                    Console.WriteLine(euros* EURO_A_LIBRA);
                    wellWriten = false;
                    break;
                case "yenes":
                    Console.WriteLine(euros * EURO_A_YEN);
                    wellWriten = false;
                    break;
                case "dolares":
                    Console.WriteLine(euros * EURO_A_DOLAR);
                    wellWriten = false;
                    break;
                default:
                    Console.WriteLine("Esta opción no existe");
                    break;
            }
        }

        static int Euros()
        {
            Console.WriteLine("Introduce la cantidad de euros que quiera pasar:");
            int euros = int.Parse(Console.ReadLine());
            return euros;
        }
        static string Moneda()
        {
            Console.WriteLine("Introduce la cantidad de euros que quiera pasar:");
            string moneda = Console.ReadLine();
            return moneda;
        }
    }
}