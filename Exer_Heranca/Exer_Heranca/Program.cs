using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente("João");
            g.CalcularSalario();

            Desenvolvedor d = new Desenvolvedor("José");
            d.CalcularSalario();

            Console.Title = "Salário de Funcionários";

            Console.WriteLine("Cargo: Gerente");
            Console.WriteLine("Salário Base: " + g.SalarioBase);
            Console.WriteLine("Bonus: " + (g.Bonus*100)+"%");
            Console.WriteLine("Salário Final: " + g.CalcularSalario());

            Console.WriteLine();

            Console.WriteLine("Cargo: Desenvolvedor");
            Console.WriteLine("Salário Base: " + d.SalarioBase);
            Console.WriteLine("Bonus: " + (d.Bonus*100)+"%");
            Console.WriteLine("Salário Final: " + d.CalcularSalario());

            Console.ReadKey();

        }
    }
}
