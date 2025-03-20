int mes = 0;
int Final = 0;
do
{
    Console.WriteLine("ingrese un numero del 1 al 12");
    Console.WriteLine("ingrese el numero 13 para finalizar");
    mes = int.Parse(Console.ReadLine());
    switch (mes)
    {
        case 1:
            {
                Console.WriteLine("Enero");
            }

            break;
        case 2:
            {
                Console.WriteLine("Febrero");
            }
            break;
        case 3:
            {
                Console.WriteLine("Marzo");
            }
            break;
        case 4:
            {
                Console.WriteLine("Abril");
            }
            break;
        case 5:
            {
                Console.WriteLine("Mayo");
            }
            break;
        case 6:
            {
                Console.WriteLine("Junio");
            }
            break;
        case 7:
            {
                Console.WriteLine("Julio");
            }
            break;
        case 8:
            {
                Console.WriteLine("Agosto");
            }
            break;
        case 9:
            {
                Console.WriteLine("Septiembre");
            }
            break;
        case 10:
            {
                Console.WriteLine("Octubre");
            }
            break;
        case 11:
            {
                Console.WriteLine("Noviembre");
            }
            break;
        case 12:
            {
                Console.WriteLine("Diciembre");
            }
            break;

        case 13:
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