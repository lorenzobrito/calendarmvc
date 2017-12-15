using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblUsuarios
    {
        public TblUsuarios()
        {
            TblNomina = new HashSet<TblNomina>();
        }

        public int IdUsuario { get; set; }
        public string Clave { get; set; }
        public string Iniciales { get; set; }
        public string Username { get; set; }
        public string Userpass { get; set; }
        public string Nombre { get; set; }
        public decimal Nivel { get; set; }
        public byte EsAdmin { get; set; }
        public string Depto { get; set; }
        public string Proceso { get; set; }
        public int IdEmpresa { get; set; }

        public TblEmpresas IdEmpresaNavigation { get; set; }
        public ICollection<TblNomina> TblNomina { get; set; }
    }
}
