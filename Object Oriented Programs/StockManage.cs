using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programs
{
    class StockManage
    {
        public List<StockRecords> Stocks;

        public class StockRecords
        {
            public string stockNames;
            public int numberOfShare;
            public int sharePrice;
        }
    }
}
