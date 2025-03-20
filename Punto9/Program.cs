int final = 0;
do
{
    Console.WriteLine("ingrese un numero par ver si es par");
    int numero = int.Parse(Console.ReadLine());
    if (numero % 2 == 0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }
    Console.WriteLine("desea ingresa 1 si desea ingresar otro numero, en caso contrario cualquiera");
    int seguir = int.Parse(Console.ReadLine());
    if (seguir != 1)
    {
        final = 99;
    }
}
while (final != 99);