using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundamentosMetodos.Model;

namespace FundamentosMetodos.Model
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            //When hovering over the Remove method it is possible to see that it returns a bool value, which can be used to validate if the action was succesfull.
            return Alunos.Remove(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                // //Concatenação de Strings para exibir númeração ao lado de cada aluno.
                // string texto = "Nº " + (count + 1) + " - " + Alunos[count].NomeCompleto;
                // Console.WriteLine(texto);

                //Interpolação de Strings para exibir númeração ao lado de cada aluno.
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }

    }
}