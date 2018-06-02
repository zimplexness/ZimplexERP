using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL.Model;

namespace BLayer
{
  public  class ObraSocialController
    {
        private Entities Context;
        private ObraSocial obrasocial;



        public List<ObraSocial> ListarObraSocial()
        {
            using (Context = new Entities())
            {
                var query = (from obj in Context.ObraSocial
                             select obj).ToList();
                return query;

            }


        }
    }
}
