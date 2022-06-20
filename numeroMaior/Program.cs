using System;

namespace numeroMaior
{
    class Program
    {
        static int Maior(int a, int b, int c){
            int[] numeros = new int[] { a };
            numeros = new int[] { b };
            numeros = new int[] { c };
            int numeroMaior = 0;
            int numeroMenor = 0;
            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > numeroMaior)
                {
                    numeroMaior = numeros[i];
                    Console.WriteLine(numeroMaior);
                }
            }

            return numeroMaior;
        }

        static void Main(string[] args)
        {
            Maior(2, 3, 4);
        }
    }
}
