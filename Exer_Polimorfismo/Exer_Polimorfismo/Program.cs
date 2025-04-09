using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exer_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tipo de Funcionário deseja lançar?");
            Console.WriteLine();
            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Desenvolvedor");
            Console.WriteLine();
            Console.Write("Opção: ");
            int typeFunc = int.Parse(Console.ReadLine());

            Funcionario[] f = null;

            switch (typeFunc)
            {
                case 1:
                    {
                        Console.Write("Qual a quantidade de gerentes que deseja lançar?: ");
                        int qtdGerente = int.Parse(Console.ReadLine());
                        f = new Gerente[qtdGerente];
                        break;
                    }
                case 2:
                    {
                        Console.Write("Qual a quantidade de desenvolvedores que deseja lançar?: ");
                        int qtdDev = int.Parse(Console.ReadLine());
                        f = new Desenvolvedor[qtdDev];
                        break;
                    }
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            if(f != null)
            {
                for (int i = 0; i < f.Length; i++)
                {
                    Console.Clear();
                    Console.Write("Nome do " + (i + 1) + "o funcionário: ");
                    string name = Console.ReadLine();
                    Console.Write("Bonus do Funcionário " + name + ": ");
                    double bonus = double.Parse(Console.ReadLine());

                    if (typeFunc == 1){
                        f[i] = new Gerente(name, bonus);
                    }

                    if (typeFunc == 2)
                    {
                        f[i] = new Desenvolvedor(name, bonus);
                    }
                    
                }


                foreach (Funcionario func in f)
                {
                    Console.WriteLine("Nome: " + func.Nome);
                    Console.WriteLine("Salário Base: " + func.SalarioBase);
                    Console.WriteLine("Bonus: " + (func.Bonus * 100) + "%");
                    Console.WriteLine("Salário Final: " + func.CalcularSalario());
                    Console.WriteLine();
                }
            }
        }
    }
}
