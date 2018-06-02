using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL.Model;

namespace BLayer
{
   public class Estudios
    {
        private Entities Context;
        private Estudios estudiorealizados;



        public List<EstudiosRealizados> ListarEstudios()
        {
            using (Context = new Entities())
            {
                var query = (from obj in Context.EstudiosRealizados
                             select obj).ToList();
                return query;

            }


        }
    }
}
