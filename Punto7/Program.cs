int dia = 0;
int Final = 0;
do
{
    Console.WriteLine("ingrese un numero del 1 al 7");
    Console.WriteLine("ingrese el numero 8 para finalizar");
    dia = int.Parse(Console.ReadLine());
    switch (dia)
    {
        case 1:
            {
                Console.WriteLine("viernes");
            }

            break;
        case 2:
            {
                Console.WriteLine("Sabado");
            }
            break;
        case 3:
            {
                Console.WriteLine("Domingo");
            }
            break;
        case 4:
            {
                Console.WriteLine("Lunes");
            }
            break;
        case 5:
            {
                Console.WriteLine("Martes");
            }
            break;
        case 6:
            {
                Console.WriteLine("Miercoles");
            }
            break;
        case 7:
            {
                Console.WriteLine("Jueves");
            }
            break;
        case 8:
            {
                Console.WriteLine("si realmente quiera salir ingrese 1, caso contrario cualquier numero");
                int confirmacion = int.Parse(Console.ReadLine());
                if (confirmacion == 1)
                {
                    Final = 8;
                }
            }
            break;
        default:
            {
                Console.WriteLine("ingrese un numero valido");
            }
            break;

    }

}
while (Final != 8);