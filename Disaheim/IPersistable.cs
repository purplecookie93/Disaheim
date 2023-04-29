using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Disaheim
{
    public interface IPersistable
    {
        public void Save(string fileName = "ValuableRepository.txt");
        public void Load(string fileName = "ValuableRepository.txt");
    }
}
