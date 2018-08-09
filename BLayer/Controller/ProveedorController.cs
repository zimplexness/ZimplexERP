using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Repositories;
using Entidades;

namespace BLayer.Controller
{
   public class ProveedorController
    {
        private readonly IProveedorRepository _proveedorRepository;
       
        public ProveedorController()
        {
            _proveedorRepository = new ProveedorRepository();
        }

       public  IEnumerable<View_Proveedores> GetProveedores() {
            try
            {
               
             var _Proveedores= _proveedorRepository.GetAll();
                return _Proveedores;
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }

          

           

        }

        public IEnumerable<View_Proveedores> FilterByRazon(string razon) {
            try
            {
                return _proveedorRepository.GetByRazon(razon); 
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public IEnumerable<View_Proveedores> FilterByNombre(string nombre)
        {
            try
            {
                return _proveedorRepository.GetByNombre(nombre);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public IEnumerable<View_Proveedores> FilterByRubro(string Rubro)
        {
            try
            {
                return _proveedorRepository.GetByRubro(Rubro);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public IEnumerable<View_Proveedores> FilterByCuit(string cuit)
        {
            try
            {
                return _proveedorRepository.GetByCuit(cuit);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
    }
}
