using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    internal class Pack
    {
        private InventoryItem[] _itens;
        public int Total { get; }
        public float MaxWeight { get; }
        public float MaxVolume { get; }

        public int CurrentTotal { get; private set; }
        public float CurrentWeight { get; private set; }
        public float CurrentVolume { get; private set; }
        public Pack(int total, float maxWeight, float maxVolume)
        {
            Total = total;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;

            _itens = new InventoryItem[total];
        }

        public bool Add(InventoryItem item)
        {
            if (CurrentTotal >= Total || CurrentWeight >= MaxWeight || CurrentVolume >= MaxVolume) 
            {
                Console.WriteLine("Could not add this to the pack.");
                return false;
            }
            
            _itens[CurrentTotal] = item;
            CurrentTotal++;
            CurrentWeight += item.Weight;
            CurrentVolume += item.Volume;
            return true;
        }

        public override string ToString()
        {
            string contents = "Pack containing ";

            if (CurrentTotal == 0) contents += "Nothing";

            for (int i = 0; i < CurrentTotal; i++)
                contents += _itens[i].ToString() + " ";

            return contents;
        }
    }
}
