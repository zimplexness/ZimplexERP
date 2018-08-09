using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DL.Repositories
{
   public interface IMantenimientoVehiculoRepository
    {
        void AddorUpdate(ActividadMantenimiento actividadMantenimiento);
        IEnumerable<Mantenimiento> GetMantenimientos();


    }
}
