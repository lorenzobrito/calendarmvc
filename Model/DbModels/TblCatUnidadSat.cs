using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblCatUnidadSat
    {
        public TblCatUnidadSat()
        {
            TblProductos = new HashSet<TblProductos>();
        }

        public int IdUnidadSat { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<TblProductos> TblProductos { get; set; }
    }
}
