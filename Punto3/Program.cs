
Console.WriteLine("porfavos, ingrese un intervalo inicial de números");
int numerosusuarioinicial = int.Parse(Console.ReadLine());
Console.WriteLine("ahora el numero final del intervalo");
int numerosusuariofinal = int.Parse(Console.ReadLine());
while (numerosusuarioinicial <= numerosusuariofinal)
{
    Console.WriteLine(numerosusuarioinicial);
    numerosusuarioinicial++;
}

Console.ReadKey();