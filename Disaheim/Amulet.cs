using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    internal class Amulet
    {
        public string ItemId { get; set; }
        public string Design { get; set; }

        public Enum.Level Quality { get; set; }

    }
}
