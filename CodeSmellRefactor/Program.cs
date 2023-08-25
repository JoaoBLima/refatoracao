

using System.Diagnostics;
using CodeSmellRefactor;

class Program
{
    public static void Main(string[] args)
    {

        Aluno aluno = new Aluno("Maria da Silva", 18, "Rua da Felicidade", "7158956858", "maria@teste.com", "Engenharia da Computação");
        Professor professor = new Professor("João da Silva", 45, "Rua da Alegria", "7158585858", "j@teste.com", "Matemática");

       Console.WriteLine(aluno.ToString() + "\n");
        Console.WriteLine(professor.ToString());
    }
}
