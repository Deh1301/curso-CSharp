using System;
using System.Globalization;

namespace ClassesMetodos;

public class Classes{
    public static void Main(string[] args){
        Console.WriteLine("\nOla esse é o modulo de classes deseja Continuar? Sim/Não\n");
        string entrada = Console.ReadLine();
        var entradaConfirmar = entrada.ToLower() == "sim" ? "Bem Vindo seu exercicio sera executado" : "Voce não Acesso, encerrando";
        Console.WriteLine($"{entradaConfirmar}\n");

        // ClassesXobjeto.classeXobjeto();

        //exercicio dados pessoa
        Membros.MembrosClasse();
        Membros.ProfissaoDados();

    }
       
}