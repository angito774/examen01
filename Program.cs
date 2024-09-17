static string DeterminarSigno(double numero)
{
    if (numero > 0)
    {
        return "El número es positivo.";
    }
    else if (numero < 0)
    {
        return "El número es negativo.";
    }
    else
    {
        return "El número es cero.";
    }
}

static void ImprimirDiaSemana(int dia)
{
    switch (dia)
    {
        case 1:
            Console.WriteLine("Lunes");
            break;
        case 2:
            Console.WriteLine("Martes");
            break;
        case 3:
            Console.WriteLine("Miércoles");
            break;
        case 4:
            Console.WriteLine("Jueves");
            break;
        case 5:
            Console.WriteLine("Viernes");
            break;
        case 6:
            Console.WriteLine("Sabado");
            break;
        case 7:
            Console.WriteLine("Domingo");
            break;
        default:
            Console.WriteLine("Por favor ingrese un numero del 1 al 7");
            break;
    }
}


static int CalcularSuma(int n)
{
    return n * (n + 1) / 2;
}


static void ImprimirNumerosHasta(int numero)
{
    for (int i = 1; i <= numero; i++)
    {
        Console.WriteLine(i);
    }
}

static double CalcularAreaCirculo(double radio)
{
    return Math.PI * Math.Pow(radio, 2);
}


static void MostrarElementosArreglo()
{
    int[] arreglo = { 1, 2, 3, 4, 5 };
    Console.WriteLine("Los Elementos del arreglo son:");
    foreach (int num in arreglo)
    {
        Console.WriteLine(num);
    }
}

static void MostrarNombres()
{
    List<string> lista = new List<string> { "pepe", "lucho", "david", "pedro" };
    Console.WriteLine("Los nombres de la lista son:");
    foreach (string num in lista)
    {
        Console.WriteLine(num);
    }
}


string option;
do
{
    Console.WriteLine("*********** Menú *******************");
    Console.WriteLine("1) Valida Numero Positivo o Negativo");
    Console.WriteLine("2) Imprimir Día");
    Console.WriteLine("3) Suma de los primeros 100 numeros naturales");
    Console.WriteLine("4) Imprimir todos los numeros desde el 1 hasta el ingresado");
    Console.WriteLine("5) Calcular el area de un circulo");
    Console.WriteLine("6) Mostrar elementos de arreglo");
    Console.WriteLine("7) Mostrar nombres de personas");
    Console.WriteLine("8) Salir");
    option = Console.ReadLine().ToUpper();

    switch (option)
    {
        case "1":
            Console.Write("Ingresa un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            string resultado = DeterminarSigno(numero);
            Console.WriteLine(resultado);
            break;
        case "2":
            Console.WriteLine("Ingrese Numero Día Semana");
            if (int.TryParse(Console.ReadLine(), out int diaIngresado))
            {
                ImprimirDiaSemana(diaIngresado);
            }
            else
            {
                Console.WriteLine("Entrada No Valida Ingrese numero del 1 al 7");
            }
            break;


        case "3":
            int suma = CalcularSuma(100);
            Console.WriteLine("La suma de los primeros 100 números naturales es: " + suma);
            break;

        case "4":
            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int numm))
            {
                ImprimirNumerosHasta(numm);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
            break;

        case "5":
            Console.Write("Ingresa el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            double area = CalcularAreaCirculo(radio);
            Console.WriteLine($"El área del círculo es: {area}");
            break;
        case "6":
            MostrarElementosArreglo();
            break;
        case "7":
            MostrarNombres();
            break;
        case "8":
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
} while (option != "8");


