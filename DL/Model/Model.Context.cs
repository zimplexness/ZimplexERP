﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Entidades;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActividadMantenimiento> ActividadMantenimiento { get; set; }
        public virtual DbSet<AfectadoEmpresaCliente> AfectadoEmpresaCliente { get; set; }
        public virtual DbSet<Almacenes> Almacenes { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<CategoriaEmpleado> CategoriaEmpleado { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<CentroCostos> CentroCostos { get; set; }
        public virtual DbSet<Combustibles> Combustibles { get; set; }
        public virtual DbSet<Comprobantes> Comprobantes { get; set; }
        public virtual DbSet<CondicionesCompra> CondicionesCompra { get; set; }
        public virtual DbSet<Contable> Contable { get; set; }
        public virtual DbSet<CuentaCorriente> CuentaCorriente { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<DetalleMantenimientoRepuestos> DetalleMantenimientoRepuestos { get; set; }
        public virtual DbSet<DetalleMediosPagos> DetalleMediosPagos { get; set; }
        public virtual DbSet<DetalleProveedor_ProductorSeguro> DetalleProveedor_ProductorSeguro { get; set; }
        public virtual DbSet<DetallesComprobanteArticulos> DetallesComprobanteArticulos { get; set; }
        public virtual DbSet<DetallesPago> DetallesPago { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<EmpresasClientes> EmpresasClientes { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<EstudiosRealizados> EstudiosRealizados { get; set; }
        public virtual DbSet<IngresoMateriales> IngresoMateriales { get; set; }
        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<Mantenimiento> Mantenimiento { get; set; }
        public virtual DbSet<MarcasVehiculos> MarcasVehiculos { get; set; }
        public virtual DbSet<MediosPago> MediosPago { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<ModelosVehiculos> ModelosVehiculos { get; set; }
        public virtual DbSet<Nacionalidades> Nacionalidades { get; set; }
        public virtual DbSet<NetRoles> NetRoles { get; set; }
        public virtual DbSet<NetUser> NetUser { get; set; }
        public virtual DbSet<NetUserLogin> NetUserLogin { get; set; }
        public virtual DbSet<ObraSocial> ObraSocial { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<PermissionMenus> PermissionMenus { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<PolizasSeguro> PolizasSeguro { get; set; }
        public virtual DbSet<ProductoresSeguro> ProductoresSeguro { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Referencias> Referencias { get; set; }
        public virtual DbSet<RegistroConducirBool> RegistroConducirBool { get; set; }
        public virtual DbSet<RubroProveedor> RubroProveedor { get; set; }
        public virtual DbSet<Sexos> Sexos { get; set; }
        public virtual DbSet<Sindicatos> Sindicatos { get; set; }
        public virtual DbSet<SolicitudesEmpleo> SolicitudesEmpleo { get; set; }
        public virtual DbSet<SubMenus> SubMenus { get; set; }
        public virtual DbSet<TablaDivisorCalculo> TablaDivisorCalculo { get; set; }
        public virtual DbSet<Talleres> Talleres { get; set; }
        public virtual DbSet<TiposComprobante> TiposComprobante { get; set; }
        public virtual DbSet<TiposFactura> TiposFactura { get; set; }
        public virtual DbSet<TipoTaller> TipoTaller { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<Vencimientos> Vencimientos { get; set; }
        public virtual DbSet<Zonas> Zonas { get; set; }
        public virtual DbSet<Choferes> Choferes { get; set; }
        public virtual DbSet<CuentasCorrientes> CuentasCorrientes { get; set; }
        public virtual DbSet<DatosEmpleadosActivos> DatosEmpleadosActivos { get; set; }
        public virtual DbSet<DetallePago> DetallePago { get; set; }
        public virtual DbSet<DetallesSolicitudesEmpleo> DetallesSolicitudesEmpleo { get; set; }
        public virtual DbSet<ListaTalleresMecanicos> ListaTalleresMecanicos { get; set; }
        public virtual DbSet<NominaCV> NominaCV { get; set; }
        public virtual DbSet<NominaTelecentro> NominaTelecentro { get; set; }
        public virtual DbSet<Solicitudesempleos> Solicitudesempleos { get; set; }
        public virtual DbSet<View_DetalleArticulo> View_DetalleArticulo { get; set; }
        public virtual DbSet<View_DetalleArticuloComprobante> View_DetalleArticuloComprobante { get; set; }
        public virtual DbSet<View_ListaEmpleados> View_ListaEmpleados { get; set; }
        public virtual DbSet<View_Proveedores> View_Proveedores { get; set; }
    
        public virtual ObjectResult<ComprobantesGastos_Compras_Result> ComprobantesGastos_Compras(Nullable<System.DateTime> fechainicio, Nullable<System.DateTime> fechafin)
        {
            var fechainicioParameter = fechainicio.HasValue ?
                new ObjectParameter("fechainicio", fechainicio) :
                new ObjectParameter("fechainicio", typeof(System.DateTime));
    
            var fechafinParameter = fechafin.HasValue ?
                new ObjectParameter("fechafin", fechafin) :
                new ObjectParameter("fechafin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ComprobantesGastos_Compras_Result>("ComprobantesGastos_Compras", fechainicioParameter, fechafinParameter);
        }
    
        public virtual int CUENTASXPAGAR(Nullable<System.DateTime> fECHAINICIO, Nullable<System.DateTime> fECHAFIN)
        {
            var fECHAINICIOParameter = fECHAINICIO.HasValue ?
                new ObjectParameter("FECHAINICIO", fECHAINICIO) :
                new ObjectParameter("FECHAINICIO", typeof(System.DateTime));
    
            var fECHAFINParameter = fECHAFIN.HasValue ?
                new ObjectParameter("FECHAFIN", fECHAFIN) :
                new ObjectParameter("FECHAFIN", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CUENTASXPAGAR", fECHAINICIOParameter, fECHAFINParameter);
        }
    
        public virtual ObjectResult<CuentasxPagarProveedores_Result> CuentasxPagarProveedores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CuentasxPagarProveedores_Result>("CuentasxPagarProveedores");
        }
    
        public virtual ObjectResult<DetalleSolicitudEmpleo_Result> DetalleSolicitudEmpleo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DetalleSolicitudEmpleo_Result>("DetalleSolicitudEmpleo");
        }
    
        public virtual ObjectResult<EncabezadoDeuda_Result> EncabezadoDeuda(Nullable<int> idproveedor)
        {
            var idproveedorParameter = idproveedor.HasValue ?
                new ObjectParameter("idproveedor", idproveedor) :
                new ObjectParameter("idproveedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EncabezadoDeuda_Result>("EncabezadoDeuda", idproveedorParameter);
        }
    
        public virtual ObjectResult<EncabezadoOrdenPago_Result> EncabezadoOrdenPago(Nullable<int> idPago)
        {
            var idPagoParameter = idPago.HasValue ?
                new ObjectParameter("IdPago", idPago) :
                new ObjectParameter("IdPago", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EncabezadoOrdenPago_Result>("EncabezadoOrdenPago", idPagoParameter);
        }
    
        public virtual ObjectResult<FacturasPendientesPago_Result> FacturasPendientesPago(Nullable<int> idproveedor)
        {
            var idproveedorParameter = idproveedor.HasValue ?
                new ObjectParameter("idproveedor", idproveedor) :
                new ObjectParameter("idproveedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FacturasPendientesPago_Result>("FacturasPendientesPago", idproveedorParameter);
        }
    
        public virtual ObjectResult<FACTURASXPROVEEDORES_Result> FACTURASXPROVEEDORES(Nullable<System.DateTime> fECHAINICIO, Nullable<System.DateTime> fECHAFIN, Nullable<int> iDPROVEEDOR)
        {
            var fECHAINICIOParameter = fECHAINICIO.HasValue ?
                new ObjectParameter("FECHAINICIO", fECHAINICIO) :
                new ObjectParameter("FECHAINICIO", typeof(System.DateTime));
    
            var fECHAFINParameter = fECHAFIN.HasValue ?
                new ObjectParameter("FECHAFIN", fECHAFIN) :
                new ObjectParameter("FECHAFIN", typeof(System.DateTime));
    
            var iDPROVEEDORParameter = iDPROVEEDOR.HasValue ?
                new ObjectParameter("IDPROVEEDOR", iDPROVEEDOR) :
                new ObjectParameter("IDPROVEEDOR", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FACTURASXPROVEEDORES_Result>("FACTURASXPROVEEDORES", fECHAINICIOParameter, fECHAFINParameter, iDPROVEEDORParameter);
        }
    
        public virtual ObjectResult<Gastos_ComprasxPeriodo_Result> Gastos_ComprasxPeriodo(Nullable<System.DateTime> fechainicio, Nullable<System.DateTime> fechafin)
        {
            var fechainicioParameter = fechainicio.HasValue ?
                new ObjectParameter("fechainicio", fechainicio) :
                new ObjectParameter("fechainicio", typeof(System.DateTime));
    
            var fechafinParameter = fechafin.HasValue ?
                new ObjectParameter("fechafin", fechafin) :
                new ObjectParameter("fechafin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Gastos_ComprasxPeriodo_Result>("Gastos_ComprasxPeriodo", fechainicioParameter, fechafinParameter);
        }
    
        public virtual ObjectResult<HistorialEmpleadosSitem_Result> HistorialEmpleadosSitem()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HistorialEmpleadosSitem_Result>("HistorialEmpleadosSitem");
        }
    
        public virtual ObjectResult<ListaEmpleadosActivos_Result> ListaEmpleadosActivos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaEmpleadosActivos_Result>("ListaEmpleadosActivos");
        }
    
        public virtual ObjectResult<ListaVehiculosActivos_Result> ListaVehiculosActivos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaVehiculosActivos_Result>("ListaVehiculosActivos");
        }
    
        public virtual ObjectResult<OrdenPago_Result> OrdenPago(Nullable<int> idpago)
        {
            var idpagoParameter = idpago.HasValue ?
                new ObjectParameter("Idpago", idpago) :
                new ObjectParameter("Idpago", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OrdenPago_Result>("OrdenPago", idpagoParameter);
        }
    
        public virtual ObjectResult<ReporteNominaTelecentro_Result> ReporteNominaTelecentro(Nullable<System.DateTime> fechafin)
        {
            var fechafinParameter = fechafin.HasValue ?
                new ObjectParameter("fechafin", fechafin) :
                new ObjectParameter("fechafin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReporteNominaTelecentro_Result>("ReporteNominaTelecentro", fechafinParameter);
        }
    
        public virtual ObjectResult<ReportePagosProveedores_Result> ReportePagosProveedores(Nullable<System.DateTime> fechainicio, Nullable<System.DateTime> fechafin)
        {
            var fechainicioParameter = fechainicio.HasValue ?
                new ObjectParameter("fechainicio", fechainicio) :
                new ObjectParameter("fechainicio", typeof(System.DateTime));
    
            var fechafinParameter = fechafin.HasValue ?
                new ObjectParameter("fechafin", fechafin) :
                new ObjectParameter("fechafin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReportePagosProveedores_Result>("ReportePagosProveedores", fechainicioParameter, fechafinParameter);
        }
    
        public virtual ObjectResult<SeleccionarDetalleComprobantesArticulos_Result> SeleccionarDetalleComprobantesArticulos(Nullable<int> iDComprobante)
        {
            var iDComprobanteParameter = iDComprobante.HasValue ?
                new ObjectParameter("IDComprobante", iDComprobante) :
                new ObjectParameter("IDComprobante", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SeleccionarDetalleComprobantesArticulos_Result>("SeleccionarDetalleComprobantesArticulos", iDComprobanteParameter);
        }
    
        public virtual ObjectResult<SeleccionarMediosDePagos_Result> SeleccionarMediosDePagos(Nullable<int> idPago)
        {
            var idPagoParameter = idPago.HasValue ?
                new ObjectParameter("idPago", idPago) :
                new ObjectParameter("idPago", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SeleccionarMediosDePagos_Result>("SeleccionarMediosDePagos", idPagoParameter);
        }
    
        public virtual ObjectResult<SP_DEUDASPROVEEDORES_Result> SP_DEUDASPROVEEDORES(Nullable<System.DateTime> fechainicio, Nullable<System.DateTime> fechafin)
        {
            var fechainicioParameter = fechainicio.HasValue ?
                new ObjectParameter("fechainicio", fechainicio) :
                new ObjectParameter("fechainicio", typeof(System.DateTime));
    
            var fechafinParameter = fechafin.HasValue ?
                new ObjectParameter("fechafin", fechafin) :
                new ObjectParameter("fechafin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DEUDASPROVEEDORES_Result>("SP_DEUDASPROVEEDORES", fechainicioParameter, fechafinParameter);
        }
    
        public virtual int uspAddUser(string iduser, string pUserName, string pPassword, Nullable<int> profile, ObjectParameter responseMessage)
        {
            var iduserParameter = iduser != null ?
                new ObjectParameter("iduser", iduser) :
                new ObjectParameter("iduser", typeof(string));
    
            var pUserNameParameter = pUserName != null ?
                new ObjectParameter("pUserName", pUserName) :
                new ObjectParameter("pUserName", typeof(string));
    
            var pPasswordParameter = pPassword != null ?
                new ObjectParameter("pPassword", pPassword) :
                new ObjectParameter("pPassword", typeof(string));
    
            var profileParameter = profile.HasValue ?
                new ObjectParameter("profile", profile) :
                new ObjectParameter("profile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspAddUser", iduserParameter, pUserNameParameter, pPasswordParameter, profileParameter, responseMessage);
        }
    
        public virtual ObjectResult<GastosXCentroCostos_Result> GastosXCentroCostos(Nullable<System.DateTime> fechaini, Nullable<System.DateTime> fechafin, Nullable<int> centroCosto, Nullable<int> contable)
        {
            var fechainiParameter = fechaini.HasValue ?
                new ObjectParameter("fechaini", fechaini) :
                new ObjectParameter("fechaini", typeof(System.DateTime));
    
            var fechafinParameter = fechafin.HasValue ?
                new ObjectParameter("fechafin", fechafin) :
                new ObjectParameter("fechafin", typeof(System.DateTime));
    
            var centroCostoParameter = centroCosto.HasValue ?
                new ObjectParameter("CentroCosto", centroCosto) :
                new ObjectParameter("CentroCosto", typeof(int));
    
            var contableParameter = contable.HasValue ?
                new ObjectParameter("Contable", contable) :
                new ObjectParameter("Contable", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GastosXCentroCostos_Result>("GastosXCentroCostos", fechainiParameter, fechafinParameter, centroCostoParameter, contableParameter);
        }
    }
}
