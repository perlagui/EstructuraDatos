using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace expresionmatematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una expresion matematica: ");
            string expresion = Console.ReadLine();

            pila unapila = new pila(expresion.Length);
            bool balanceado = true;

           foreach (char c in expresion)
    {
        // Si es símbolo de apertura, se apila
        if (c == '(' || c == '{' || c == '[')
        {
            unapila.push(c);
        }
        // Si es símbolo de cierre, se desapila y se compara
        else if (c == ')' || c == '}' || c == ']')
        {
            if (unapila.Vacia())
            {
                balanceado = false;
                break;
            }

            char cima = unapila.pop();

            if (!Compara(cima, c))
            {
                balanceado = false;
                break;
            }
        }
        // Si es otro carácter (número, signo, etc.), lo ignoramos
    }

    // Al final, si la pila no está vacía, hay error
    if (!unapila.Vacia())
    {
        balanceado = false;
    }
      if (balanceado)
    {
        Console.WriteLine("La expresion esta balanceada");
    }
    else
    {
        Console.WriteLine("La expresion no esta balanceada");
    }


            static bool Compara(char a, char b)
            {
                if (a == '(' && b == ')') return true;
                if (a == '{' && b == '}') return true;
                if (a == '[' && b == ']') return true;
                return false;
            }

        }

    }
}
            
            
        
    
