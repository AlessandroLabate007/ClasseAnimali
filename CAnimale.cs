using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal class CAnimale
    {
        private int _eta;
        private int _energia;
        private string _nome;

        public CAnimale()
        {
            _eta = 0;
            _energia = 0;
            _nome = string.Empty;
        }

        public CAnimale(int eta, int energia, string nome)
        {
            _eta = eta;
            _energia = energia;
            _nome = nome;
        }

        public int eta
        {
            get { return _eta; }
            set { _eta = value; }
        }

        public int energia
        {
            get { return _energia; }
            set { _energia = value; }
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public virtual string Verso()
        {
            return "";
        }
    }
}
