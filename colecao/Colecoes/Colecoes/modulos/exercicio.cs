using System;
namespace Colecao.Modulos
{
    public class Exercicio
    {
        public static void Executar()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            int maior = numeros[0];
            
            foreach(int numero in numeros)
            {
                if(numero > maior)
                {
                    maior = numero;
                    
                }
            }
            Console.WriteLine(maior);
        }
    }
}