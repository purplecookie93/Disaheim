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
        private BookRepository bookRepository;
        private AmuletRepository amuletRepository;


        public Controller()
        {
            bookRepository = new BookRepository();
            amuletRepository = new AmuletRepository();
            courseRepository = new CourseRepository();
        }

        public void AddToList(Book book)
        {
            bookRepository.AddBook(book);
        }

        public void AddToList(Amulet amulet)
        {
            amuletRepository.AddAmulet(amulet);
        }

        public void AddToList(Course course)
        { 
            courseRepository.AddCourse(course);
        }
    }
}
