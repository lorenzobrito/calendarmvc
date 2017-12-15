using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblNominaTotales
    {
        public int IdTotales { get; set; }
        public int IdNomina { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? ImporteReal { get; set; }
        public decimal? Iva { get; set; }
        public decimal? RetencionIva { get; set; }
        public decimal? RetencionIsr { get; set; }
        public decimal? Total { get; set; }
        public decimal? Otro { get; set; }

        public TblNomina IdNominaNavigation { get; set; }
    }
}
