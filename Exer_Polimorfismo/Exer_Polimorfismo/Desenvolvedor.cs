using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_Polimorfismo
{
    internal class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(string nome, double bonus)
        {
            Nome = nome;
            Bonus = bonus/100;
        }

        public override double CalcularSalario()
        {
            double salarioTotal = SalarioBase + (SalarioBase * Bonus);
            return salarioTotal;
        }
    }
}
