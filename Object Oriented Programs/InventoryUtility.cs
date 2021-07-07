using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programs
{
    class InventoryUtility
    {
        public List<Rice> RiceList;
        public List<Pulse> PulseList;
        public List<Wheat> WheatsList;
        public class Rice
        {
            public string Name;
            public int Price;
            public int Kg;
        }
        public class Pulse
        {
            public string Name;
            public int Price;
            public int Kg;
        }
        public class Wheat
        {
            public string Name;
            public int Price;
            public int Kg;
        }


    }
}
