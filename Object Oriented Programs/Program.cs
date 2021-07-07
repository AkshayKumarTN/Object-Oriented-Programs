using System;

namespace Object_Oriented_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Object Oriented Programs");
            bool alive = true;
            
            while (alive)
            {
                Console.WriteLine("\n1.Inventory Management\n2.Stock Management\n0.Exit\nEnter your option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.JsonDeserialize();
                        break;
                    case 2:
                        Stock stock = new Stock();
                        stock.Stock_Management();
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
