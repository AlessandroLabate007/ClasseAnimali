using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CUccello : CAnimale
    {
        public CUccello(int eta, int energia, string nome) : base(eta, energia, nome) { }
        public override string Verso()
        {
            return "COCO!";
        }

        public override string ToString()
        {
            return $"Eta del corvo {base.eta}, energia {base.energia}, e il suo nome e' {base.nome}";
        }
    }
}
