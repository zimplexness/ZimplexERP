using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL.Model;

namespace BLayer
{
   public class SolicitudEmpleo
    {
        private Entities Context;
       

       

        public List<DetallesSolicitudesEmpleo> ListarSolicitudesEmpleo()
        {
           
            using (Context = new Entities())
            {
                var query = (from obj in Context.DetallesSolicitudesEmpleo
                             select obj).ToList();
                return query;
            }

        }

        public List<DetallesSolicitudesEmpleo> filtrarsolicitudespornombre(string filtronombre)
        {
            using (Context = new Entities())
            {
                var filtro = (from p in Context.DetallesSolicitudesEmpleo where p.Apellido.Contains(filtronombre.ToUpper()) select p).ToList();
                return filtro;
            }
        }

        public List<DetallesSolicitudesEmpleo> filtrarsolicitudesporcuil(string filtronombre)
        {
            using (Context = new Entities())
            {
                var filtro = (from p in Context.DetallesSolicitudesEmpleo where p.CUIL.Contains(filtronombre.ToUpper()) select p).ToList();
                return filtro;
            }
        }

        //public void EliminarSolicitudEmpleo(string cuil)
        //{

        //    int idp = 0;
        //    using (Context = new Entities())
        //    {
        //        //var objectpersona = (from p in Context.Personas
        //        //                    where p.CUIL==cuil
        //        //                    select p.IdPersona).First();

        //        idp = int.Parse(objectpersona.ToString());

        //        var objectsolicitud = (from s in Context.SolicitudesEmpleo
        //                               where s.idPersona == idp
        //                               select s).First();

               

        //        var query = (from p in Context.Personas
        //                     where p.CUIL == cuil
        //                     select p).First();
        //        Context.SolicitudesEmpleo.Remove(objectsolicitud);
        //        Context.SaveChanges();
        //        Context.Personas.Remove(query);
        //        Context.SaveChanges();

        //    }



        //}

        public void EditarSolicitudesEmpleo()
        {




        }

    }
}
