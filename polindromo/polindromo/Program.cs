 using System;
namespace polindromo
{

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine(); 

        Pila pila = new Pila(palabra.Length);

        // Apilamos cada carácter
        foreach (char c in palabra)
        {
            pila.Push(c);
        }

        // Desapilamos para invertir la palabra
        string invertida = "";
        while (!pila.Vacia())
        {
            invertida += pila.Pop();
        }

        // Comparamos
        if (palabra == invertida)
        {
            Console.WriteLine($" \"{palabra}\" es un palíndromo.");
        }
        else
        {
            Console.WriteLine($" \"{palabra}\" no es un palíndromo.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
}