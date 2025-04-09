using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNotasPOO
{
    internal class Aluno
    {

        public string Nome { get; set; }
        public int _qtdNotas;
        private double[] _notas;

        public Aluno(string name, int qtdNotas)
        {
            Nome = name;
            _qtdNotas = qtdNotas;
            _notas = new double[qtdNotas];
        }

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
            private set { }
        }

        public void InsertNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Informe a " + (i + 1) + "o nota: ");
                _notas[i] += double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for(int i=0; i< _notas.Length; i++)
            {
                total += _notas[i];
            }

            return total/_notas.Length;
        }

    }
}
