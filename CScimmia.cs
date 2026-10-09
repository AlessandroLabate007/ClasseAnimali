using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CScimmia : CAnimale
    {
        public CScimmia(int eta, int energia, string nome) : base(eta, energia, nome) { }
        public override string Verso()
        {
            return "HuHaHaHaHa";
        }

        public override string ToString()
        {
            return $"Eta della scimmia {base.eta}, energia {base.energia}, e il suo nome e' {base.nome}";
        }
    }
}
