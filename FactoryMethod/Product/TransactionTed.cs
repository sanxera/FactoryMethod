using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TransactionTed : Transaction
    {
        public override bool Validar()
        {
            return true;
        }
    }
}
