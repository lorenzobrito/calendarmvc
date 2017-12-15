using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblMoneda
    {
        public TblMoneda()
        {
            TblFacturas = new HashSet<TblFacturas>();
        }

        public int IdTipomone { get; set; }
        public string Tipomone { get; set; }
        public string Codmone { get; set; }
        public string Nombmone { get; set; }
        public decimal Valormone { get; set; }

        public ICollection<TblFacturas> TblFacturas { get; set; }
    }
}
