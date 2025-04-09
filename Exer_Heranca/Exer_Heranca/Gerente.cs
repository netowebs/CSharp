using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_Heranca
{
    internal class Gerente : Funcionario
    {

        public Gerente(string nome)
        {
            Nome = nome;
            Bonus = 0.20;
        }

    }
}
