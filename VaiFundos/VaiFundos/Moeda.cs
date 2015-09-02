using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Moeda
    {
        private int codMoeda;
        protected String simbolo;
        private String nomeMoeda;
        protected List<int> notas = new List<int>();

        public Moeda(int increment, String nomeMoeda, String simbolo) 
        {
            this.codMoeda = increment + 1;
            this.simbolo = simbolo;
            this.nomeMoeda = nomeMoeda;
        }

        public int getCodMoeda()
        {
            return codMoeda;
        }

        public String getSimbolo()
        {
            return simbolo;
        }
        
        public void setSimbolo(String simbolo)
        {
            this.simbolo = simbolo;
        }

        public String getNomeMoeda()
        {
            return nomeMoeda;
        }

        public void setNomeMoeda(String nomeMoeda)
        {
            this.nomeMoeda = nomeMoeda;
        }

        public List<int> getNotas()
        {
            return notas;
        }

        public virtual float getIOF()
        {
            return 0;
        }

        public virtual float getIRRF()
        {
            return 0;
        }


    }
}

