using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL;

namespace BLayer
{
   public class NacionalidadesController
    {
        private Entities Context;
        private Nacionalidades nacionalidad;


        public List<Nacionalidades> ListarNacionalidades()
        {
            using (Context = new Entities())
            {
                var query = (from n in Context.Nacionalidades
                             select n).ToList();
                return query;

            }


        }





    }
}
