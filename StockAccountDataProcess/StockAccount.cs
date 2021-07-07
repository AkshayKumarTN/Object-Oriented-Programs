using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccountDataProcess
{
    class StockAccount
    {
        public List<Records> Company_Records;

        public class Records
        {
            public string Symbol;
            public int NumberOfShares;
            public string DateTime;
            public int StockValue;
            public int StockPrice;
        }
    }
}
