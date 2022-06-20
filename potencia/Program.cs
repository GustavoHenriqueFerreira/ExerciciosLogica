using System;

namespace funcoes
{
    class Program
    {
        static int Exibir(int numero, int expoente){
            int resultado = 1;
 for (int i = 0; i < expoente; i++)
 {
    resultado = resultado * numero;
 }
                return resultado;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Exibir(2, 3));
        }
    }
}
