using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_Polimorfismo
{
    internal class Funcionario
    {

        public string Nome { get; set; }

        public double Bonus { get; set; }
        public double SalarioBase { get; private set; } = 3000;

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }

    }
}
