using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL.Model;

namespace BLayer
{
   public class SexosController
    {
        private Entities Context;
        private Sexos sexo;



        public List<Sexos> ListarSexos()
        {
            using (Context = new Entities())
            {
                var query = (from obj in Context.Sexos
                             select obj).ToList();
                return query;

            }


        }
    }
}
