namespace Ejercicio_24
{
    class Program
    {
        enum Mode { Inactivo, Reproduciendo, Pausado, Parado, Cerrado }
        static void Main()
        {
            Mode mode = Mode.Inactivo;
            char input;

            Console.WriteLine($"Estado actual: {mode}");

            while (mode != Mode.Cerrado)
            {
                try
                {
                    input = Console.ReadLine()[0];

                    switch (input)
                    {
                        case 'p':
                            if (mode == Mode.Inactivo || mode == Mode.Pausado) mode = Mode.Reproduciendo;
                            else if (mode == Mode.Reproduciendo) mode = Mode.Pausado;
                            else throw new Exception("Acción no disponible");
                            break;
                        case 's':
                            if (mode == Mode.Reproduciendo || mode == Mode.Pausado) mode = Mode.Parado;
                            else throw new Exception("Acción no disponible");
                            break;
                        case 'q':
                            mode = Mode.Cerrado;
                            break;
                        default:
                            throw new Exception("Acción no disponible");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}