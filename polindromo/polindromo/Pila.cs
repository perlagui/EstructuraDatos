namespace polindromo
{
    public class Pila
    {
        private char[] elementos;
        private int tope;

        public Pila(int tamano)
        {
            elementos = new char[tamano];
            tope = -1;
        }

        public void Push(char dato)
        {
            if (tope == elementos.Length - 1)
            {
                Console.WriteLine(" La pila está llena.");
                return;
            }
            elementos[++tope] = dato;
        }

        public char Pop()
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
