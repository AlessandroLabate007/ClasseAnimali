using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CLeone : CAnimale
    {
        public CLeone(int eta, int energia, string nome) : base(eta, energia, nome) { }
        public override string Verso()
        {
            return "ROAR!";
        }

        public override string ToString()
        {
            return $"Eta del leone {base.eta}, energia {base.energia}, e il suo nome e' {base.nome}";
        }
    }
}
