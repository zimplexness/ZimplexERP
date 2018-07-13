using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using Entidades;
using DL.Model;

namespace Repositories
{
   public class ProveedorRepository:IProveedorRepository
    {

        private Entities _context;

        public ProveedorRepository() {
            this._context = new Entities();
        }
        
        public IEnumerable<View_Proveedores> GetAll()
        {
            return _context.View_Proveedores.ToList();
        }

        public View_Proveedores GetProveedoresByCuit(string cuit)
        {
            return _context.View_Proveedores
                    .FirstOrDefault(x => x.Cuit ==cuit );

        }

        public IEnumerable<View_Proveedores> GetByRubro(string Rubro)
        {
            return _context.View_Proveedores.Where(x => x.RubroProveedor.Contains(Rubro.ToUpper())).ToList();
        }

        public IEnumerable<View_Proveedores> GetByRazon(string razon)
        {
            return _context.View_Proveedores.Where(x => x.Razon.Contains(razon.ToUpper())).ToList();
        }

        public IEnumerable<View_Proveedores> GetByNombre(string nombre )
        {
            return _context.View_Proveedores.Where(x => x.Nombre.Contains(nombre.ToUpper())).ToList();
        }

        public void DeleteProveedores(int ProveedorID)
        {
            Proveedores proveedores = _context.Proveedores.Find(ProveedorID);
            _context.Proveedores.Remove(proveedores);
        }

        public void AddorUpdateProveedores(Proveedores Proveedor)
        {
            try
            {
                using (_context)
                {
                    if (!string.IsNullOrEmpty(Proveedor.Cuit))
                    {
                        if (_context.Proveedores.FirstOrDefault(
                        x => x.IdProveedores == Proveedor.IdProveedores) != null)
                            throw new Exception("Ya existe el Proveedor");
                        _context.Proveedores.Attach(Proveedor);
                        _context.Entry(Proveedor).State = EntityState.Modified;
                        _context.SaveChanges();


                    }
                    else
                    {
                        _context.Proveedores.Add(Proveedor);
                        _context.SaveChanges();

                    }

                }

              
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

                
          
           
        }

        public IEnumerable<RubroProveedor> GetRubroProveedors()
        {
            return _context.RubroProveedor.ToList();
        }

      

       
    }
}
