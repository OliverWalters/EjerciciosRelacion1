namespace Ejercicio_20
{
     class Program
    {
        enum Meses { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre }
        static void Main()
        {
            Console.WriteLine("Introduzca el número del mes");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine((Meses)number);

            Console.ReadLine();
        }
    }
}