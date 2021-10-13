using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class TransactionFactory
    {
        public abstract Transaction CreateTransaction();

        public static TransactionFactory ChooseFactory(TransactionType transactionType)
        {
            return transactionType switch
            {
                TransactionType.TED => new TransactionTedFactory(),
                TransactionType.DOC => new TransactionDocFactory(),
                _ => null
            };
        }
    }
}
