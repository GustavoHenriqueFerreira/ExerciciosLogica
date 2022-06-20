using System;

namespace recursividade
{
    class Program
    {
        static int Fatorial(int numero){
            int resultado;

            if (numero <= 1){
                resultado = 1;
            } else {
                resultado = numero * Fatorial(numero - 1);
            };

            return resultado;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fatorial(13));
        }
    }
}
