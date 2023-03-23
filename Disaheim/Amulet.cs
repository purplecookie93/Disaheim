using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        
        public string Design { get; set; }

        public Level Quality { get; set; }

        public Amulet(string itemId) : base(itemId) 
        {
             
            this.ItemId = itemId;
            this.Quality = Level.medium; 
            this.Design = "";
        }

        public Amulet(string itemId, Level quality) : base(itemId)
        {
            this.ItemId = itemId;
            this.Quality = quality; 
        }

        public Amulet(string itemId, Level quality, string design) : base(itemId)
        {
           this.ItemId = itemId;
           this.Quality = quality;
           this.Design = design;
        }

        
       

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
