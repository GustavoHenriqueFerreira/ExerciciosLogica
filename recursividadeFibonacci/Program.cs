using System;

namespace recursividadeFibonacci
{
    class Program
    {
        static int FibonacciMaior(int numero)
        {
            if ((numero == 0) || (numero == 1))
            {
                return numero;
            }
            else
            {
                return (FibonacciMaior(numero - 1) + FibonacciMaior(numero - 2));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciMaior(10));
        }
    }
}
