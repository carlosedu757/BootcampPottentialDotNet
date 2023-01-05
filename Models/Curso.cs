using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"There are {Alunos.Count} student(s) enrolled in {Nome}.");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"Full Name: {aluno.NomeCompleto}");
            }
        }
    }
}