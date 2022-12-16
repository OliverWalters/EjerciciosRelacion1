namespace Ejercicio_22
{
    class Program
    {
        enum Light { ON, OFF }
        static void Main()
        {
            Console.WriteLine("La luz esta apagada");
            Light modo = Light.OFF;
            while (true)
            {
                string toDo = Console.ReadLine();
                Light done = (Light)Enum.Parse(typeof(Light), toDo, true);
                int state = (int)done;

                if (done == Light.ON && modo == Light.OFF)
                {
                    Console.WriteLine("Se ha encendido. \nLa luz ahora está encendida.");
                    modo = Light.ON;

                }else if (done == Light.OFF && modo == Light.ON)
                {
                    Console.WriteLine("Se ha apagado. \nLa luz ahora está apagada.");
                    modo = Light.OFF;
                }
                else
                {
                    throw new Exception("La luz ya estaba en ese modo");
                }
            }
        }
    }
}