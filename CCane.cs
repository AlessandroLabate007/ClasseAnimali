using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CCane : CAnimale
    {
        public CCane(int eta, int energia, string nome) : base(eta, energia, nome) { }
        public override string Verso()
        {
            return "Bau";
        }

        public override string ToString()
        {
            return $"Eta del cane {base.eta}, energia {base.energia}, e il suo nome e' {base.nome}";
        }
    }
}
