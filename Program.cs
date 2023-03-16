
using System;
    class ejercicio //********************* Recorriendo numeros primos del 1 al 100  ******************
{
        static void Main()
    {
        int divisor = 0; 
        int n = 0;

        Console.Write("\n\nNúmeros primos del 0 al 100\n\n");
        n = Int32.Parse(Console.ReadLine());

        for (n = 0; n <= 100; n++)
        {
            for (divisor = 2; n % divisor != 0; divisor++)
                if (divisor == n)
                 Console.Write("{0}|",n);
           
        }
        Console.ReadKey();
    }
}
// leer sobre Appen 
/*
using System;
class ejercicio //********************* Recorriendo desde el numero q se ponga en consola de 3 en 3  ******************
{
        static void Main()
    {
        int num, suma = 0, n, divisor,cont = 0;

        Console.Write("Número:");
        num = Int32.Parse(Console.ReadLine());

        for (int i = 1; i < num + 1; i++) 
            if ((i % 3) == 0)
        Console.Write("{0}|", i);
    }
}

/*
using System;
class ejercicio //********************* Recorriendo desde el numero q se ponga en consola ******************
{
    static void Main()
    {
        int num, suma = 0, n, divisor,cont = 0;

        Console.Write("Número:");
        num = Int32.Parse(Console.ReadLine());

        for (int i = 1; i < num + 1; i++) // int i =1; -> 1 es desde el numero q empieza,
        Console.Write("{0}|", i);
    }
}
*/
/*
using System;

class ejercicio // **************** PARES E IMPARES ****************************
{
    static void Main()
    {
        int i, impar = 0;

        for (i = 0; i <= 100; i++) // Este For dice: i=0; hasta que i no sea (Mayor o igual) <= a 100; incrementano 1 a 1 i++
        {
            if ((i % 2) == 0 || (i % 3)== 0)// Esto concatena con || los divisores entre 2 y 3 
            {
                Console.Write("{0}|", i);
                impar++;              
            }
        }
    }
}
*/
/*
using System;

class ejercicio // **************** PARES E IMPARES ****************************
{
    static void Main()
    {
        int i, impar = 0;

        for (i = 0; i <= 100; i++) // Este For dice: i=0; hasta que i no sea (Mayor o igual) <= a 100; incrementano 1 a 1 i++
        {
            if (i % 2 == 0) // i entre 2 % resto, tiene que ser distinto != a 0. Cambiando el != (IMPAR) por el == (PAR) cambia par o impar
            {
                Console.Write("{0}|", i);
                impar++;              
            }
        }
    }
}
*/
/*
using System;

namespace PruebaTriangulo
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Escribe una frase");
            string cadena = Console.ReadLine();

            for ( int i =0; i< cadena.Length; i++)
            {
            Console.WriteLine(cadena[i]);
            }
        Console.ReadLine();
            
        }
    }
}
*/