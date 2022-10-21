using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Desafio1
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string cidade { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }

        public Pessoa()
        {
        }

        public void qtdePessoaAluno()
        {
            int contAluno = 0;
            int contPessoa = 0;
            string linha;
            string[] dados;
            StreamReader leitor = new StreamReader("arquivo.txt");
            do
            {
                linha = leitor.ReadLine();
                dados = linha.Split("-");

                if (dados[0] == "Z")
                {
                    contPessoa++;
                }
                else if (dados[0] == "Y")
                {
                    contAluno++;
                }
            } while (!leitor.EndOfStream);

            leitor.Close();

            Console.WriteLine("Quantidade de alunos: " + contAluno);
            Console.WriteLine("Quantidade de pessoas: " + (contPessoa - contAluno));

        }



    }
}
