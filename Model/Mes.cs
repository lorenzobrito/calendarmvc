using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc1.Model
{
    public class Mes
    {
        public String Name { get; set; }
        public List<Dia> Dias { get; set; }

        public bool AddDay(Dia dia)
        {
            Dias.Add(dia);
            return true;
        }
    }
}
