using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Product;

namespace FactoryMethod
{
    public class TransactionTedFactory : TransactionFactory
    {
        public override Transaction CreateTransaction()
        {
            return new TransactionTed();
        }
    }
}
