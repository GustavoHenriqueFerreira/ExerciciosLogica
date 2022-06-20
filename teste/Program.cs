using System;

namespace teste
{
    class Program
    {    
        static void Main(string[] args)
        {
            /* string usuario;
            string senha;
            bool deslogado = false;
            string senhaCorreta = "11";
            string usuarioCorreto = "gustavo";
            /* string opcoesMenu;
            string resposta; */
            /* string[] dataVoo;
            string[] localViagem;
            string[] localDestino;
            string[] horaDataViagem; *

            do 
            {
                Console.WriteLine("digita o usuario: ");
                usuario = Console.ReadLine();

                Console.WriteLine("digita a senha: ");
                senha = Console.ReadLine();

                if(senha == senhaCorreta && usuario == usuarioCorreto)
                {               
                    Console.WriteLine("Deu certo o login");
                    deslogado = true;
                } else {
                    Console.WriteLine("Inválido, Digite a senha/usuário correto");
                }
            } while (deslogado != true); */
           int[] sequencia = null;
            sequencia = new int [5];
            Console.WriteLine("Ae mano, declara 5 numeros, quer ver eu colocar eles na ordem inversa? Truque de mágica, imperdivel!");

            int c = 0;
            foreach (var item in sequencia)
            {
                sequencia[c] = int.Parse(Console.ReadLine());
                c++;
            }

            Console.WriteLine("ALAKAZAN!");

            c = 4;
            foreach (var item in sequencia)
            {
                Console.WriteLine(sequencia[c]);
                c--;
            }        }
    }
}
