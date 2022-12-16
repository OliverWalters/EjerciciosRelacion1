using System;

/*namespace Ejercicio_12_Bien;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduce una palabra");
        string word = Console.ReadLine();
        int i = 0;
        int j = word.Length - 1;
        bool somos = true;
        int p = 0;
        int t = 0;

        for (i = 0; i <= j; i++)
        {
            p = j - i;
            somos = word[i] == word[p];
            if (somos)
            {
                t++;
            }
        }
        if (t == word.Length)
        {
            Console.WriteLine("Si, es un palíndromo");
        }
        else { Console.WriteLine("No, no es un palíndromo"); }

        Console.ReadLine();
    }
}*/


//Bien hecho abajo


namespace Ejercicio_12_Bien;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduce una palabra");
        string word = Console.ReadLine();

        bool isPalindrome = true;

        for (int i = 0; i < word.Length && isPalindrome; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                isPalindrome = false;
            }
        }

        if (isPalindrome)
            Console.WriteLine($"La palabra {word} es un palíndromo");
        else
            Console.WriteLine($"La palabra {word} no es un palíndromo");

        Console.ReadLine();
    }
}

/*
        Console.WriteLine("Introduzca una palabra");
        string word = Console.ReadLine();
        bool isPalindrome = true;

        for (int i = 0; i < word.Length; i++)
        {
            isPalindrome = word[i] == word[word.Length - 1 -i];
        }
        if (isPalindrome)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        Console.ReadLine
*/