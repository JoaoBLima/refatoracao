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
            : base(nome, idade, endereco, telefone, email) // para evitar repetição nos construtores
        {
            Materia = materia;
        }

       public override string ToString() // sobreposição do metodo para evitar as repetições do codigo anterior
        {
            return base.ToString() + $"\nMateria: {Materia}"; ;
        }
    }

}
