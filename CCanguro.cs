using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CCanguro : CAnimale
    {
        public CCanguro(int eta, int energia, string nome) : base(eta, energia, nome) { }
        public override string Verso()
        {
            return "rrrr";
        }

        public override string ToString()
        {
            return $"Eta del canguro {base.eta}, energia {base.energia}, e il suo nome e' {base.nome}";
        }
    }
}
