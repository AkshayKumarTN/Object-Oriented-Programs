using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programs
{
    class InventoryManager
    {
        
        public List<InventoryUtility.Rice> AddToInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice item = new InventoryUtility.Rice();

            Console.Write("Enter Name of Rice : ");
            item.Name = Console.ReadLine();
            Console.Write("Enter price of Rice : ");
            item.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter weight in kg of Rice : ");
            item.Kg = Convert.ToInt32(Console.ReadLine());

            riceList.Add(item);
            Console.WriteLine("\n" + item.Name + " Rice Added Successfully");
            // Returns the List Of Rice.......
            return riceList;
        }
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulseList)
        {
            InventoryUtility.Pulse item = new InventoryUtility.Pulse();

            Console.Write("Enter Name of Pulse : ");
            item.Name = Console.ReadLine();
            Console.Write("Enter price of Pulse : ");
            item.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter weight in kg of Pulse : ");
            item.Kg = Convert.ToInt32(Console.ReadLine());

            pulseList.Add(item);
            Console.WriteLine("\n" + item.Name + " Pulse Added Successfully");
            // Returns the List Of Pulse.......
            return pulseList;
        }
        public List<InventoryUtility.Wheat> AddToInventory(List<InventoryUtility.Wheat> wheatList)
        {
            InventoryUtility.Wheat item = new InventoryUtility.Wheat();

            Console.Write("Enter Name of Wheat : ");
            item.Name = Console.ReadLine();
            Console.Write("Enter price of Wheat : ");
            item.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter weight in kg of Wheat : ");
            item.Kg = Convert.ToInt32(Console.ReadLine());

            wheatList.Add(item);
            Console.WriteLine("\n" + item.Name + " Wheat Added Successfully");
            // Returns the List Of Wheat.......
            return wheatList;
        }
        public List<InventoryUtility.Rice> UpdateToInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice item = new InventoryUtility.Rice();
            Console.Write("Enter Name of Rice to be updated : ");
            string itemName = Console.ReadLine();
            riceList.Remove(riceList.Find(l => l.Name.Equals(itemName)));

            Console.Write("Enter Name of Rice : ");
            item.Name = Console.ReadLine();
            Console.Write("Enter price of Rice : ");
            item.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter weight in kg of Rice : ");
            item.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + itemName + " Rice updated Successfully");

            riceList.Add(item);
            return riceList;
        }

        public List<InventoryUtility.Pulse> UpdateToInventory(List<InventoryUtility.Pulse> PulseList)
        {
            InventoryUtility.Pulse item = new InventoryUtility.Pulse();
            Console.Write("Enter Name of Pulse to be updated : ");
            string itemName = Console.ReadLine();
            PulseList.Remove(PulseList.Find(l => l.Name.Equals(itemName)));

            Console.Write("Enter Name of Pulse : ");
            item.Name = Console.ReadLine();
            Console.Write("Enter price of Pulse : ");
            item.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter weight in kg of Pulse : ");
            item.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + itemName + " Pulse updated Successfully");

            PulseList.Add(item);
            return PulseList;
        }

        public List<InventoryUtility.Wheat> UpdateToInventory(List<InventoryUtility.Wheat> WheatList)
        {
            InventoryUtility.Wheat item = new InventoryUtility.Wheat();
            Console.Write("Enter Name of Wheat to be updated : ");
            string itemName = Console.ReadLine();
            WheatList.Remove(WheatList.Find(l => l.Name.Equals(itemName)));

            Console.Write("Enter Name of Wheat : ");
            item.Name = Console.ReadLine();
            Console.Write("Enter price of Wheat : ");
            item.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter weight in kg of Wheat : ");
            item.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + itemName + " Wheat updated Successfully");

            WheatList.Add(item);
            return WheatList;
        }

        public List<InventoryUtility.Rice> RemoveFromInventory(List<InventoryUtility.Rice> riceList)
        {
            Console.Write("\nEnter Name of Rice to be deleted : ");
            string itemName = Console.ReadLine();
            riceList.Remove(riceList.Find(l => l.Name.Equals(itemName)));
            Console.WriteLine("\n" + itemName + " Rice Deleted Successfully");

            return riceList;

        }
        public List<InventoryUtility.Wheat> RemoveFromInventory(List<InventoryUtility.Wheat> WheatList)
        {
            Console.Write("\nEnter Name of Wheat to be deleted : ");
            string itemName = Console.ReadLine();
            WheatList.Remove(WheatList.Find(l => l.Name.Equals(itemName)));
            Console.WriteLine("\n" + itemName + " Wheat Deleted Successfully");

            return WheatList;

        }
        public List<InventoryUtility.Pulse> RemoveFromInventory(List<InventoryUtility.Pulse> PulseList)
        {
            Console.Write("\nEnter Name of Pulse to be deleted : ");
            string itemName = Console.ReadLine();
            PulseList.Remove(PulseList.Find(l => l.Name.Equals(itemName)));
            Console.WriteLine("\n"+itemName+ " Pulse Deleted Successfully");

            return PulseList;

        }
        public void DisplayInventory(List<InventoryUtility.Rice> riceList)
        {
            int total = 0;
            foreach ( InventoryUtility.Rice item in riceList)
            {
                Console.WriteLine("\n Name of Rice : "+item.Name);
                Console.WriteLine(" Price of Rice : "+item.Price);
                Console.WriteLine(" Weight in kg of Rice : "+item.Kg);
                total += item.Kg * item.Price;
            }
            Console.WriteLine("\nTotal Rice Inventory  cost : " + total);
        }
        public void DisplayInventory(List<InventoryUtility.Pulse> PulseList)
        {
            int total = 0;
            foreach (InventoryUtility.Pulse item in PulseList)
            {
                Console.WriteLine("\n Name of Pulse : " + item.Name);
                Console.WriteLine(" Price of Pulse : " + item.Price);
                Console.WriteLine(" Weight in kg of Pulse : " + item.Kg);
                total += item.Kg * item.Price;
            }
            Console.WriteLine("\nTotal Pulse Inventory cost : " + total);
        }
        public void DisplayInventory(List<InventoryUtility.Wheat> WheatList)
        {
            int total = 0;
            foreach (InventoryUtility.Wheat item in WheatList)
            {
                Console.WriteLine("\n Name of Wheat : " + item.Name);
                Console.WriteLine(" Price of Wheat : " + item.Price);
                Console.WriteLine(" Weight in kg of Wheat : " + item.Kg);
                total += item.Kg*item.Price;
            }
            Console.WriteLine("\nTotal Wheat Inventory cost : " + total);
        }
        
    }
}
