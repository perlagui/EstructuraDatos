using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiladesdeCero
{
    internal class Fila
    {
            private int[] elementos;
            private int frente;
            private int final;
            private int tamaño;
            private int cantidad;

            public Fila(int capacidad)
            {
                elementos = new int[capacidad];
                tamaño = capacidad;
                frente = 0;
                final = -1;
                cantidad = 0;
            }

            // Insertar (Enqueue)
            public void Enqueue(int valor)
            {
                if (cantidad == tamaño)
                {
                    throw new InvalidOperationException("La fila está llena");
                }
                final = (final + 1) % tamaño;
                elementos[final] = valor;
                cantidad++;
            }

            // Eliminar (Dequeue)
            public int Dequeue()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("La fila está vacía");
                }
                int valor = elementos[frente];
                frente = (frente + 1) % tamaño;
                cantidad--;
                return valor;
            }

            // Ver primero
            public int Peek()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("La fila está vacía");
                }
                return elementos[frente];
            }

            // Verificar si está vacía
            public bool IsEmpty()
            {
                return cantidad == 0;
            }

            // Obtener elementos para mostrar
            public int[] ObtenerElementos()
            {
                int[] copia = new int[cantidad];
                for (int i = 0; i < cantidad; i++)
                {
                    copia[i] = elementos[(frente + i) % tamaño];
                }
                return copia;
            }
        }

    }