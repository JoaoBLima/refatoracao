using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmellRefactor
{
    public class Professor : Pessoa
    {
        public string Materia { get; set; }

        public Professor(string nome, int idade, string endereco, string telefone, string email, string materia)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Materia = materia;
        }

       public override string ToString()
        {
            return base.ToString() + $"\nMateria: {Materia}"; ;
        }
    }

}
