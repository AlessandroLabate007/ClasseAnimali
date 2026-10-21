using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal enum TipoAnimale
    {
        Cane, Gatto, Corvo, Maiale, Canguro, 
    }

    internal class FactoryAnimale
    {

        public static CAnimale Crea(TipoAnimale tipo, string nome, int eta)
        {
            CAnimale animale = tipo switch
            {
                TipoAnimale.Cane => new CCane(eta, 0, nome),
                TipoAnimale.Gatto => new CGatto(eta, 0, nome),
                TipoAnimale.Corvo => new CUccello(eta, 0, nome),
                _ => throw new ArgumentOutOfRangeException(nameof(tipo), tipo, "Tipo di animale non supportato")
            };

            FileLogger.Instance.Log($"Animale creato dalla Factory: {tipo} (Nome: {nome}, Età: {eta})");
            return animale;
        }

    }
}