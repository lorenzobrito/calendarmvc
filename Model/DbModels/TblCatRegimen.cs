using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblCatRegimen
    {
        public TblCatRegimen()
        {
            TblRegimen = new HashSet<TblRegimen>();
        }

        public int Idregimen { get; set; }
        public string Clave { get; set; }
        public string Descripcio { get; set; }

        public ICollection<TblRegimen> TblRegimen { get; set; }
    }
}
