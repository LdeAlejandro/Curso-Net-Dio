using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Net_2.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool removerAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
             Console.WriteLine($"Alunos do curso de: {Nome}");

            for(int i = 0; i < Alunos.Count; i++)
            {
                int numeroDeAluno = i + 1;
                string text = $"Aluno Nr {numeroDeAluno+=1:D2}. - {Alunos[i].NomeCompleto}";
                Console.WriteLine(text);
                
    
            }
            

            Console.WriteLine("*******************************************************");

            foreach(Pessoa aluno in Alunos)
            {
                int numeroDeAluno = Alunos.IndexOf(aluno) + 1;
                string text = $"Aluno Nr {numeroDeAluno:D2}. - {aluno.NomeCompleto}";
                Console.WriteLine(text);
                
            }

        }
        
    }
}