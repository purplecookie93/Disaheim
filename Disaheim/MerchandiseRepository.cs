using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository : Utility
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            foreach (Merchandise merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId) return merchandise;
            }
            return null;
        }

        //public double GetTotalValue()
        //{
        //    double total = 0;
        //    foreach (Merchandise merchandise in merchandises)
        //    {
        //        total += GetValueOfMerchandise(merchandise);
        //    }
        //    return total;
        //}

       
    }
}
