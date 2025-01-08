
namespace ClassesMetodos;

public class Classes
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nOla esse é o modulo de classes deseja Continuar? Sim/Não\n");
        string entrada = Console.ReadLine();
        var entradaConfirmar = entrada.ToLower();
        if (entradaConfirmar == "sim")
        {
            Console.WriteLine("O EXERCICIO ESTA EM EXECUÇÃO ... \n");
            // ClassesXobjeto.classeXobjeto();

            //exercicio dados pessoa
            // Membros.MembrosClasse();
            // Membros.ProfissaoDados();

            //exercicio dados do carro
            // Construtores.ExercicioCarro();


            //Metodos de Retornar
            // MetodoRetorno.Executar();
            // Instanciar.Executar();
            // MemborEstatico.Executar();
            // AtributosEstaticos.Executar();

            //DESAFIO

            // Desafio.Executar();

            //Parametros

            // Params.Executar();
            // ParametroNomeado.Executar();

            //GET SET

            // GetSet.Executar();
            
            //Propriedades

            // Props.Executar();
            // Readonly.Executar();
            Enum.Executar();


        } else{
            Console.WriteLine("Erro de Acesso");
        }


    }

}