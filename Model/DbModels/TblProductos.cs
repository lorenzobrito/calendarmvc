using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblProductos
    {
        public TblProductos()
        {
            TblItemsFactura = new HashSet<TblItemsFactura>();
        }

        public int IdProducto { get; set; }
        public string ClaveProducto { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public decimal? Precio { get; set; }
        public int? IdProdSat { get; set; }
        public int? IdUnidadSat { get; set; }
        public int IdEmpresa { get; set; }

        public TblCatProdSat IdProdSatNavigation { get; set; }
        public TblCatUnidadSat IdUnidadSatNavigation { get; set; }
        public ICollection<TblItemsFactura> TblItemsFactura { get; set; }
    }
}
