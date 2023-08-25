using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmellRefactor
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, int idade, string endereco, string telefone, string email)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString() //criaçao do tostring para melhorar a representação do texto.
        {
            return $"Nome: {Nome}\nIdade: {Idade}\nEndereço: {Endereco}\nTelefone: {Telefone}\nE-mail: {Email}";
        }
    }
}
