using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL.Model;

namespace BLayer
{
  public class TallerManager
    {


        //variable principales de la clase
        private Entities context;
        private Talleres taller;
        public void InsertarTaller(string Nombre,
                                   string Direccion,
                                   int idlocalidad,
                                   string telefonocontacto,
                                   string Encargado,
                                   int tipotaller) {

            using (context=new Entities())
            {
                taller = new Talleres();
                taller.NombreTaller = Nombre;
                taller.Direccion = Direccion;
                taller.IDLocalidad = idlocalidad;
                taller.TelefonoCotacto = telefonocontacto;
                taller.NombreEncargado = Encargado;
                taller.IdTipoTaller = tipotaller;

                context.Talleres.Add(taller);
                context.SaveChanges();

            }


        }

        public void UpdateTaller(string Nombre,
                                   string Direccion,
                                   int idlocalidad,
                                   string telefonocontacto,
                                   string Encargado,
                                   int tipotaller)
        {

          

            using (context = new Entities())
            {
               taller = new Talleres();

               var query = (from t in context.Talleres
                             where t.NombreTaller == Nombre && t.Direccion == Direccion
                             select t).ToList();

                foreach (var item in query)
                {
                    item.NombreTaller = Nombre;
                    item.Direccion = Direccion;
                    item.IDLocalidad = idlocalidad;
                    item.TelefonoCotacto = telefonocontacto;
                    item.NombreEncargado = Encargado;
                    item.IdTipoTaller = tipotaller;

                    context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();




                }



            }


        }


        public List<ListaTalleresMecanicos> TalleresMecanicos() {

            using (context=new Entities())
            {
                var query = (from lt in context.ListaTalleresMecanicos
                             select lt).ToList();
                return query;

            }


        }

        public int validateTaller(string nombre, string direccion) {
            int result = 0;
            using (context=new Entities())
            {

                var query = (from t in context.Talleres
                             where t.NombreTaller == nombre && t.Direccion == direccion
                             select t).FirstOrDefault();

                if (query!=null)
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }
                return result;
            }
        }

        public List<TipoTaller> TiposTaller() {
            using (context=new Entities())
            {
                var query = context.TipoTaller.ToList();
                return query;
            }


        }

        public List<ListaTalleresMecanicos> FiltrarxNombres(string nombre)
        {

            using (context = new Entities())
            {
                var query = (from lt in context.ListaTalleresMecanicos
                             where lt.NombreTaller.Contains(nombre.ToUpper())
                             select lt).ToList();
                return query;

            }


        }

    }
}
