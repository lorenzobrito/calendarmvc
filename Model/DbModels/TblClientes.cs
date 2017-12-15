using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblClientes
    {
        public TblClientes()
        {
            TblFacturas = new HashSet<TblFacturas>();
        }

        public int IdCliente { get; set; }
        public int Tipoclie { get; set; }
        public string Codcli { get; set; }
        public string Rnombre { get; set; }
        public string Rrfc { get; set; }
        public string Rcalle { get; set; }
        public string Rnoexterior { get; set; }
        public string Rnointerior { get; set; }
        public string Rcodigopos { get; set; }
        public string Rcolonia { get; set; }
        public string Restado { get; set; }
        public string Rlocalidad { get; set; }
        public string Rmunicipio { get; set; }
        public string Ciudadfis { get; set; }
        public string Provfis { get; set; }
        public string Rpais { get; set; }
        public string Rtelefono { get; set; }
        public string Rtelefono2 { get; set; }
        public string Remail { get; set; }
        public string Remail2 { get; set; }
        public string Fax { get; set; }
        public decimal? Diascred { get; set; }
        public decimal? Descu { get; set; }
        public string Codcliant { get; set; }
        public int? IdEmpresa { get; set; }
        public string Ctapago { get; set; }
        public int? IdFormapago { get; set; }
        public int? Idusocfdi { get; set; }

        public TblEmpresas IdEmpresaNavigation { get; set; }
        public TblCatafopa IdFormapagoNavigation { get; set; }
        public TblCatUsoCfdi IdusocfdiNavigation { get; set; }
        public ICollection<TblFacturas> TblFacturas { get; set; }
    }
}
