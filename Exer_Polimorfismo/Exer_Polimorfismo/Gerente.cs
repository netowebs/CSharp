using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_Polimorfismo
{
    internal class Gerente : Funcionario
    {

        public Gerente(string nome, double bonus)
        {
            Nome = nome;
            Bonus = bonus / 100;
        }

        public override double CalcularSalario()
        {
            double salarioTotal = SalarioBase + (SalarioBase * Bonus);
            return salarioTotal;
        }

    }
}
