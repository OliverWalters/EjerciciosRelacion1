namespace Ejercicio_21
{
    class Program
    {
        enum DayOfWeek { None = -1, Lunes = 1, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo }
        static void Main()
        {
            Console.WriteLine("Introduzca un día de la semana");
            DayOfWeek dayOfWeek = DayOfWeek.None;
            do
            {
                try
                {
                    string entry = Console.ReadLine();
                    dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), entry, true); //true olvida si es mayuscula o no
                }
                catch
                {
                    Console.WriteLine("Esta variable no existe, introduzca otro día de la semana");
                }
            }
            while (dayOfWeek == DayOfWeek.None);

            switch (dayOfWeek)
            {
                case DayOfWeek.Sabado:
                case DayOfWeek.Domingo:
                    Console.WriteLine("No laboral");
                    break;
                default:
                    Console.WriteLine("Laboral");
                    break;
            }
            Console.ReadLine();
        }
    }
}


/*
   
   int number = (int)dayOfWeek;
 
   switch (number)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Laboral");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("No laboral");
                    break;
                default:
                    Console.WriteLine("Solo hay 7 días a la semana");
                    break;
            }*/