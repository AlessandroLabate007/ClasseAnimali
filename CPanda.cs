using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CPanda : CAnimale
    {
        public CPanda(int eta, int energia, string nome) : base(eta, energia, nome) { }
        public override string Verso()
        {
            return "AHhhhh";
        }

        public override string ToString()
        {
            return $"Eta del panda {base.eta}, energia {base.energia}, e il suo nome e' {base.nome}";
        }
    }
}
