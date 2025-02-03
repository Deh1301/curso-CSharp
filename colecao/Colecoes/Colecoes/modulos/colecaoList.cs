using System;
using System.Collections.Generic;
using System.Text;

namespace Colecao.Modulos
{
    //public class Produto
    //{
    //    public string Nome;
    //    public double Preco;

    //    public Produto(string Nome, double Preco)
    //    {
    //        Nome = nome;
    //        Preco = preco;

    //    }

    //}


    class ColecaoList
    {
        public static void Executar()
        {

            //var livro = new Produto("Avengers", 20.0);
            //var carrinho = new List<Produto>();

            List<string> nomes = new List<string>();
            nomes.Add("André");
            nomes.Add("Julia");
            nomes.Add("Anthony");

            Console.WriteLine("Os nomes sao:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            List<int> numeros = new List<int>();
            System.Console.WriteLine("Adicione 5 numeros: ");
            numeros.Add(int.Parse(Console.ReadLine()));
            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Add(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("\n os numeros adicionados sao : ");



            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);
            }

            System.Console.WriteLine("Qual vc deseja remover: ");
            numeros.Remove(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Agora os numeros sao");
            foreach (int numero in numeros)
            {

                System.Console.WriteLine(numero);
            }



        }

    }
}


