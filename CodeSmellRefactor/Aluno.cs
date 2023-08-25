using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmellRefactor
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }

        public Aluno(string nome, int idade, string endereco, string telefone, string email, string curso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Curso = curso;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCurso: {Curso}"; ;
        }
    }
}
