﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Imposto
    {
        private double iof;
        private double irrf;

        public Imposto(double iof, double irrf)
        {
            this.iof = iof;
            this.irrf = irrf;
        }

        public double getIof()
        {
            return iof;
        }

        public void setIof(double iof)
        {
            this.iof = iof;
        }


        public double getIrrf()
        {
            return irrf;

        }

        public void setIrrf(double irff)
        {

            this.irrf = irrf;
        }


        public static void desconto(double resgate, double irrf, double iof, int codMoeda)
        {

            if(codMoeda == 1)
            {
                resgate = resgate - (resgate * 0.1);
            }

        }

    }
}
