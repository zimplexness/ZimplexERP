using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLayer
{
   public class ZonasController
    {
        public Entities Context;
        public Zonas ObjectZona;


       public List<Zonas> ListarZonas()
        {
            using (Context = new Entities())
            {
                var query = Context.Zonas.ToList();
                return query;
            }


        }
    }
}
