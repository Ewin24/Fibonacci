//! INICIO 1. Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-ésimo número de Fibonacci

static int fibonacci1(int n)
{
    int a = 0;
    int b = 1;
    int c = 0;


    for (int i = 0; i < n; i++)
    {
        a = b;
        b = c;
        c = b + a;
    }
    return c;
}

Console.WriteLine("Ingrese n: ");
var n = Int32.Parse(Console.ReadLine());
Console.WriteLine(fibonacci1(n));
Console.WriteLine("\n");

//! FIN 1



//! INICIO 2.Escriba un programa que reciba como entrada un número entero e indique si es o no un número de Fibonacci

static string fibonacci2(int n)
{
    string mensaje = "no es un numero de fibonacci";
    bool flag = false;
    int a = 0;
    int b = 1;
    int c = 0;


    for (int i = 0; i < n; i++)
    {
        a = b;
        b = c;
        c = b + a;
        if (c == n)
        {
            mensaje = "es un numero de fibonacci";
            break;
        }
    }

    return n + " " + mensaje;
}

Console.WriteLine("Ingrese un numero: ");
n = Int32.Parse(Console.ReadLine());
Console.WriteLine(fibonacci2(n));
Console.WriteLine("\n");

//! FIN 2


//! INICIO 3.Escriba un programa que muestres los m primeros números de Fibonacci, donde m es un número ingresado por el usuario

static string fibonacci3(int n)
{
    string mensaje = "Los " + n + " primeros numeros de Fibonacci son: ";
    int a = 0;
    int b = 1;
    int c = 0;


    for (int i = 0; i < n; i++)
    {
        mensaje += " " + c;
        a = b;
        b = c;
        c = b + a;
    }

    return mensaje;
}

Console.WriteLine("Ingrese m: ");
n = Int32.Parse(Console.ReadLine());
Console.WriteLine(fibonacci3(n));

//! FIN 3
