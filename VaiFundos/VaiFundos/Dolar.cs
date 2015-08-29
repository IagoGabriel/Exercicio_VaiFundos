using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Dolar : Moeda
    {
        private float iof=0.01f;

        public Dolar(int increment, String nomeMoeda, String simbolo) : base(increment, nomeMoeda, simbolo)
        {
            List<int> notas = new List<int>();
            notas.Add(100);
            notas.Add(50);
            notas.Add(20);
            notas.Add(10);
            notas.Add(5);
            notas.Add(2);
            notas.Add(1);
            this.notas = notas;
        }

        public float getIOF()
        {
            return iof;
        }


    }
}
