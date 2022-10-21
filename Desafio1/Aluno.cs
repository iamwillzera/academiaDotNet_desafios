using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    public class Aluno : Pessoa
    {
        public string matricula;
        public string codCurso;
        public string curso;

        public Aluno(string matricula, string codCurso, string curso)
        {
            this.matricula = matricula;
            this.codCurso = codCurso;
            this.curso = curso;
        }

        public void preencheAluno()
        {
            string linha;
            string[] dadosId;

            StreamReader leitor = new StreamReader("arquivo.txt");

            do
            {
                linha = leitor.ReadLine();
                dadosId = linha.Split("-");

                if (dadosId[0] == "Z")
                {
                    nome = dadosId[1];
                }

                if (dadosId[0] == "Y")
                {
                    matricula = dadosId[1];
                    codCurso = dadosId[2];
                    curso = dadosId[3];

                    Console.WriteLine("Aluno: " + nome + " => Matrícula: " + matricula + " => Código do curso: " + codCurso + " => Nome do curso: " + curso);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                }

            } while (!leitor.EndOfStream);

            leitor.Close();
        }

    }
}
