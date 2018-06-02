using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL.Model;

namespace BLayer
{
   public class AlmacenManager
    {
        public Entities Context;
        public Almacenes Almacen;


        public int InsertarAlmacen(DateTime fecha,string nombre,string codigo,int idencargado,int idzona)
        {
            int result;
            using (Context = new Entities())
            {
                Almacen = new Almacenes();
                Almacen.FechaAlta = fecha;
                Almacen.Nombre = nombre;
                Almacen.Codigo = codigo;
                Almacen.IdEncargado = idencargado;
                Almacen.IDZona = idzona;

                Context.Almacenes.Add(Almacen);
                Context.SaveChanges();
                result = 1;
                return result;
            }

        }

        public List<Zonas> ListarZonas()
        {
            using (Context = new Entities())
            {
                var query = (from z in Context.Zonas
                             select z).ToList();
                return query;
            }



        }

        //public List<View_Almacenes> ListarAlamcenes()
        //{
        //    using (Context = new Entities())
        //    {
        //        var query = (from listalmacen in Context.View_Almacenes
        //                     select listalmacen).ToList();
        //        return query;



        //    }


        //}


    }
}
