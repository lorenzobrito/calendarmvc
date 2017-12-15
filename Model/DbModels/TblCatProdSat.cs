using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblCatProdSat
    {
        public TblCatProdSat()
        {
            TblProductos = new HashSet<TblProductos>();
        }

        public int IdProdSat { get; set; }
        public string Claveprod { get; set; }
        public string Descripcion { get; set; }

        public ICollection<TblProductos> TblProductos { get; set; }
    }
}
