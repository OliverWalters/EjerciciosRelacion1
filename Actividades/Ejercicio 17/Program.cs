using System.Xml.Schema;

namespace Ejercicio_17;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduce un texto");
        string text = Console.ReadLine();
        text = text.ToUpper();
        string letrasContadas = "";
        for (int i = 0; i < text.Length; i++)
        {
            int contador = 0;

            if (letrasContadas.Contains(text[i])) { }
            else
            {
                letrasContadas += text[i];
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        contador++;
                    }
                }
                Console.WriteLine($"{text[i]} = {contador.ToString()}");
            }
        }
        Console.ReadLine();
    }
}