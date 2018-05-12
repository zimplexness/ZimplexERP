using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLayer
{
   public class ProveedorManager
    {
        //declaracion de DataContext y de la tabla proveedores
        public Entities Context;
        public Proveedores proveedor = new Proveedores();
        public CuentaCorriente cuentacorriente;
        public DetalleProveedor_ProductorSeguro Productor;
        

        public int insertar_proveedor(Proveedores proveedor)
        {
            int result = 0;
            using (Context=new Entities())
            {
                Context.Proveedores.Add(proveedor);
                Context.SaveChanges();
                result = proveedor.IdProveedores;
                return result;

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

        public void ActualizarProveedor(string nombre, string razon,string telefono,string direccion,string cuit)
        {
            using (Context = new Entities())
            {
                var prov = (from p in Context.Proveedores
                            where p.Cuit == cuit
                            select p).ToList();

                foreach (var item in prov)
                {
                    Context.Proveedores.Attach(item);
                    item.Nombre = nombre;
                    item.Razon = razon;
                    item.Telefono = telefono;
                    item.Direccion = direccion;
                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
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


    }
}
