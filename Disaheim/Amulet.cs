using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        static double LowQualityValue = 12.5;
        static double MediumQualityValue = 20.0;
        static double HighQualityValue = 27.5;
        
        public string Design { get; set; }

        public Level Quality { get; set; }

        public Amulet(string itemId)
        {
             
            this.ItemId = itemId;
            this.Quality = Level.medium; 
            this.Design = "";
        }

        public Amulet(string itemId, Level quality)
        {
            this.ItemId = itemId;
            this.Quality = quality; 
        }

        public Amulet(string itemId, Level quality, string design)
        {
           this.ItemId = itemId;
           this.Quality = quality;
           this.Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.low:
                    return LowQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                case Level.high:
                    return HighQualityValue;

                default: return MediumQualityValue;
            }
        }
    }
}
