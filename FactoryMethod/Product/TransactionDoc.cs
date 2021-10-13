using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
    public class TransactionDoc : Transaction
    {
        public override bool Validar()
        {
            return false;
        }
    }
}
