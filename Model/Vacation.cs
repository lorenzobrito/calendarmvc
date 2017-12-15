using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace poc1.Model
{
    public class Vacation
    {
        [Key]
        int IdVacation { get; set; }
        int Days { get; set; }
        List<Mes> Meses {get;set;}
    }
}
