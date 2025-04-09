using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNotasPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe a quantidade de alunos: ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            Aluno[] aluno = new Aluno[qtdAlunos];
            
            for(int i = 0; i < aluno.Length; i++)
            {
                Console.Clear();
                Console.Write("Informe o nome do "+(i+1) +"o aluno: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a quantidade de notas do aluno: "+nome+": ");
                int qtdNotas = int.Parse(Console.ReadLine());

                aluno[i] = new Aluno(nome, qtdNotas);
                aluno[i].InsertNotas();

            }

            foreach (Aluno a in aluno)
            {
                Console.WriteLine("Aluno: " + a.Nome);
                Console.WriteLine("Média: " + a.Media);
            }

        }
    }
}
