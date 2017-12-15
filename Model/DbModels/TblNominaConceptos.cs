using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblNominaConceptos
    {
        public int IdConceptos { get; set; }
        public int? IdNomina { get; set; }
        public string Tipo { get; set; }
        public string Concepto { get; set; }
        public string ClavePropia { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteExento { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Retencion { get; set; }
        public string Referencia { get; set; }

        public TblNomina IdNominaNavigation { get; set; }
    }
}
