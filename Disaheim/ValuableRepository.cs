using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable (IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise && (valuable as Merchandise).ItemId == id)
                    return valuable;
                else if (valuable is Course && (valuable as Course).Name == id)
                    return valuable;
            }
            return null;
        }

        public double GetTotalValue() 
        {
            double total = 0;
            foreach (IValuable valuable in valuables)
            {
                total += valuable.GetValue();
            }
            return total;
        }

        public int Count() 
        { 
            return valuables.Count; 
        }

        public void Save(string fileName = "ValuableRepository.txt")
        {
            StreamWriter sw = new StreamWriter(fileName, false);

            foreach (IValuable valuable in valuables)
            {
                if(valuable is Book) {
                    sw.Write($"Book;{(valuable as Book).ItemId};{(valuable as Book).Title};{valuable.GetValue()}\n");
                }
                if (valuable is Amulet)
                {
                    sw.Write($"Amulet;{(valuable as Amulet).ItemId};{(valuable as Amulet).Quality};{(valuable as Amulet).Design}\n");
                }
                if (valuable is Course)
                {
                    sw.Write($"Course;{(valuable as Course).Name};{(valuable as Course).DurationInMinutes}\n");
                }
            }

            sw.Close();
        }

        public void Load(string fileName = "ValuableRepository.txt")
        {
            string line;

            StreamReader sr = new StreamReader(fileName);
            line = sr.ReadLine();

            while (line != null)
            {
                string[] data = line.Split(";");

                if (data.Length > 0)
                {
                    switch (data[0])
                    {
                        case "Book":
                            Book book = new Book(data[1], data[2], double.Parse(data[3]));
                            AddValuable(book);
                            break;
                        case "Amulet":
                            Enum.TryParse(data[2], out Level myStatus);
                            Amulet amulet = new Amulet(data[1], myStatus, data[3]);
                            AddValuable(amulet);
                            break;
                        case "Course":
                            Course course = new Course(data[1], int.Parse(data[2]));
                            AddValuable(course);
                            break;
                    }
                }

                //Read the next line
                line = sr.ReadLine();
            }

            sr.Close();
        }
    }
}
