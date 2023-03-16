
using System;

prublic class Ejemplo_05_07b
{
    prublic static void Duplicar (ref int x)
    {
        Console.WriteLine(" El valor recibido vale {0} ", x );
        x = x * 2;
        Console.WriteLine(" y ahora vale {0}", x); 
    }
    public static void Main()
    {
        int n 0 = 5;
        Console.WriteLine(" n cale {0}", n);
        Duplicate(ref n);
        Console.WriteLine("Ahora n vale {0}", n);
    }
}
