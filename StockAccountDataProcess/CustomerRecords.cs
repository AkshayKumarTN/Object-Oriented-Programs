using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccountDataProcess
{
    class CustomerRecords
    {
        public List<Records> Customer_Records;

        public class Records
        {
            public string CustomerId;
            public string UserName;
            public Dictionary<string, int> StockDetails = new Dictionary<string, int>() { { "RELIANCE", 0 }, { "TCS", 0 }, { "ICICIBANK", 0 }, { "INFOSYS", 0 }, { "TATA", 0 } };
            public int TotalShares;
            public int Balance;
        }
    }
}
