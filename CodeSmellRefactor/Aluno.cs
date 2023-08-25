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
            : base(nome, idade, endereco, telefone,email) // para evitar repetição nos construtores
        {
           
            Curso = curso;
        }

        public override string ToString() // sobreposição do metodo para evitar as repetições do codigo anterior
        {
            return base.ToString() + $"\nCurso: {Curso}"; ;
        }
    }
}
