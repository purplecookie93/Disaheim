using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {

        public string Title { get; set; }

        public double Price { get; set; }   

        public Book (string itemId, string title, double price)
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }

        public Book (string itemId, string title)
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = 0; 
        }

        public Book (string itemId)
        { 
            this.ItemId = itemId;
            this.Title = "";
            this.Price = 0; 
        }

        public override string ToString() 
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }

    }
}
