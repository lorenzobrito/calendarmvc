using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblFacturas
    {
        public TblFacturas()
        {
            TblItemsFactura = new HashSet<TblItemsFactura>();
        }

        public int IdFactura { get; set; }
        public string Seriecfd { get; set; }
        public decimal? Foliocfd { get; set; }
        public string HoraAlta { get; set; }
        public int IdCertificado { get; set; }
        public int IdCliente { get; set; }
        public string TipoMon { get; set; }
        public string Contrarec { get; set; }
        public decimal? Formadepago { get; set; }
        public string MetodoPago { get; set; }
        public decimal? Tasaiva { get; set; }
        public decimal? Monto { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Descuentos { get; set; }
        public decimal? Importeiva { get; set; }
        public decimal? Total { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Subtotal2 { get; set; }
        public decimal? Importeiva2 { get; set; }
        public decimal? Total2 { get; set; }
        public decimal? Saldo2 { get; set; }
        public string TipoCompro { get; set; }
        public decimal? DiasCondi { get; set; }
        public int? IdEmpresa { get; set; }
        public decimal? CfdGenerada { get; set; }
        public string RutaCfd { get; set; }
        public string RutaBi { get; set; }
        public decimal? EstadoCfd { get; set; }
        public string Observacion { get; set; }
        public string Titulo { get; set; }
        public string Tipofact { get; set; }
        public string Sellocfd { get; set; }
        public string Fechatimb { get; set; }
        public string Uuid { get; set; }
        public string Certifisat { get; set; }
        public string Sellosat { get; set; }
        public string Cadeori { get; set; }
        public byte Estatusfactura { get; set; }
        public int IdClasificacion { get; set; }
        public int IdFormapago { get; set; }
        public int? IdTipomoneda { get; set; }
        public decimal? Valormoneda { get; set; }
        public int IdTipopago { get; set; }
        public string Cuentapago { get; set; }
        public string Pedido { get; set; }
        public string Condicionpago { get; set; }
        public string Lote { get; set; }

        public TblClasificacion IdClasificacionNavigation { get; set; }
        public TblClientes IdClienteNavigation { get; set; }
        public TblEmpresas IdEmpresaNavigation { get; set; }
        public TblCatafopa IdFormapagoNavigation { get; set; }
        public TblMoneda IdTipomonedaNavigation { get; set; }
        public ICollection<TblItemsFactura> TblItemsFactura { get; set; }
    }
}
