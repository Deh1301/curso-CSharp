using System;
using System.Collections;

namespace orientacaoObjeto{
    class OrientarObjeto{
        public static void Main(string[] args){
            System.Console.WriteLine("\nBem Vindo ao modulo de orientação a objeto");
            
            System.Console.WriteLine("\n1-Abstração");

            System.Console.WriteLine("\nEscolha o exercicio:");

            string escolha = Console.ReadLine();
            switch(escolha){
                case "1":
                Abstract.Executar();
                break;
        }
    }
  }
}