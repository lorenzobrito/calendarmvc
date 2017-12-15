using System;
using System.Collections.Generic;

namespace efacturadb.DbModels
{
    public partial class TblEmpleados
    {
        public TblEmpleados()
        {
            TblNominaComprobante = new HashSet<TblNominaComprobante>();
        }

        public int IdEmpleado { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEmpresa { get; set; }
        public string NoEmpleado { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Curp { get; set; }
        public string Nss { get; set; }
        public string Departamento { get; set; }
        public int? IdBanco { get; set; }
        public string Banco { get; set; }
        public string Clabe { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Antiguedad { get; set; }
        public string Puesto { get; set; }
        public int? IdTipoContrato { get; set; }
        public string TipoContrato { get; set; }
        public int? IdTipoJornada { get; set; }
        public string TipoJornada { get; set; }
        public int? IdPago { get; set; }
        public string Pago { get; set; }
        public decimal? SalarioBase { get; set; }
        public int? IdRiesgoPuesto { get; set; }
        public string RiesgoPuesto { get; set; }
        public decimal? SalarioIntegrado { get; set; }
        public int? IdFormaPago { get; set; }
        public string FormaPago { get; set; }
        public int? IdRegimenContratacion { get; set; }
        public string RegimenContratacion { get; set; }
        public string Contacto { get; set; }
        public int? IdTipoPersona { get; set; }
        public string TipoPersona { get; set; }
        public int? IdTipoCliente { get; set; }
        public string TipoCliente { get; set; }
        public int? IdSector { get; set; }
        public string Sector { get; set; }
        public string Calle { get; set; }
        public string NoExt { get; set; }
        public string NoInt { get; set; }
        public string Colonia { get; set; }
        public string Delegacion { get; set; }
        public int? IdEstado { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public string TelOficina { get; set; }
        public string TelCasa { get; set; }
        public string Celular { get; set; }
        public string OtroTel { get; set; }
        public string Email1 { get; set; }
        public string DescripcionEmail1 { get; set; }
        public string Email2 { get; set; }
        public string DescripcionEmail2 { get; set; }
        public int? IdTipoDomicilio { get; set; }
        public string TipoDomicilio { get; set; }
        public string Calle2 { get; set; }
        public string NoExt2 { get; set; }
        public string NoInt2 { get; set; }
        public string Colonia2 { get; set; }
        public string Delegacion2 { get; set; }
        public int? IdEstado2 { get; set; }
        public string Estado2 { get; set; }
        public string Cp2 { get; set; }
        public int? IdEstatus { get; set; }
        public int? IdTipo { get; set; }

        public ICollection<TblNominaComprobante> TblNominaComprobante { get; set; }
    }
}
