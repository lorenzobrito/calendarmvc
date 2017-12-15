using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace efacturadb.DbModels
{
    public partial class FacturaElectronicaContext : DbContext
    {
        public FacturaElectronicaContext()
        { }
        public FacturaElectronicaContext(DbContextOptions<DbContext> options)
           : base(options)
        {
            ///Configuration.ProxyCreationEnabled = false;//this is line 
        }
        public virtual DbSet<TblCatafopa> TblCatafopa { get; set; }
        public virtual DbSet<TblCatProdSat> TblCatProdSat { get; set; }
        public virtual DbSet<TblCatRegimen> TblCatRegimen { get; set; }
        public virtual DbSet<TblCatUnidadSat> TblCatUnidadSat { get; set; }
        public virtual DbSet<TblCatUsoCfdi> TblCatUsoCfdi { get; set; }
        public virtual DbSet<TblCertificados> TblCertificados { get; set; }
        public virtual DbSet<TblClasificacion> TblClasificacion { get; set; }
        public virtual DbSet<TblClientes> TblClientes { get; set; }
        public virtual DbSet<TblEmpleados> TblEmpleados { get; set; }
        public virtual DbSet<TblEmpresas> TblEmpresas { get; set; }
        public virtual DbSet<TblFacturas> TblFacturas { get; set; }
        public virtual DbSet<TblItemsFactura> TblItemsFactura { get; set; }
        public virtual DbSet<TblMoneda> TblMoneda { get; set; }
        public virtual DbSet<TblNomina> TblNomina { get; set; }
        public virtual DbSet<TblNominaComprobante> TblNominaComprobante { get; set; }
        public virtual DbSet<TblNominaConceptos> TblNominaConceptos { get; set; }
        public virtual DbSet<TblNominaTotales> TblNominaTotales { get; set; }
        public virtual DbSet<TblProductos> TblProductos { get; set; }
        public virtual DbSet<TblRegimen> TblRegimen { get; set; }
        public virtual DbSet<TblUsuarios> TblUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=.;Initial Catalog=FacturaElectronica;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCatafopa>(entity =>
            {
                entity.HasKey(e => e.IdFormapago);

                entity.ToTable("tbl_catafopa");

                entity.Property(e => e.IdFormapago).HasColumnName("id_formapago");

            
            });

            modelBuilder.Entity<TblCatProdSat>(entity =>
            {
                entity.HasKey(e => e.IdProdSat);

                entity.ToTable("tbl_catProdSat");

                entity.Property(e => e.IdProdSat).HasColumnName("idProdSat");

                entity.Property(e => e.Claveprod)
                    .HasColumnName("claveprod")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblCatRegimen>(entity =>
            {
                entity.HasKey(e => e.Idregimen);

                entity.ToTable("tbl_catRegimen");

                entity.Property(e => e.Idregimen).HasColumnName("idregimen");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Descripcio)
                    .HasColumnName("descripcio")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCatUnidadSat>(entity =>
            {
                entity.HasKey(e => e.IdUnidadSat);

                entity.ToTable("tbl_catUnidadSat");

                entity.Property(e => e.IdUnidadSat).HasColumnName("idUnidadSat");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(250);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCatUsoCfdi>(entity =>
            {
                entity.HasKey(e => e.Idusocfdi);

                entity.ToTable("tbl_catUsoCFDI");

                entity.Property(e => e.Idusocfdi).HasColumnName("idusocfdi");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblCertificados>(entity =>
            {
                entity.HasKey(e => e.IdCertificado);

                entity.ToTable("tbl_certificados");

                entity.Property(e => e.IdCertificado).HasColumnName("id_certificado");

                entity.Property(e => e.FileCer)
                    .IsRequired()
                    .HasColumnName("file_cer")
                    .HasColumnType("text");

                entity.Property(e => e.FileKey)
                    .IsRequired()
                    .HasColumnName("file_key")
                    .HasColumnType("text");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NroCertificado)
                    .IsRequired()
                    .HasColumnName("nro_certificado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasColumnType("char(30)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RutaCer)
                    .IsRequired()
                    .HasColumnName("ruta_cer")
                    .HasColumnType("char(150)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RutaKey)
                    .IsRequired()
                    .HasColumnName("ruta_key")
                    .HasColumnType("char(150)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblCertificados)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_certificados_tbl_empresas");
            });

            modelBuilder.Entity<TblClasificacion>(entity =>
            {
                entity.HasKey(e => e.IdClasificacion);

                entity.ToTable("tbl_clasificacion");

                entity.Property(e => e.IdClasificacion).HasColumnName("idClasificacion");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblClientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("tbl_clientes");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.Ciudadfis)
                    .HasColumnName("ciudadfis")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codcli)
                    .HasColumnName("codcli")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codcliant)
                    .HasColumnName("codcliant")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ctapago)
                    .HasColumnName("ctapago")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descu)
                    .HasColumnName("descu")
                    .HasColumnType("decimal(5, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Diascred)
                    .HasColumnName("diascred")
                    .HasColumnType("decimal(8, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdFormapago).HasColumnName("id_formapago");

                entity.Property(e => e.Idusocfdi).HasColumnName("idusocfdi");

                entity.Property(e => e.Provfis)
                    .HasColumnName("provfis")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rcalle)
                    .HasColumnName("rcalle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rcodigopos)
                    .HasColumnName("rcodigopos")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rcolonia)
                    .HasColumnName("rcolonia")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remail)
                    .HasColumnName("remail")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remail2)
                    .HasColumnName("remail2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Restado)
                    .HasColumnName("restado")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rlocalidad)
                    .HasColumnName("rlocalidad")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rmunicipio)
                    .HasColumnName("rmunicipio")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rnoexterior)
                    .HasColumnName("rnoexterior")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rnointerior)
                    .HasColumnName("rnointerior")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rnombre)
                    .HasColumnName("rnombre")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rpais)
                    .HasColumnName("rpais")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rrfc)
                    .HasColumnName("rrfc")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rtelefono)
                    .HasColumnName("rtelefono")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rtelefono2)
                    .HasColumnName("rtelefono2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tipoclie)
                    .HasColumnName("tipoclie")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblClientes)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_tbl_clientes_tbl_empresas");


                entity.HasOne(d => d.IdusocfdiNavigation)
                    .WithMany(p => p.TblClientes)
                    .HasForeignKey(d => d.Idusocfdi)
                    .HasConstraintName("FK_tbl_clientes_tbl_catUsoCFDI");
            });

            modelBuilder.Entity<TblEmpleados>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.Antiguedad).HasColumnName("antiguedad");

                entity.Property(e => e.Banco)
                    .HasColumnName("banco")
                    .HasMaxLength(900);

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(500);

                entity.Property(e => e.Calle2)
                    .HasColumnName("calle2")
                    .HasMaxLength(500);

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(500);

                entity.Property(e => e.Clabe)
                    .HasColumnName("clabe")
                    .HasMaxLength(500);

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(500);

                entity.Property(e => e.Colonia2)
                    .HasColumnName("colonia2")
                    .HasMaxLength(500);

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(500);

                entity.Property(e => e.Cp)
                    .HasColumnName("cp")
                    .HasMaxLength(5);

                entity.Property(e => e.Cp2)
                    .HasColumnName("cp2")
                    .HasMaxLength(5);

                entity.Property(e => e.Curp)
                    .HasColumnName("curp")
                    .HasMaxLength(50);

                entity.Property(e => e.Delegacion)
                    .HasColumnName("delegacion")
                    .HasMaxLength(500);

                entity.Property(e => e.Delegacion2)
                    .HasColumnName("delegacion2")
                    .HasMaxLength(500);

                entity.Property(e => e.Departamento)
                    .HasColumnName("departamento")
                    .HasMaxLength(500);

                entity.Property(e => e.DescripcionEmail1)
                    .HasColumnName("descripcionEmail1")
                    .HasMaxLength(500);

                entity.Property(e => e.DescripcionEmail2)
                    .HasColumnName("descripcionEmail2")
                    .HasMaxLength(500);

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(500);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(500);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(500);

                entity.Property(e => e.Estado2)
                    .HasColumnName("estado2")
                    .HasMaxLength(500);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FormaPago)
                    .HasColumnName("formaPago")
                    .HasMaxLength(900);

                entity.Property(e => e.IdBanco).HasColumnName("idBanco");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdEstado2).HasColumnName("idEstado2");

                entity.Property(e => e.IdEstatus).HasColumnName("idEstatus");

                entity.Property(e => e.IdFormaPago).HasColumnName("idFormaPago");

                entity.Property(e => e.IdPago).HasColumnName("idPago");

                entity.Property(e => e.IdRegimenContratacion).HasColumnName("idRegimenContratacion");

                entity.Property(e => e.IdRiesgoPuesto).HasColumnName("idRiesgoPuesto");

                entity.Property(e => e.IdSector).HasColumnName("idSector");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.IdTipoCliente).HasColumnName("idTipoCliente");

                entity.Property(e => e.IdTipoContrato).HasColumnName("idTipoContrato");

                entity.Property(e => e.IdTipoDomicilio).HasColumnName("idTipoDomicilio");

                entity.Property(e => e.IdTipoJornada).HasColumnName("idTipoJornada");

                entity.Property(e => e.IdTipoPersona).HasColumnName("idTipoPersona");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NoEmpleado)
                    .HasColumnName("noEmpleado")
                    .HasMaxLength(500);

                entity.Property(e => e.NoExt)
                    .HasColumnName("noExt")
                    .HasMaxLength(50);

                entity.Property(e => e.NoExt2)
                    .HasColumnName("noExt2")
                    .HasMaxLength(50);

                entity.Property(e => e.NoInt)
                    .HasColumnName("noInt")
                    .HasMaxLength(50);

                entity.Property(e => e.NoInt2)
                    .HasColumnName("noInt2")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(900);

                entity.Property(e => e.Nss)
                    .HasColumnName("nss")
                    .HasMaxLength(50);

                entity.Property(e => e.OtroTel)
                    .HasColumnName("otroTel")
                    .HasMaxLength(500);

                entity.Property(e => e.Pago)
                    .HasColumnName("pago")
                    .HasMaxLength(500);

                entity.Property(e => e.Puesto)
                    .HasColumnName("puesto")
                    .HasMaxLength(900);

                entity.Property(e => e.RegimenContratacion)
                    .HasColumnName("regimenContratacion")
                    .HasMaxLength(900);

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(50);

                entity.Property(e => e.RiesgoPuesto)
                    .HasColumnName("riesgoPuesto")
                    .HasMaxLength(900);

                entity.Property(e => e.SalarioBase)
                    .HasColumnName("salarioBase")
                    .HasColumnType("money");

                entity.Property(e => e.SalarioIntegrado)
                    .HasColumnName("salarioIntegrado")
                    .HasColumnType("money");

                entity.Property(e => e.Sector)
                    .HasColumnName("sector")
                    .HasMaxLength(150);

                entity.Property(e => e.TelCasa)
                    .HasColumnName("telCasa")
                    .HasMaxLength(500);

                entity.Property(e => e.TelOficina)
                    .HasColumnName("telOficina")
                    .HasMaxLength(500);

                entity.Property(e => e.TipoCliente)
                    .HasColumnName("tipoCliente")
                    .HasMaxLength(150);

                entity.Property(e => e.TipoContrato)
                    .HasColumnName("tipoContrato")
                    .HasMaxLength(900);

                entity.Property(e => e.TipoDomicilio)
                    .HasColumnName("tipoDomicilio")
                    .HasMaxLength(500);

                entity.Property(e => e.TipoJornada)
                    .HasColumnName("tipoJornada")
                    .HasMaxLength(900);

                entity.Property(e => e.TipoPersona)
                    .HasColumnName("tipoPersona")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblEmpresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("tbl_empresas");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.Ecalle)
                    .HasColumnName("ECALLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ecodigopos)
                    .HasColumnName("ECODIGOPOS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ecolonia)
                    .HasColumnName("ECOLONIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eestado)
                    .HasColumnName("EESTADO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Elocalidad)
                    .HasColumnName("ELOCALIDAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Emunicipio)
                    .HasColumnName("EMUNICIPIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enoexterior)
                    .HasColumnName("ENOEXTERIOR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Enointerior)
                    .HasColumnName("ENOINTERIOR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Enombre)
                    .HasColumnName("ENOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Epais)
                    .HasColumnName("EPAIS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Erfc)
                    .HasColumnName("ERFC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Etelefono)
                    .HasColumnName("ETELEFONO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Eweb)
                    .HasColumnName("EWEB")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Tasaiva).HasColumnName("TASAIVA");
            });

            modelBuilder.Entity<TblFacturas>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("tbl_facturas");

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.Cadeori)
                    .HasColumnName("cadeori")
                    .HasColumnType("text");

                entity.Property(e => e.Certifisat)
                    .HasColumnName("certifisat")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CfdGenerada)
                    .HasColumnName("cfd_generada")
                    .HasColumnType("decimal(1, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Condicionpago)
                    .HasColumnName("condicionpago")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Contrarec)
                    .HasColumnName("contrarec")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cuentapago)
                    .HasColumnName("cuentapago")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descuentos)
                    .HasColumnName("descuentos")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.DiasCondi)
                    .HasColumnName("dias_condi")
                    .HasColumnType("decimal(3, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EstadoCfd)
                    .HasColumnName("estado_cfd")
                    .HasColumnType("decimal(1, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Estatusfactura).HasColumnName("estatusfactura");

                entity.Property(e => e.Fechatimb)
                    .HasColumnName("fechatimb")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Foliocfd)
                    .HasColumnName("foliocfd")
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Formadepago)
                    .HasColumnName("formadepago")
                    .HasColumnType("decimal(1, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HoraAlta)
                    .HasColumnName("hora_alta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdCertificado)
                    .HasColumnName("id_certificado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdClasificacion).HasColumnName("idClasificacion");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdFormapago).HasColumnName("id_formapago");

                entity.Property(e => e.IdTipomoneda).HasColumnName("id_tipomoneda");

                entity.Property(e => e.IdTipopago).HasColumnName("id_tipopago");

                entity.Property(e => e.Importeiva)
                    .HasColumnName("importeiva")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Importeiva2)
                    .HasColumnName("importeiva2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Lote)
                    .HasColumnName("lote")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MetodoPago)
                    .HasColumnName("metodo_pago")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pedido)
                    .HasColumnName("pedido")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RutaBi)
                    .HasColumnName("ruta_bi")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RutaCfd)
                    .HasColumnName("ruta_cfd")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Saldo)
                    .HasColumnName("saldo")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("('0.0000')");

                entity.Property(e => e.Saldo2)
                    .HasColumnName("saldo2")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("('0.0000')");

                entity.Property(e => e.Sellocfd)
                    .HasColumnName("sellocfd")
                    .HasColumnType("text");

                entity.Property(e => e.Sellosat)
                    .HasColumnName("sellosat")
                    .HasColumnType("text");

                entity.Property(e => e.Seriecfd)
                    .HasColumnName("seriecfd")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Subtotal2)
                    .HasColumnName("subtotal2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Tasaiva)
                    .HasColumnName("tasaiva")
                    .HasColumnType("decimal(5, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TipoCompro)
                    .HasColumnName("tipo_compro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoMon)
                    .HasColumnName("tipo_mon")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tipofact)
                    .HasColumnName("tipofact")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Total2)
                    .HasColumnName("total2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Valormoneda)
                    .HasColumnName("valormoneda")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdClasificacionNavigation)
                    .WithMany(p => p.TblFacturas)
                    .HasForeignKey(d => d.IdClasificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_facturas_tbl_clasificacion");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TblFacturas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_facturas_tbl_clientes");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblFacturas)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_tbl_facturas_tbl_empresas");

        

                entity.HasOne(d => d.IdTipomonedaNavigation)
                    .WithMany(p => p.TblFacturas)
                    .HasForeignKey(d => d.IdTipomoneda)
                    .HasConstraintName("FK_tbl_facturas_tbl_moneda");
            });

            modelBuilder.Entity<TblItemsFactura>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.ToTable("tbl_items_factura");

                entity.Property(e => e.IdItem).HasColumnName("id_item");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(7, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnName("comentario")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Desproducto)
                    .IsRequired()
                    .HasColumnName("desproducto")
                    .HasColumnType("text");

                entity.Property(e => e.IdFactura)
                    .HasColumnName("id_factura")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("id_producto")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Impiva)
                    .HasColumnName("impiva")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Impiva2)
                    .HasColumnName("impiva2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Importe2)
                    .HasColumnName("importe2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Limpcant)
                    .HasColumnName("limpcant")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tasaiva)
                    .HasColumnName("tasaiva")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Tasaiva2)
                    .HasColumnName("tasaiva2")
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasColumnName("unidad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Valorunitario)
                    .HasColumnName("valorunitario")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Valorunitario2)
                    .HasColumnName("valorunitario2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.TblItemsFactura)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_items_factura_tbl_facturas");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.TblItemsFactura)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_items_factura_tbl_productos");
            });

            modelBuilder.Entity<TblMoneda>(entity =>
            {
                entity.HasKey(e => e.IdTipomone);

                entity.ToTable("tbl_moneda");

                entity.Property(e => e.IdTipomone).HasColumnName("id_tipomone");

                entity.Property(e => e.Codmone)
                    .IsRequired()
                    .HasColumnName("codmone")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombmone)
                    .IsRequired()
                    .HasColumnName("nombmone")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tipomone)
                    .IsRequired()
                    .HasColumnName("tipomone")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Valormone)
                    .HasColumnName("valormone")
                    .HasColumnType("decimal(10, 4)")
                    .HasDefaultValueSql("('0.0000')");
            });

            modelBuilder.Entity<TblNomina>(entity =>
            {
                entity.HasKey(e => e.IdNomina);

                entity.Property(e => e.IdNomina).HasColumnName("idNomina");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Modo).HasColumnName("modo");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblNomina)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_Nomina_tbl_empresas");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TblNomina)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_Nomina_tbl_usuarios");
            });

            modelBuilder.Entity<TblNominaComprobante>(entity =>
            {
                entity.HasKey(e => e.IdComprobante);

                entity.ToTable("TblNomina_Comprobante");

                entity.Property(e => e.IdComprobante).HasColumnName("idComprobante");

                entity.Property(e => e.Comprobante)
                    .HasColumnName("comprobante")
                    .HasMaxLength(500);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(500);

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.Expedicion)
                    .HasColumnName("expedicion")
                    .HasColumnType("text");

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("fechaFinal")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("fechaPago")
                    .HasColumnType("date");

                entity.Property(e => e.Folio)
                    .HasColumnName("folio")
                    .HasMaxLength(500);

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasMaxLength(50);

                entity.Property(e => e.IdCantidad).HasColumnName("idCantidad");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdMoneda).HasColumnName("idMoneda");

                entity.Property(e => e.IdNomina).HasColumnName("idNomina");

                entity.Property(e => e.Moneda)
                    .HasColumnName("moneda")
                    .HasMaxLength(500);

                entity.Property(e => e.Serie)
                    .HasColumnName("serie")
                    .HasMaxLength(500);

                entity.Property(e => e.TipoDeCambio)
                    .HasColumnName("tipoDeCambio")
                    .HasColumnType("money");

                entity.Property(e => e.UnidadMedida)
                    .HasColumnName("unidadMedida")
                    .HasMaxLength(500);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.TblNominaComprobante)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK_Nomina_Comprobante_Empleados");

                entity.HasOne(d => d.IdNominaNavigation)
                    .WithMany(p => p.TblNominaComprobante)
                    .HasForeignKey(d => d.IdNomina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomina_Comprobante_Nomina");
            });

            modelBuilder.Entity<TblNominaConceptos>(entity =>
            {
                entity.HasKey(e => e.IdConceptos);

                entity.ToTable("TblNomina_Conceptos");

                entity.Property(e => e.IdConceptos).HasColumnName("idConceptos");

                entity.Property(e => e.ClavePropia)
                    .HasColumnName("clavePropia")
                    .HasMaxLength(500);

                entity.Property(e => e.Concepto)
                    .HasColumnName("concepto")
                    .HasMaxLength(500);

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.IdNomina).HasColumnName("idNomina");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("money");

                entity.Property(e => e.ImporteExento)
                    .HasColumnName("importeExento")
                    .HasColumnType("money");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnName("precioUnitario")
                    .HasColumnType("money");

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasColumnType("text");

                entity.Property(e => e.Retencion)
                    .HasColumnName("retencion")
                    .HasColumnType("decimal(30, 4)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(500);

                entity.HasOne(d => d.IdNominaNavigation)
                    .WithMany(p => p.TblNominaConceptos)
                    .HasForeignKey(d => d.IdNomina)
                    .HasConstraintName("FK_Nomina_Conceptos_Nomina");
            });

            modelBuilder.Entity<TblNominaTotales>(entity =>
            {
                entity.HasKey(e => e.IdTotales);

                entity.ToTable("TblNomina_Totales");

                entity.Property(e => e.IdTotales).HasColumnName("idTotales");

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("money");

                entity.Property(e => e.IdNomina).HasColumnName("idNomina");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("money");

                entity.Property(e => e.ImporteReal)
                    .HasColumnName("importeReal")
                    .HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("iva")
                    .HasColumnType("money");

                entity.Property(e => e.Otro)
                    .HasColumnName("otro")
                    .HasColumnType("money");

                entity.Property(e => e.RetencionIsr)
                    .HasColumnName("retencionISR")
                    .HasColumnType("money");

                entity.Property(e => e.RetencionIva)
                    .HasColumnName("retencionIVA")
                    .HasColumnType("money");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdNominaNavigation)
                    .WithMany(p => p.TblNominaTotales)
                    .HasForeignKey(d => d.IdNomina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomina_Totales_Nomina");
            });

            modelBuilder.Entity<TblProductos>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("tbl_productos");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.ClaveProducto)
                    .HasColumnName("claveProducto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.IdProdSat).HasColumnName("idProdSat");

                entity.Property(e => e.IdUnidadSat).HasColumnName("idUnidadSat");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Unidad)
                    .HasColumnName("unidad")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProdSatNavigation)
                    .WithMany(p => p.TblProductos)
                    .HasForeignKey(d => d.IdProdSat)
                    .HasConstraintName("FK_tbl_productos_tbl_catProdSat");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.TblProductos)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_tbl_productos_tbl_catUnidadSat");
            });

            modelBuilder.Entity<TblRegimen>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("tbl_regimen");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.Idregimen).HasColumnName("idregimen");

                entity.HasOne(d => d.IdregimenNavigation)
                    .WithMany(p => p.TblRegimen)
                    .HasForeignKey(d => d.Idregimen)
                    .HasConstraintName("FK_tbl_regimen_tbl_catRegimen");
            });

            modelBuilder.Entity<TblUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("tbl_usuarios");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Depto)
                    .IsRequired()
                    .HasColumnName("depto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EsAdmin)
                    .HasColumnName("es_admin")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.Iniciales)
                    .IsRequired()
                    .HasColumnName("iniciales")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nivel)
                    .HasColumnName("nivel")
                    .HasColumnType("decimal(1, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasColumnName("proceso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Userpass)
                    .IsRequired()
                    .HasColumnName("userpass")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblUsuarios)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_usuarios_tbl_empresas");
            });
        }
    }
}
