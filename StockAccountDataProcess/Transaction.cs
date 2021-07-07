using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccountDataProcess
{
    class Transaction
    {
        public List<TransactionList> Transaction_List;

        public class TransactionList
        {
            public string CustomerId;
            public string StockName;
            public string UserName;
            public int Buys;
            public int Sell;
            public int ShareValue;
        }
    }
}
