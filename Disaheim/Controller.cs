using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        private CourseRepository courseRepository;
        private MerchandiseRepository merchandiseRepository;
        


        public Controller()
        {
            merchandiseRepository = new MerchandiseRepository();
            courseRepository = new CourseRepository();
        }

        public void AddToList(Book book)
        {
            merchandiseRepository.AddMerchandise(book);
        }

        public void AddToList(Amulet amulet)
        {
            merchandiseRepository.AddMerchandise(amulet);
        }

        public void AddToList(Course course)
        { 
            courseRepository.AddCourse(course);
        }
    }
}
