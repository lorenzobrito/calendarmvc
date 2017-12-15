using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblNomina
    {
        public TblNomina()
        {
            TblNominaComprobante = new HashSet<TblNominaComprobante>();
            TblNominaConceptos = new HashSet<TblNominaConceptos>();
            TblNominaTotales = new HashSet<TblNominaTotales>();
        }

        public int IdNomina { get; set; }
        public int? IdUsuario { get; set; }
        public int? Modo { get; set; }
        public int? IdEmpresa { get; set; }

        public TblEmpresas IdEmpresaNavigation { get; set; }
        public TblUsuarios IdUsuarioNavigation { get; set; }
        public ICollection<TblNominaComprobante> TblNominaComprobante { get; set; }
        public ICollection<TblNominaConceptos> TblNominaConceptos { get; set; }
        public ICollection<TblNominaTotales> TblNominaTotales { get; set; }
    }
}
