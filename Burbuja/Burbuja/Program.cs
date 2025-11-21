using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 1, 4, 2, 8 };
        Burbuja(numeros);
        Console.WriteLine("Arreglo ordenado:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
       
    

    }
    static void Burbuja(int[] arreglo)
    {
      
        for (int i = 0; i < arreglo.Length  - 1; i++)
        {
            for (int j = arreglo.Length-1; j > i; j--)
            {
                if (arreglo[j] < arreglo[j - 1])
                {
                
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j - 1];
                    arreglo[j - 1] = temp;
                }
            }
        }
    }
}

 


