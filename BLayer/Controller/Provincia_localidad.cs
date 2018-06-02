using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Model;
using Entidades;

namespace BLayer
{
   public class Provincia_localidad
    {

        public Entities Context;

        private Provincias Mprovincia;

        public List<Provincias> ListarProvincias()
        {
            using (Context = new Entities())
            {
                var query = (from provin in Context.Provincias select provin).ToList();
                return query;
            }
        }

        public List<Provincias> FiltrarProvincias(string name)
        {
            using (Context = new Entities())
            {
                var query = (from provin in Context.Provincias
                             where provin.Provincias1.Contains(name.ToUpper())
                             select provin).ToList();
                return query;
            }
        }



        public List<Localidades> ListarLocalidades()
        {
            using (Context = new Entities())
            {
                var query = (from loca in Context.Localidades select loca).ToList();
                return query;
            }

        }


        public List<Localidades> FiltrarLocalidades(string namelocalidad)
        {
            using (Context = new Entities())
            {
                var query = (from loca in Context.Localidades
                             where loca.Localidades1.Contains(namelocalidad.ToUpper())
                             select loca).ToList();
                return query;
            }

        }

        public void InsertarLocalidad(string localidad, string cp)
        {
            using (Context=new Entities())
            {
                Localidades Elocalidad = new Localidades();
                Elocalidad.Localidades1 = localidad;
                Elocalidad.CodigoPostal = cp;
                Context.Localidades.Add(Elocalidad);
                Context.SaveChanges();


            }




        }

        public int ValidateLocalidad(string name){

            int result = 0;
            using (Context = new Entities())
            {
                var query = (from l in Context.Localidades
                             where l.Localidades1 == name
                             select l).FirstOrDefault();

                if (query != null)
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

        public void ActualizarLocalidad(string localidad, string cp) {

            using (Context = new Entities())
            {

                var objlocalidad = (from v in Context.Localidades
                                   where v.Localidades1 == localidad
                                   select v).ToList();
                foreach (var item in objlocalidad)
                {



                    item.Localidades1 = localidad;
                    item.CodigoPostal =cp ;
                    

                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();


                }




            }


        }

        public void InsertarProvincia(string provincia){

            using (Context = new Entities())
            {
                Mprovincia = new Provincias();
                Mprovincia.Provincias1 = provincia;
                Context.Provincias.Add(Mprovincia);
                Context.SaveChanges();



            }




        }





    }
}
