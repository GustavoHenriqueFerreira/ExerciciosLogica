using System;

namespace testeArrayInvertido
{
    class Program
    {
        static int InverteArray(int a, int b, int c) {
            int[] arr = new int[] { a, b, c };
            int tamanho = arr.Length - 1;
            for (int i = tamanho; i >= 0; i--) { 
            Console.Write(arr[i]); 
            }            
            return arr[1];
    }

        static void Main(string[] args)
        {
            InverteArray(2, 4, 5);
        }
    }
}
