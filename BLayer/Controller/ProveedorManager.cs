﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL;
using DL.Repositories;

using System.Data.Entity;

namespace BLayer
{
   public class ProveedorManager
    {




        //declaracion de DataContext y de la tabla proveedores
        IProveedorRepository proveedorRepository;


        
        public Entities Context;
        public Proveedores proveedor = new Proveedores();
        public CuentaCorriente cuentacorriente;
        public DetalleProveedor_ProductorSeguro Productor;
        RubroProveedor rubRubro=new RubroProveedor();

        public ProveedorManager()
        {
            //this.proveedorRepository = new ProveedorRepository();

        }

        public ProveedorManager(IProveedorRepository proveedorRepository)
        {
            this.proveedorRepository = proveedorRepository;
        }




        public void InsertarProveedor(string nombre,string razon,string cuit,string IIBB,
            string direccion,int idprovincia,int idlocalidad, int idrubroproveedor,DateTime fechaingreso,string telefono)
        {

            if (string.IsNullOrEmpty(nombre)||string.IsNullOrEmpty(razon)||string.IsNullOrEmpty(cuit))
            {
                throw new Exception("Error, Debe Insertar los Datos");
            }
            else
            {
                using (Context = new Entities())
                {
                    proveedor.Nombre = nombre;
                    proveedor.Razon = razon;
                    proveedor.IngresosBrutos = IIBB;
                    proveedor.Cuit = cuit;
                    proveedor.Direccion = direccion;
                    proveedor.IDProvincia = idprovincia;
                    proveedor.IDLocalidad = idlocalidad;
                    proveedor.IDRubro = idrubroproveedor;
                    proveedor.FechaIngreso = fechaingreso;
                    proveedor.Telefono = telefono;
                    Context.Proveedores.Add(proveedor);
                    
                    Context.SaveChanges();
                   
                }

            }




        }

        public List<View_Proveedores> ListarProveedores()
        {

            using (Context=new Entities()) {
                var query = (from listproveedor in Context.View_Proveedores select listproveedor).ToList();
                return query;
            }
        }

        public List<Proveedores> SeleccionarProveedores()
        {

            using (Context = new Entities())
            {
                var query = (from listproveedor in Context.Proveedores select listproveedor).ToList();
                return query;
            }
        }


        public List<View_Proveedores> filtrarproveedores(string filtronombre)
        {
            using (Context = new Entities()) {
                var filtro = (from p in Context.View_Proveedores where p.Nombre.Contains(filtronombre.ToUpper()) select p).ToList();
                return filtro;
            }
        }

        public int EliminarProveedor(string cuit)
        {
            try
            {
                using (Context=new Entities())
                {

                    var prov = (from p in Context.Proveedores where p.Cuit == cuit select p).First();

                    Context.Proveedores.Remove(prov);
                    Context.SaveChanges();
                    int result = 1;
                    return result;


                }
            }
            catch (Exception)
            {

                throw;
            }









            //}

        }

        public Proveedores EncontrarProveedor(string cuit)
        {
            using (Context=new Entities()) {
                var query = (from p in Context.Proveedores
                             where p.Cuit == cuit
                             select p).FirstOrDefault();

                return query;
            }
        }

        public List<ProductoresSeguro> ListarProductorSeguro()
        {
            using (Context=new Entities())
            {
                var query = (from p in Context.ProductoresSeguro
                             select p).ToList();

                return query;
            }


        }

        public void InsertarProductorSeguro(int idproveedor,int idproductor)
        {
         
            using (Context=new Entities())
            {
                Productor = new DetalleProveedor_ProductorSeguro();
                Productor.IdProveedor = idproveedor;
                Productor.IdProductorSeguro = idproductor;
                Context.DetalleProveedor_ProductorSeguro.Add(Productor);
                Context.SaveChanges();
               


            }



        }

        public void ActualizarProveedor(string nombre, string razon, string cuit, string IIBB,
            string direccion, int idprovincia, int idlocalidad, int idrubroproveedor, DateTime fechaingreso,string telefono)
        {

            using (Context = new Entities())
            {
                var prov = (from p in Context.Proveedores
                            where p.Cuit == cuit
                            select p).ToList();

                foreach (var proveedor in prov)
                {
                    
                    proveedor.Nombre = nombre;
                    proveedor.Razon = razon;
                    proveedor.IngresosBrutos = IIBB;
                    proveedor.Cuit = cuit;
                    proveedor.Direccion = direccion;
                    proveedor.IDProvincia = idprovincia;
                    proveedor.IDLocalidad = idlocalidad;
                    proveedor.IDRubro = idrubroproveedor;
                    proveedor.FechaIngreso = fechaingreso;
                    proveedor.Telefono = telefono;
                    Context.Proveedores.Attach(proveedor);
                    Context.Entry(proveedor).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }     
                
            }

        }

        public int DevolverIdPRoveedorporNombre(string nombre)
        {
            int result = 0;
            using (Context=new Entities())
            {
                var query =( from p in Context.Proveedores
                            where p.Nombre == nombre
                            select p.IdProveedores).FirstOrDefault().ToString() ;
               result=int.Parse(query);
               return result;
            }
            

        }

        public void CrearCuentaCorriente(CuentaCorriente cuentacorriente)
        {
            using (Context = new Entities())
            {
                Context.CuentaCorriente.Add(cuentacorriente);
                Context.SaveChanges();


            }



        }

        public List<CuentasCorrientes> GetCuentasCorrientes() {
            using (Context=new Entities())
            {
                return Context.CuentasCorrientes.ToList();

            }




        }

        public List<CuentasCorrientes> filtroCuentasCorrientes(string nombre)
        {
            using (Context = new Entities())
            {
                return Context.CuentasCorrientes.Where(x=>x.Nombre.Contains(nombre.ToUpper())).ToList();

            }




        }

        public int devolverIDProveedorCUIT(string cuit)
        {
            using (Context = new Entities())
            {
                int result = 0;

                var query = (from p in Context.Proveedores
                             where p.Cuit == cuit
                             select p.IdProveedores).FirstOrDefault();

               result=int.Parse(query.ToString());
                return result;
            }
        }

        public int ValidateProveedor(string cuit)
        {
            int result;

            try
            {
                using (Context = new Entities())
                {


                    var validatprov = (from p in Context.Proveedores
                                       where p.Cuit == cuit
                                       select p).FirstOrDefault();

                    if (validatprov != null)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                }

                return result;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public int ValidateCuentaCorriente(string cuit)
        {
            int result;

            try
            {
                using (Context = new Entities())
                {


                    var validatprov = (from c in Context.CuentaCorriente
                                       where c.Nombre == cuit
                                       select c).FirstOrDefault();

                    if (validatprov != null)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                }

                return result;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public string DevolverCuit(int idproveedor)
        {
            using (Context=new Entities())
            {
                var query = (from p in Context.Proveedores
                             where p.IdProveedores == idproveedor
                             select p.Cuit).ToString();
                return query;
            }

        }

        public List<string> listarNombreProveedores()
        {
            using (Context=new Entities())
            {

                var query = (from p in Context.Proveedores
                             select p.Nombre).ToList();

                return query;
            }


        }

        public CuentasCorrientes GetCuentaCorrienteByCuit(string cuit) {
            using (Context=new Entities())
            {

                return Context.CuentasCorrientes.Where(x => x.Cuit == cuit).FirstOrDefault();
            }


        } 

        public List<View_Proveedores> filtrarproveedoresRazon(string filtroRazon)
        {
            using (Context = new Entities())
            {
                var filtro = (from p in Context.View_Proveedores where p.Razon.Contains(filtroRazon.ToUpper()) select p).ToList();
                return filtro;
            }
        }

        public List<RubroProveedor> ListarRubros()
        {
            using (Context=new Entities())
            {
                var query = (from rubro in Context.RubroProveedor
                             select rubro).ToList();
                return query;



            }

        }

        public List<View_Proveedores> filtrarPorRubros(string filtronombre)
        {
            using (Context = new Entities())
            {
                var filtro = (from p in Context.View_Proveedores where p.RubroProveedor.Contains(filtronombre.ToUpper()) select p).ToList();
                return filtro;
            }
        }

        public List<RubroProveedor> FilterRubros(string filter) {
            using (Context = new Entities())
            {
                var filtro = (from p in Context.RubroProveedor where p.Descripcion.Contains(filter.ToUpper()) select p).ToList();
                return filtro;
            }
        }

        public void InsertarorUpdateCuentaCorriente(CuentaCorriente cuentaCorriente) {

            using (Context=new Entities())
            {
                var cc = Context.CuentaCorriente.Where(x => x.IDProveedor == cuentaCorriente.IDProveedor).ToList();
                if (cc !=null)
                    foreach (var item in cc)
                    {
                        item.IDProveedor = cuentaCorriente.IDProveedor;
                        item.Nombre = cuentaCorriente.Nombre;
                        item.Vencimiento = cuentaCorriente.Vencimiento;
                        item.Comentario = cuentaCorriente.Comentario;
                        Context.CuentaCorriente.Attach(item);
                        Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        Context.SaveChanges();
                    }
                    if (cc.FirstOrDefault()==null)
                        Context.CuentaCorriente.Add(cuentaCorriente);
                        Context.SaveChanges();

                    
                   
                    
                
            }




        }

        public void InsertarorUpdateRubro(RubroProveedor rubro) {
            
            using (Context=new Entities())
            {
               

                if (Context.RubroProveedor.AnyAsync(r=>r.Descripcion==rubro.Descripcion)!=null)
                {
                    
                    
                    Context.RubroProveedor.Attach(rubro);

                    Context.Entry(rubro).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }
                else
                {
                   
                    Context.RubroProveedor.Add(rubro);
                    Context.SaveChanges();

                }


         }

        }


        public RubroProveedor GetRubroByID(int id) {

            using (Context=new Entities() )
            {
                return Context.RubroProveedor.Where(x => x.IDRubroProveedor == id).FirstOrDefault();
            }

        }
    }
}
