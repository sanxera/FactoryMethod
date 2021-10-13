using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Transaction
    {
        public int Agencia { get; set; }

        public abstract bool Validar();
    }
}
