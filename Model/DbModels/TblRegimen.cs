using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblRegimen
    {
        public int IdEmpresa { get; set; }
        public int? Idregimen { get; set; }

        public TblCatRegimen IdregimenNavigation { get; set; }
    }
}
