namespace ClassesMetodos
{
    public class Membros
    {
        public static void MembrosClasse()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Andre";
            pessoa.Idade = 24;
            Console.WriteLine($"Ola o nome é {pessoa.Nome} e a idade é {pessoa.Idade}");

           var profissao = new Pessoa();
           profissao.Nome = "Programador";
           Console.WriteLine($"E a profissao dele é:{profissao.Nome}");
        }

    }
}