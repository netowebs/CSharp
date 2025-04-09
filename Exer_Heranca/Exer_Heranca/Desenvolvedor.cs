using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_Heranca
{
    internal class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(string nome)
        {
            Nome = nome;
            Bonus = 0.10;
        }
    }
}
