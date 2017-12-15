using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblClasificacion
    {
        public TblClasificacion()
        {
            TblFacturas = new HashSet<TblFacturas>();
        }

        public int IdClasificacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<TblFacturas> TblFacturas { get; set; }
    }
}
