using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLayer
{
   public class VehiculosManager
    {

        private Entities Context;
        private Vehiculos vehiculo;

        public List<MarcasVehiculos> MarcasVehiculos() {

            using (Context=new Entities())
            {

                var query = Context.MarcasVehiculos.ToList();
                return query;


            }


        }
        public List<ModelosVehiculos> ModelosVehiculos(int idmarca)
        {
            using (Context = new Entities())
            {

                var query = (from m in Context.ModelosVehiculos
                             where m.MarcaID == idmarca
                             select m).ToList();
                return query;



            }


        }

        public List<ModelosVehiculos> ModelosVehiculosTodos()
        {
            using (Context = new Entities())
            {

                var query = (from m in Context.ModelosVehiculos
                             select m).ToList();
                return query;



            }


        }
        public List<Combustibles> Combustibles() {
            using (Context = new Entities())
            {
                var query = Context.Combustibles.ToList();
                return query;
            }

        }
        public List<Choferes> Choferes() {
            using (Context = new Entities())
            {
                var query = Context.Choferes.ToList();
                return query;
            }


        }
        public List<PolizasSeguro> PolizaSeguros() {
            using (Context = new Entities())
            {
                var query = (from ps in Context.PolizasSeguro
                             select ps).ToList();
                return query;
            }



        }

        public void InsertarVehiculo(bool activo, string patente,int idmarca, int idmodelo,string nochasis,string nomotor,int idpoliza,
            bool neumaticos,int idcombustible,int year, DateTime fechacompra, DateTime fechatransferencia, DateTime vigenciavtv, int idchofer,
            string titular, int km
            
            )
        {
            
            using (Context=new Entities())
            {
                vehiculo = new Vehiculos();
                vehiculo.Activo = activo;
                vehiculo.Patente = patente;
                vehiculo.Marca = idmarca;
                vehiculo.Modelo = idmodelo;
                vehiculo.Nochasis = nochasis;
                vehiculo.NoMotor = nomotor;
                vehiculo.IdPolizaSeguro = idpoliza;
                vehiculo.NeumaticoRepuesto = neumaticos;
                vehiculo.IDCombustible = idcombustible;
                vehiculo.Year = year;
                vehiculo.FechaCompra = fechacompra;
                vehiculo.FechaTransferencia = fechatransferencia;
                vehiculo.VigenciaVTV = vigenciavtv;
                vehiculo.IdChofer = idchofer;
                vehiculo.Titular = titular;
                vehiculo.KM = km;
                
                Context.Vehiculos.Add(vehiculo);
                Context.SaveChanges();



            }






        }

        public void UpdateVehiculo(bool activo, string patente, int idmarca, int idmodelo, string nochasis, string nomotor, int idpoliza,
           bool neumaticos, int idcombustible, int year, DateTime fechacompra, DateTime fechatransferencia, DateTime vigenciavtv, int idchofer,
           string titular, int km

           )
        {
            using (Context = new Entities())
            {

                var objvehiculo = (from v in Context.Vehiculos
                                   where v.Patente == patente
                                   select v).ToList();
                foreach (var item in objvehiculo)
                {

                

                    item.Activo = activo;
                    item.Patente = patente;
                    item.Marca = idmarca;
                    item.Modelo = idmodelo;
                    item.Nochasis = nochasis;
                    item.NoMotor = nomotor;
                    item.IdPolizaSeguro = idpoliza;
                    item.NeumaticoRepuesto = neumaticos;
                    item.IDCombustible = idcombustible;
                    item.Year = year;
                    item.FechaCompra = fechacompra;
                    item.FechaTransferencia = fechatransferencia;
                    item.VigenciaVTV = vigenciavtv;
                    item.IdChofer = idchofer;
                    item.Titular = titular;
                    item.KM = km;

                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();


                }
               



            }






        }


        public int ValidateVehiculo(string patente) {

            int result = 0;
            using (Context = new Entities())
            {
                var query = (from v in Context.Vehiculos
                             where v.Patente == patente
                             select v).FirstOrDefault();

                if (query!=null)
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }

                return result;

            }


        }


        public List<ListaVehiculosActivos_Result> listaVehiculosActivos() {
            using (Context=new Entities())
            {
                var query = Context.ListaVehiculosActivos().ToList();
                return query;


            }

        }

        public List<ListaVehiculosActivos_Result> FiltrarVehiculosxPatentes(string patente) {
            using (Context=new Entities())
            {
                var query = (from v in Context.ListaVehiculosActivos()
                             where v.Patente.Contains(patente.ToUpper())
                             select v).ToList();
                return query;
            }



        }

    }
}