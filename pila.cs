namespace expresionmatematica
{
    public class pila
    {
        private char[] elementos;
        private int tope;

        public pila(int tamano)
        {
            elementos = new char[tamano];
            tope = -1;
        }

        public void push(char dato)
        {
            if (tope == elementos.Length - 1)
            {
                Console.WriteLine(" La pila está llena.");
                return;
            }
            elementos[++tope] = dato;
        }

        public char pop()
        {
            if (Vacia())
            {
                Console.WriteLine(" La pila está vacía.");
                return '\0'; // carácter nulo
            }
            return elementos[tope--];
        }
        public bool Vacia()
        {
            return tope == -1;
        }
    }

} 
