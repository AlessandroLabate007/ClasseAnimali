using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CParrot : CAnimale
    {
        public CParrot(int eta, int energia, string nome) : base(eta, energia, nome) { }
        public override string Verso()
        {
            return "GnGn";
        }

        public override string ToString()
        {
            return $"Eta del pappagallo {base.eta}, energia {base.energia}, e il suo nome e' {base.nome}";
        }
    }
}
