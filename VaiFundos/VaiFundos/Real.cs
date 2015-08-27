using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Real : Moeda 
    {
        private string cod_iso;
        private string titulo_moeda;


        public Real(string cod_iso, string titulo_moeda)
        {

            this.cod_iso = cod_iso;
            this.titulo_moeda = titulo_moeda;
            

        }

        public string getCod_iso()
        {
            return cod_iso;
        }

        public void setCod_iso(string cod_iso)
        {
            this.cod_iso = cod_iso;
        }

        public string getTitulo_moeda()
        {
            return titulo_moeda;
        }

        public void setTituloMoeda(string titulo_moeda)
        {
            this.titulo_moeda = titulo_moeda;
        }
    }
}
