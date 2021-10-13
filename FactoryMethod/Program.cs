using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ted = TransactionFactory.ChooseFactory(TransactionType.TED).CreateTransaction().Validar();

            var doc = TransactionFactory.ChooseFactory(TransactionType.DOC).CreateTransaction().Validar();
        }
    }
}
