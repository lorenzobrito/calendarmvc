using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblNominaComprobante
    {
        public int IdComprobante { get; set; }
        public int IdNomina { get; set; }
        public string Folio { get; set; }
        public string Serie { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public DateTime? FechaPago { get; set; }
        public int? Dias { get; set; }
        public string Hora { get; set; }
        public string Comprobante { get; set; }
        public int? IdMoneda { get; set; }
        public decimal? TipoDeCambio { get; set; }
        public int? IdEmpleado { get; set; }
        public string Moneda { get; set; }
        public int? IdCantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string Descripcion { get; set; }
        public string Expedicion { get; set; }

        public TblEmpleados IdEmpleadoNavigation { get; set; }
        public TblNomina IdNominaNavigation { get; set; }
    }
}
