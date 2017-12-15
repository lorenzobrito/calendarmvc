using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblItemsFactura
    {
        public int IdItem { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public string Unidad { get; set; }
        public decimal Cantidad { get; set; }
        public string Desproducto { get; set; }
        public decimal Valorunitario { get; set; }
        public decimal Importe { get; set; }
        public decimal Tasaiva { get; set; }
        public decimal Impiva { get; set; }
        public string Comentario { get; set; }
        public decimal Valorunitario2 { get; set; }
        public decimal Importe2 { get; set; }
        public bool? Limpcant { get; set; }
        public decimal Tasaiva2 { get; set; }
        public decimal Impiva2 { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Precio { get; set; }

        public TblFacturas IdFacturaNavigation { get; set; }
        public TblProductos IdProductoNavigation { get; set; }
    }
}
