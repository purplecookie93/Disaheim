using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
   public abstract class Merchandise : IValuable
    {
        // Der ligger en default constructor "bagved"

        public string ItemId { get; set; }

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
