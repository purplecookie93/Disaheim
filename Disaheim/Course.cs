using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }

        public int DurationInMinutes { get; set; }

        static public double CourseHourValue = 875.00;

        public Course(string name, int durationInMinutes) 
        {
            this.Name = name;
            this.DurationInMinutes = durationInMinutes;
        }

        public Course(string name) :
            this(name, 0)
        { }

        public override string ToString() 
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public double GetValue()
        {
            // 875,00 pr påbegyndt time 

            // 60 min = 1 time
            // 61 min = 2 timer 

            int totalHours = DurationInMinutes / 60;

            if (DurationInMinutes % 60 != 0)
            {
                totalHours++;
            }

            return totalHours * CourseHourValue;
        }
    }
}
