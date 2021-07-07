using System;
using System.IO;
using Newtonsoft.Json;

namespace StockAccountDataProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Stock Exchange\n");
            Console.WriteLine(" Customer Records\n");
            bool alive = true;
            while (alive)
            {
                CustomerRecords customerRecords = JsonConvert.DeserializeObject<CustomerRecords>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\CustomerRecords.json"));
                StockAccount stockAccount = JsonConvert.DeserializeObject<StockAccount>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\StockAccount.json"));
                Console.WriteLine("\n1.Buy Stocks\n2.Sell Stocks\n3.View Stocks\n4.View Customer Records\n5.ViewTransactions\n0.Exit\nEnter your option:");
                int option = Convert.ToInt32(Console.ReadLine());
                StockManagement stockManagement = new StockManagement();
                switch (option)
                {
                    case 1:
                        stockManagement.BuyStocks(customerRecords);
                        break;
                    case 2:
                        stockManagement.SellStocks(customerRecords);
                        break;
                    case 3:
                        stockManagement.ViewStocks();
                        break;
                    case 4:
                        stockManagement.ViewCustomerRecords();
                        break;
                    case 5:
                        stockManagement.ViewTransactions();
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
    }
}
