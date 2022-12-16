Console.WriteLine("Introduzca un caracter dependiendo de su estado civil");
string input = Console.ReadLine();
char state = input[0];
switch (state)
{
    case 'C':
        Console.WriteLine("Casado");
        break;
    case 'S':
        Console.WriteLine("Soltero");
        break;
    case 'V':
        Console.WriteLine("Viudo");
        break;
    case 'D':
        Console.WriteLine("Divorciado");
        break;
    default:
        Console.WriteLine("Estado no existe");
        break;
}

Console.WriteLine("\nPulse enter para cerrar");
Console.ReadLine();


/*char letra = Convert.ToChar(Console.ReadLine());
char letra2 = char.ToUpper(letra);
switch (letra2)*/


string result;
result = state switch
{
    'C' => "Casado",
    'S' => "Soltero",
    'V' => "Viudo",
    'D' => "Divorciado",
    _ => "Estado no existe",

};