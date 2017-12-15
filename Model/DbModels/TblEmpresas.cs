using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblEmpresas
    {
        public TblEmpresas()
        {
            TblCertificados = new HashSet<TblCertificados>();
            TblClientes = new HashSet<TblClientes>();
            TblFacturas = new HashSet<TblFacturas>();
            TblNomina = new HashSet<TblNomina>();
            TblUsuarios = new HashSet<TblUsuarios>();
        }

        public int IdEmpresa { get; set; }
        public string Enombre { get; set; }
        public string Erfc { get; set; }
        public string Ecalle { get; set; }
        public string Ecodigopos { get; set; }
        public string Ecolonia { get; set; }
        public string Eestado { get; set; }
        public string Elocalidad { get; set; }
        public string Emunicipio { get; set; }
        public string Enoexterior { get; set; }
        public string Enointerior { get; set; }
        public string Epais { get; set; }
        public string Etelefono { get; set; }
        public int? Tasaiva { get; set; }
        public string Email { get; set; }
        public string Eweb { get; set; }

        public ICollection<TblCertificados> TblCertificados { get; set; }
        public ICollection<TblClientes> TblClientes { get; set; }
        public ICollection<TblFacturas> TblFacturas { get; set; }
        public ICollection<TblNomina> TblNomina { get; set; }
        public ICollection<TblUsuarios> TblUsuarios { get; set; }
    }
}
