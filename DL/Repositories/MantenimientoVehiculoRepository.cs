using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Entidades;
using System.Data.Entity.Core.Objects;
using DL;

namespace DL.Repositories
{
    public class MantenimientoVehiculoRepository : IMantenimientoVehiculoRepository
    {
        private readonly Entities _context;
        public MantenimientoVehiculoRepository()
        {
            this._context = new Entities();
        }


        public void AddorUpdate(ActividadMantenimiento actividadMantenimiento)
        {
            if (string.IsNullOrEmpty(actividadMantenimiento.Detalle))
            {
                throw new Exception("Error, Debe insertar la Descripción");

            }
            else
            {
                if (_context.ActividadMantenimiento.Where(x=>x.Detalle==actividadMantenimiento.Detalle).FirstOrDefault()==null)
                {
                    _context.ActividadMantenimiento.Add(actividadMantenimiento);
                    _context.SaveChanges();
                }
                else
                {
                    _context.ActividadMantenimiento.Attach(actividadMantenimiento);
                    _context.Entry(actividadMantenimiento).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                }
                
            }
        }

        public IEnumerable<Mantenimiento> GetMantenimientos()
        {

            var mantenimiento = _context.Mantenimiento
                             .Include(a => a.ActividadMantenimiento)
                             .Include(v => v.Vehiculos)
                             .Include(t => t.Talleres)
                             .Include(e => e.Empleados)
                             .ToList();
            return mantenimiento;
                             
        }
    }
}
