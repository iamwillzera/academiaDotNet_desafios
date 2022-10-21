using System.Globalization;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string matricula = "";
            string codCurso = "";
            string curso = "";

            Aluno aluno = new Aluno(matricula, codCurso, curso);

            Pessoa pessoa = new Pessoa();
            pessoa.qtdePessoaAluno();

            Console.WriteLine("=======================================");
            Console.WriteLine("### ALUNOS MATRICULADOS ###\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            aluno.preencheAluno();
        }

    }
}