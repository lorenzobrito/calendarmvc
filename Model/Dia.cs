using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc1.Model
{
    public class Dia
    {
        public DateTime Day { get; set; }
        public int DiadelMes { get { return Day.Day; } }
        public int Mes { get { return Day.Month; } }
        public bool isVacation { get; set; }
    }
}
