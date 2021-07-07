using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Object_Oriented_Programs
{
    class Stock
    {
        StockManage manage = JsonConvert.DeserializeObject<StockManage>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\Stocks.json"));
        public void Stock_Management()
        {
            bool alive = true;
            Stock stock = new Stock();
            while (alive)
            {
                Console.WriteLine("\n1.Display Stocks\n2.Calculate Each Value Stock \n3.Calculate Total Value Stocks\n0.Exit\nEnter your option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stock.DisplayStocks();
                        break;
                    case 2:
                        stock.CalculateEachValue();
                        break;
                    case 3:
                        stock.CalculateTotalValue();
                        break;

                    case 0:
                        alive = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Output!!");
                        break;

                }
            }

        }
        public void DisplayStocks()
        {
            string stockRecord = string.Empty;
            foreach (StockManage.StockRecords stock in manage.Stocks)
            {
                stockRecord += "\nStock Name : " + stock.stockNames + "\nTotal Number Of Share : " + stock.numberOfShare + "\nStock Price : " + stock.sharePrice + "\n";
            }
            Console.WriteLine(stockRecord);
        }

        public void CalculateEachValue()
        {
            double value=0;
            Console.WriteLine();
            foreach (StockManage.StockRecords stock in manage.Stocks)
            {
                value=stock.numberOfShare* stock.sharePrice;

                Console.WriteLine("Value of " + stock.stockNames + " is : " + value);
            }
        }

        public void CalculateTotalValue()
        {
            double value=0;
            foreach (StockManage.StockRecords stock in manage.Stocks)
            {
                value += stock.numberOfShare * stock.sharePrice;
    
            }
            Console.WriteLine("\nTotal Value of the Stocks : " + value);
        }
    }
}
