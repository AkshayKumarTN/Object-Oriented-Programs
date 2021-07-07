using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace StockAccountDataProcess
{
    class StockManagement
    {
       
        public void BuyStocks(CustomerRecords customerRecords)
        {
            StockManagement management = new StockManagement();
            management.ViewCustomerRecords();
            Console.Write("Enter the Customer ID for Buying Stocks : ");
            string id= Convert.ToString(Console.ReadLine());
            CustomerRecords.Records marked= new CustomerRecords.Records();
            foreach (CustomerRecords.Records customer in customerRecords.Customer_Records)
            {
                if (customer.CustomerId == id)
                {
                    marked = customer;
                    break;
                }
            }
            Console.WriteLine(marked.UserName);
            StockAccount stockAccount = JsonConvert.DeserializeObject<StockAccount>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\StockAccount.json"));
            management.ViewStocks();
            Console.Write("Enter the Name of the Stocks for Buying  : ");
            string buyingStock = Convert.ToString(Console.ReadLine());
            StockAccount.Records stockName = new StockAccount.Records();
            foreach (StockAccount.Records stock in stockAccount.Company_Records)
            {
                if (stock.Symbol==buyingStock)
                {
                    stockName = stock;
                    break;
                }
            }
            Console.Write("Enter the Number of Shares you wish to Buy : ");
            int numberOfShares = Convert.ToInt32(Console.ReadLine());
            if(numberOfShares<=stockName.NumberOfShares)
            {
                int cost = numberOfShares * stockName.StockPrice;
                if (cost <= marked.Balance)
                {
                    Console.Write("Enter to proceed (Y/N) : ");
                   char proceed = Console.ReadLine()[0];
                    if (proceed=='Y'||proceed=='y')
                    {
                        marked.Balance -= cost;
                        stockName.NumberOfShares -= numberOfShares;
                        marked.TotalShares += numberOfShares;
                        marked.StockDetails[buyingStock] += numberOfShares;
                        Transaction.TransactionList newObj = new Transaction.TransactionList();
                        newObj.CustomerId = marked.CustomerId;
                        newObj.StockName = stockName.Symbol;
                        newObj.UserName = marked.UserName;
                        newObj.Sell = 0;
                        newObj.Buys = numberOfShares;
                        newObj.ShareValue = (numberOfShares * stockName.StockPrice);
                        Transaction transaction = JsonConvert.DeserializeObject<Transaction>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\Transaction.json"));
                        transaction.Transaction_List.Add(newObj);
                        File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\CustomerRecords.json", JsonConvert.SerializeObject(customerRecords));
                        File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\StockAccount.json", JsonConvert.SerializeObject(stockAccount));
                        File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\Transaction.json", JsonConvert.SerializeObject(transaction));
                        Console.WriteLine(" Stock is Buyed Sucessfully");
                    }
                   else
                      Console.WriteLine("  Transaction Fail....");
                }
                else
                    Console.WriteLine("\n Balance is Too Low");
            }
            else
                 Console.WriteLine("\n Number of Shares of "+stockName.Symbol+" is Too Low");

        }
        public void SellStocks(CustomerRecords customerRecords)
        {
            StockManagement management = new StockManagement();
            management.ViewCustomerRecords();
            Console.Write("Enter the Customer ID for Selling Stocks : ");
            string id = Convert.ToString(Console.ReadLine());
            CustomerRecords.Records marked = new CustomerRecords.Records();
            foreach (CustomerRecords.Records customer in customerRecords.Customer_Records)
            {
                if (customer.CustomerId == id)
                {
                    marked = customer;
                    break;
                }
            }
            Console.WriteLine(marked.UserName);
            StockAccount stockAccount = JsonConvert.DeserializeObject<StockAccount>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\StockAccount.json"));
            management.ViewStocks();
            Console.Write("Enter the Name of the Stocks for Selling  : ");
            string buyingStock = Convert.ToString(Console.ReadLine());
            StockAccount.Records stockName = new StockAccount.Records();
            foreach (StockAccount.Records stock in stockAccount.Company_Records)
            {
                if (stock.Symbol == buyingStock)
                {
                    stockName = stock;
                    break;
                }
            }
            Console.Write("Enter the Number of Shares you wish to Sell : ");
            int numberOfShares = Convert.ToInt32(Console.ReadLine());
            if (numberOfShares <= marked.StockDetails[buyingStock])
            {
                int cost = numberOfShares * marked.StockDetails[buyingStock];
                if (true)
                {
                    Console.Write("Enter to proceed (Y/N) : ");
                    char proceed = Console.ReadLine()[0];
                    if (proceed == 'Y' || proceed == 'y')
                    {
                        marked.Balance += cost;
                        stockName.NumberOfShares += numberOfShares;
                        marked.TotalShares -= numberOfShares;
                        marked.StockDetails[buyingStock] -= numberOfShares;
                        Transaction.TransactionList newObj = new Transaction.TransactionList();
                        newObj.CustomerId = marked.CustomerId;
                        newObj.StockName = stockName.Symbol;
                        newObj.UserName = marked.UserName;
                        newObj.Sell = 0;
                        newObj.Buys = numberOfShares;
                        newObj.ShareValue = (numberOfShares * stockName.StockPrice);
                        Transaction transaction = JsonConvert.DeserializeObject<Transaction>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\Transaction.json"));
                        transaction.Transaction_List.Add(newObj);
                        File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\CustomerRecords.json", JsonConvert.SerializeObject(customerRecords));
                        File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\StockAccount.json", JsonConvert.SerializeObject(stockAccount));
                        File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\Transaction.json", JsonConvert.SerializeObject(transaction));
                        Console.WriteLine(" Stock is Sold Sucessfully");
                    }
                    else
                        Console.WriteLine("  Transaction Fail....");
                }
            }
            else
                 Console.WriteLine("\n Number of Shares is Too High");
        }
        public void ViewStocks()
        {
            StockAccount stockAccount = JsonConvert.DeserializeObject<StockAccount>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\StockAccount.json"));
            foreach (StockAccount.Records stock in stockAccount.Company_Records)
            {
                Console.WriteLine("\nStock Name : " + stock.Symbol + "\nNumber Of Shares : " + stock.NumberOfShares+ "\nStock Price : " + stock.StockPrice + "\nStock Value : " + stock.StockValue);
            }
            Console.WriteLine();

        }
        public void ViewCustomerRecords()
        {
            CustomerRecords customerRecords = JsonConvert.DeserializeObject<CustomerRecords>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\CustomerRecords.json"));
            foreach (CustomerRecords.Records customer in customerRecords.Customer_Records)
            {
                Console.WriteLine("\nCustomer Id : " + customer.CustomerId + "\nUserName : " + customer.UserName + "\nTotal Shares : " + customer.TotalShares + "\nBalance : " + customer.Balance);
            }
            Console.WriteLine();

        }
        public void ViewTransactions()
        {
            Console.WriteLine("\n  Transactions ");
            Transaction transaction = JsonConvert.DeserializeObject<Transaction>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\StockAccountDataProcess\Transaction.json"));
            foreach(Transaction.TransactionList transactionList in transaction.Transaction_List)
            {
                Console.WriteLine("\nCustomer Id : " + transactionList.CustomerId);
                Console.WriteLine("StockName : " + transactionList.StockName);
                Console.WriteLine("UserName :" + transactionList.UserName);
                Console.WriteLine("Sell: " + transactionList.Sell);
                Console.WriteLine("Buys : " + transactionList.Buys);
                Console.WriteLine("ShareValue : " + transactionList.ShareValue);

            }
        }
    }
}
