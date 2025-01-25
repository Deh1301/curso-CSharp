using System;
using System.Threading.Tasks;
using Colecao.Modulos; 

namespace Colecao
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Modulo de Coleções!\n\n");

            Console.WriteLine("Escolha seu exercicio:");
            Console.WriteLine("1- Arrays;");
            Console.WriteLine("\n");
            Console.WriteLine("O exercicio é :");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    ArrayModule.Executar();
                    // Exercicio.Executar();
                    // ExercicioArray.Executar();
                    await Task.Delay(2000);
                    break;
            }
        }
    }
}
