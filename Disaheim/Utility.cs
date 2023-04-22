
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook (Book book) 
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet) 
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20.0;
                case Level.high:
                    return 27.5;

                default: return 20.0;
            }
        }

        public double GetValueOfCourse(Course course)
        {
            // 875,00 pr påbegyndt time 

            // 60 min = 1 time
            // 61 min = 2 timer 

            int totalHours = course.DurationInMinutes / 60; 

            if (course.DurationInMinutes % 60 != 0 )
            {
                totalHours++;
            }

            return totalHours * 875.00;
        }

    }
}
