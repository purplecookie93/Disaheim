using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository : Utility
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name) 
        { 
            foreach (Course course in courses)
            {
                if (course.Name == name)
                {
                    return course;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Course course in courses) 
            {
                total += GetValueOfCourse(course); 
            }
            return total;
        }
    }
}
