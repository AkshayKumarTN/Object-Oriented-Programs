using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Object_Oriented_Programs
{
    class Inventory
    {
        public void JsonDeserialize()
        {
            InventoryManager inventoryManager = new InventoryManager();
            InventoryUtility items = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json"));

            bool alive = true;
            while (alive)
            {
                Console.WriteLine("\n1. Display Inventory\n2. Add to Inventory\n3. Remove from Inventory\n4. Update Inventory\n0. Exit");
                Console.Write("\nEnter your Option : ");
                int option1 = Convert.ToInt32(Console.ReadLine());
                switch (option1)
                {
                    case 1:
                        Console.WriteLine("\n1.Rice\n2.Pulse\n3.Wheats");
                        Console.Write("\nEnter your Option : ");
                        int Option2 = Convert.ToInt32(Console.ReadLine());
                        switch (Option2)
                        {
                            case 1:
                                // List of Rice is Displayed from Inventory...
                                inventoryManager.DisplayInventory(items.RiceList);
                                break;
                            case 2:
                                // List of pulses is Displayed from Inventory...
                                inventoryManager.DisplayInventory(items.PulseList);
                                break;
                            case 3:
                                // List of wheat is Displayed from Inventory... 
                                inventoryManager.DisplayInventory(items.WheatsList);
                                break;
                            default:
                                Console.WriteLine(" Invalid Input ");
                                break;

                        }
                        break;
                    case 2:
                         Console.WriteLine("\n1. Add Record to Rice\n2. Add Record to pulse\n3. Add Record to wheat\nEnter your Option:");
                        int optionOne = Convert.ToInt32(Console.ReadLine());
                        switch (optionOne)
                        {
                            case 1:
                                // Adding Item to Inventory......
                                items.RiceList = inventoryManager.AddToInventory(items.RiceList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            case 2:
                                // Adding Item to Inventory.......
                                items.PulseList = inventoryManager.AddToInventory(items.PulseList);
                                //Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            case 3:
                                // Adding Item to Inventory........
                                items.WheatsList = inventoryManager.AddToInventory(items.WheatsList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            default:
                                Console.WriteLine(" Invalid Input ");
                                break;
                        }
                        break;
                    case 3:
                        // options
                        Console.WriteLine("\n1. remove Record from Rice\n2. remove Record from pulse\n3. remove Record from wheat\nEnter your Option:");
                        int optionTwo = Convert.ToInt32(Console.ReadLine());
                        switch (optionTwo)
                        {
                            case 1:
                                //  List of Rice is Displayed from Inventory...
                                inventoryManager.DisplayInventory(items.RiceList);
                                // Removing Item from Inventory.......
                                items.RiceList = inventoryManager.RemoveFromInventory(items.RiceList);
                                // uUpdating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            case 2:
                                // List of pulses is Displayed from Inventory...
                                inventoryManager.DisplayInventory(items.PulseList);
                                // Removing Item from Inventory.......
                                items.PulseList = inventoryManager.RemoveFromInventory(items.PulseList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            case 3:
                                // List of wheat is Displayed from Inventory... 
                                inventoryManager.DisplayInventory(items.WheatsList);
                                // Removing Item from Inventory.......
                                items.WheatsList = inventoryManager.RemoveFromInventory(items.WheatsList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            default:
                                Console.WriteLine(" Invalid Input ");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n1. Update Record to Rice\n2. Update Record to pulse\n3. Update Record to wheat\nEnter your Option:");
                        int optionThree = Convert.ToInt32(Console.ReadLine());
                        switch (optionThree)
                        {
                            case 1:
                                // List of Rice is Displayed from Inventory...
                                inventoryManager.DisplayInventory(items.RiceList);
                                // Updating Item from a List.....
                                items.RiceList = inventoryManager.UpdateToInventory(items.RiceList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            case 2:
                                // List of pulses is Displayed from Inventory...
                                inventoryManager.DisplayInventory(items.PulseList);
                                // Updating Item from a List.....
                                items.PulseList = inventoryManager.UpdateToInventory(items.PulseList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            case 3:
                                // List of wheat is Displayed from Inventory... 
                                inventoryManager.DisplayInventory(items.WheatsList);
                                // Updating Item from a List.....
                                items.WheatsList = inventoryManager.UpdateToInventory(items.WheatsList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"C:\Users\Admin\source\repos\Object Oriented Programs\Object Oriented Programs\jsonInventory.json", JsonConvert.SerializeObject(items));
                                break;
                            default:
                                Console.WriteLine(" Invalid Input ");
                                break;
                        }
                        break;
                    case 0:
                        alive = false;
                        break;
                    default:
                        Console.WriteLine(" Invalid Input ");
                        break;

                }
            }
        }
    }
}
