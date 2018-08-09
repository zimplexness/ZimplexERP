using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Repositories;
using Entidades;

namespace BLayer.Controller
{
   public class MantenimientoVehiculoController
    {
        private readonly IMantenimientoVehiculoRepository mantenimientoVehiculoRepository;

        public MantenimientoVehiculoController()
        {
            mantenimientoVehiculoRepository = new MantenimientoVehiculoRepository();
        }

      public void AddActividadMantenimiento(ActividadMantenimiento actividad) {

             mantenimientoVehiculoRepository.AddorUpdate(actividad);

        }

        public IEnumerable<Mantenimiento> GetMantenimientos() {

          return  mantenimientoVehiculoRepository.GetMantenimientos();
        }

    }
}
