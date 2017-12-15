using poc1.Model;
using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblCatafopa
    {
        public TblCatafopa()
        {
            Meses = new List<Mes>();
        }
        int IdVacation { get; set; }
        int Days { get; set; }
        List<Mes> Meses { get; set; }
        public int IdFormapago { get; set; }
    
    }
}
