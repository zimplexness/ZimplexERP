using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL;

namespace BLayer
{
   public class EstadoCivilController
    {
        private Entities Context;
        private EstadoCivil estadocivil;



        public List<EstadoCivil> ListarEstadoCivil()
        {
            using (Context = new Entities())
            {
                var query = (from obj in Context.EstadoCivil
                             select obj).ToList();
                return query;

            }


        }
    }
}
