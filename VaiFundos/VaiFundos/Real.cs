using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Real : Moeda 
    {
        private String codISO;
        private String tituloMoeda;
        
        public Real(String codISO, String tituloMoeda, int increment, float valorMoeda, float inflacao, String usadoPais, String simbolo) : base(increment, valorMoeda, inflacao, usadoPais, simbolo)
        {
            this.codISO = codISO;
            this.tituloMoeda = tituloMoeda;
            List<int> notas = new List<int>();
            notas.Add(100);
            notas.Add(50);
            notas.Add(20);
            notas.Add(10);
            notas.Add(5);
            notas.Add(2);
            this.notas = notas;
        }

        public String getCodISO()
        {
            return codISO;
        }

        public void setCodISO(String codISO)
        {
            this.codISO = codISO;
        }

        public String getTituloMoeda()
        {
            return tituloMoeda;
        }

        public void setTituloMoeda(String tituloMoeda)
        {
            this.tituloMoeda = tituloMoeda;
        }
    }
}
