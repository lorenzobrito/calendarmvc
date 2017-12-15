using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblCatUsoCfdi
    {
        public TblCatUsoCfdi()
        {
            TblClientes = new HashSet<TblClientes>();
        }

        public int Idusocfdi { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }

        public ICollection<TblClientes> TblClientes { get; set; }
    }
}
