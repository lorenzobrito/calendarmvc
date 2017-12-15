using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblCertificados
    {
        public int IdCertificado { get; set; }
        public string NroCertificado { get; set; }
        public string RutaCer { get; set; }
        public string RutaKey { get; set; }
        public string Pass { get; set; }
        public string FileCer { get; set; }
        public string FileKey { get; set; }
        public int IdEmpresa { get; set; }
        public byte Status { get; set; }

        public TblEmpresas IdEmpresaNavigation { get; set; }
    }
}
