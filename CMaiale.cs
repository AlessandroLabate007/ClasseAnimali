using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CMaiale : CAnimale
    {
        public CMaiale(int eta, int energia, string nome) : base(eta, energia, nome) { }
        public override string Verso()
        {
            return "pig";
        }

        public override string ToString()
        {
            return $"Eta del maiale {base.eta}, energia {base.energia}, e il suo nome e' {base.nome}";
        }
    }
}
