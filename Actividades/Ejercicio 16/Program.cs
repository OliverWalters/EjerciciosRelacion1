namespace Prueba;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduce un número de base 10");
        int base10 = int.Parse(Console.ReadLine());
        Console.WriteLine("En que base quiere convertirlo");
        int newbase = int.Parse(Console.ReadLine());
        string texto = "";

        if (newbase > 9 || newbase < 2)
        {
            Console.WriteLine("La base iene que ser un numero entre el 2 y el 9");
        }
        else
        {
            for (; base10 / newbase > 0; base10 /= newbase)
            {
                texto += base10 % newbase;
            }

            int numero = base10 % newbase;
            texto = texto + numero;

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                Console.Write(texto[i]);
            }
        }
        Console.ReadLine();
    }
}