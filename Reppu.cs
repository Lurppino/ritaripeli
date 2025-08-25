using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
    internal class Reppu
    {
        private List<Tavara> tavarat;

        public Reppu()
        {
            tavarat = new List<Tavara>();
        }

        public void AddItem(Tavara tavara)
        {
            tavarat.Add(tavara);
        }

        public void RemoveItem(Tavara tavara)
        {
            tavarat.Remove(tavara);
        }

        public List<Tavara> ReturnItem()
        {
            return tavarat;
        }

        public void ShowInventory()
        {
            if (tavarat.Count == 0)
            {
                Console.WriteLine("Reppu on tyhjä.");
            }
            else
            {
                Console.WriteLine("Repussa on:");
                for (int i = 0; i < tavarat.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {tavarat[i].ToString()}");
                }
            }
        }
    }
}