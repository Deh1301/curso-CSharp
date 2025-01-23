using System;

namespace Colecao.Modulos
{
    public class ArrayModule
    {
        public static void Executar()
        {
            string[] alunos = new string[5] 
            { "André", "Julia", "Athony", "Laura", "Gael" };
            Console.WriteLine($"No indice zero esta: {alunos[0]}");
            int[] numero = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numero[0]);
            
            foreach(int numeros in numero)
            {
                Console.WriteLine(numeros);

            }
            char[] letras = new char[5]
            { 'A','N','D','R','E'};
            foreach(char letra in letras)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
