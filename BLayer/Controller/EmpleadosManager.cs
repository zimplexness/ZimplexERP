using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using Entidades;
using DL;

namespace BLayer
{
    public class EmpleadosManager
    {
        public Entities Context;
        public Empleados empleado;

        public Departamentos departamento;
        public ObraSocial obrasocial;
        public Sindicatos sindicato;
        public CategoriaEmpleado categoriaempleado;
       
        public AfectadoEmpresaCliente objectempresacliente;

        public EmpleadosManager() { empleado = new Empleados(); }



        public List<Departamentos> ListarDepartamentos()
        {
            using (Context = new Entities())
            {
                var query = (from d in Context.Departamentos
                             select d).ToList();
                return query;
            }




        }

        public List<Solicitudesempleos> ListarSolicitudesEmpleo()
        {
            using (Context = new Entities())
            {
                var query = (from d in Context.Solicitudesempleos
                             select d).ToList();
                return query;
            }




        }

        public List<ObraSocial> ListarObraSocial()
        {
            using (Context = new Entities())
            {
                var query = (from d in Context.ObraSocial
                             select d).ToList();
                return query;
            }




        }

        public List<Sindicatos> ListarSindicatos()
        {
            using (Context = new Entities())
            {
                var query = (from d in Context.Sindicatos
                             select d).ToList();
                return query;
            }




        }

        public List<Especialidades> ListarEspecialidades()
        {
            using (Context = new Entities())
            {
                var query = (from d in Context.Especialidades
                             select d).ToList();
                return query;
            }




        }

        public List<CategoriaEmpleado> ListarCategoriaEmpleado()
        {
            using (Context = new Entities())
            {
                var query = (from d in Context.CategoriaEmpleado
                             select d).ToList();
                return query;
            }




        }

        //public int InsertarEmpleadoBasico(string nolegajo, int persona, int departamento,int sindicato,DateTime fechaingreso,
        //    int especialidad,int categoria,bool activo,bool ieric,string comentario)
        //{
        //    int result = 0;
        //    using (Context=new Entities())
        //    {
        //        empleado.NoLegajo = nolegajo;
        //        empleado.idPersona = persona;
        //        empleado.idDepartamento = departamento;
        //        empleado.idSindicato = sindicato;
        //        empleado.FechaIngreso = fechaingreso;
        //        empleado.idEspecialidad = especialidad;
        //        empleado.idCategoriaEmpleado = categoria;

        //        empleado.Activo = activo;
        //        empleado.Ieric = ieric;
        //        empleado.Comentario = comentario;
        //        Context.Empleados.Add(empleado);
        //        Context.SaveChanges();
        //        result = empleado.IDEmpleado;
        //        return result;

        //    }


        //}


        


        public int DevolverIDEmpleado(int legajo)
        {
            int result = 0;
            using (Context = new Entities())
            {
                var query = (from obj in Context.Empleados
                             where obj.NoLegajo==legajo
                             select obj.IDEmpleado).FirstOrDefault();

              

                result = int.Parse(query.ToString());
                return result;
            }

        }

        public List<ListaEmpleadosActivos_Result> ListarEmpleadosActivos()
        {

            using (Context = new Entities())
            {
                var query = (from obj in Context.ListaEmpleadosActivos()
                             select obj).ToList();
                return query;
            }



        }

        public List<HistorialEmpleadosSitem_Result> HistorialEmpleados()
        {

            using (Context = new Entities())
            {
                var query = (from obj in Context.HistorialEmpleadosSitem()
                             select obj).ToList();
                return query;
            }



        }
        public List<DatosEmpleadosActivos> ListarEmpleadosActivosporID(int id)
        {

            using (Context = new Entities())
            {
                var query = (from obj in Context.DatosEmpleadosActivos
                             where obj.IDEmpleado == id

                             select obj).ToList();
                return query;
            }



        }

        public void InsertarEmpleado(Byte[] imagenperfil, bool activo, int legajo, string nombre, string apellidos, string dni, string cuil, DateTime fechanacimiento,
             string telefono, string celular, string domicilio, DateTime fechaingreso, int hijos, int iddepartamento, int idobrasocial, int idsindicato, int idespecialidad,
             int idcategoriaempleado, string nocuenta, bool ieric, string comentario, int idlocalidad, int estadocivil, int idnacionalidad, bool libretafondodesempleo,
             int idsexo, bool registro,int empresacliente,int idzona)
        {
            using (Context = new Entities())
            {
                empleado.ImagenPerfil = imagenperfil;
                empleado.Activo = activo;
                empleado.NoLegajo = legajo;
                empleado.Nombres = nombre;
                empleado.Apellidos = apellidos;
                empleado.DNI = dni;
                empleado.CUIL = cuil;
                empleado.FechaNacimiento = fechanacimiento;
                empleado.Telefono = telefono;
                empleado.Celular = celular;
                empleado.Domicilio = domicilio;
                empleado.FechaIngreso = fechaingreso;
                empleado.Hijos = hijos;
                empleado.idDepartamento = iddepartamento;
                empleado.IdObraSocial = idobrasocial;
                empleado.idSindicato = idsindicato;
                empleado.idEspecialidad = idespecialidad;
                empleado.idCategoriaEmpleado = idcategoriaempleado;
                empleado.NoCuentaFondoDesempleo = nocuenta;
                empleado.Ieric = ieric;

                empleado.Comentario = comentario;
                empleado.IdLocalidad = idlocalidad;
                empleado.EstadoCivil = estadocivil;
                empleado.IdNacionalidad = idnacionalidad;
                empleado.LibretaFondoDesempleo = libretafondodesempleo;
                empleado.IdSexo = idsexo;
                empleado.RegistroConducir = registro;
                empleado.IDEmpresaAFectada = empresacliente;
                empleado.IDZona = idzona;
                Context.Empleados.Add(empleado);
                Context.SaveChanges();

                }




        }





        

        public int validarEmpleado(int nolegajo)
        {

            int result = 0;

            using (Context = new Entities())
            {
                var query = (from e in Context.Empleados
                             where e.NoLegajo==nolegajo
                             select e).FirstOrDefault();

                if (query!= null)
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }
              
            }
            return result;


        }

        public void UpdateEmpleado(int idempleado,Byte[] imagenperfil, bool activo, int legajo, string nombre, string apellidos, string dni, string cuil, DateTime fechanacimiento,
            string telefono, string celular, string domicilio, DateTime fechaingreso, int hijos, int iddepartamento, int idobrasocial, int idsindicato, int idespecialidad,
            int idcategoriaempleado, string nocuenta, bool ieric, string comentario, int idlocalidad, int estadocivil, int idnacionalidad, bool libretafondodesempleo,
            int idsexo, bool registro,int empresacliente,int idzona

           ) {
            using (Context = new Entities())
            {
                var empleado = (from e in Context.Empleados
                                where e.IDEmpleado==idempleado
                                select e).ToList();

                foreach (var item in empleado)
                {
                    Context.Empleados.Attach(item);
                    item.ImagenPerfil = imagenperfil;
                    item.Activo = activo;
                    item.NoLegajo = legajo;
                    item.Nombres = nombre;
                    item.Apellidos = apellidos;
                    item.DNI = dni;
                    item.CUIL = cuil;
                    item.FechaNacimiento = fechanacimiento;
                    item.Telefono = telefono;
                    item.Celular = celular;
                    item.Domicilio = domicilio;
                    item.FechaIngreso = fechaingreso;
                    item.Hijos = hijos;
                    item.idDepartamento = iddepartamento;
                    item.IdObraSocial = idobrasocial;
                    item.idSindicato = idsindicato;
                    item.idEspecialidad = idespecialidad;
                    item.idCategoriaEmpleado = idcategoriaempleado;
                    item.NoCuentaFondoDesempleo = nocuenta;
                    item.Ieric = ieric;
                    item.Comentario = comentario;
                    item.IdLocalidad = idlocalidad;
                    item.EstadoCivil = estadocivil;
                    item.IdNacionalidad = idnacionalidad;
                    item.LibretaFondoDesempleo = libretafondodesempleo;
                    item.IdSexo = idsexo;
                    item.RegistroConducir = registro;
                    item.IDEmpresaAFectada = empresacliente;
                    item.IDZona = idzona;


                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }




            }





        }


        public void EliminarEmpleado(string dni,string cuil)
        {
            try
            {
                using (Context = new Entities())
                {
                    var query = (from obj in Context.Empleados
                                 where obj.DNI == dni && obj.CUIL == cuil
                                 select obj).FirstOrDefault();

                    Context.Empleados.Remove(query);
                    Context.SaveChanges();
                   



                }
            }
            catch (Exception)
            {

                throw;
            }





        }

        public List<ListaEmpleadosActivos_Result> FiltroApellidos(string apellido) {
            using (Context = new Entities())
            {
                var filtro = (from l in Context.ListaEmpleadosActivos()
                             where l.Apellidos.Contains(apellido.ToUpper())select l).ToList();
                return filtro;
            }



        }

        public List<HistorialEmpleadosSitem_Result> FiltroApellidosHistorial(string apellido)
        {
            using (Context = new Entities())
            {
                var filtro = (from l in Context.HistorialEmpleadosSitem()
                              where l.Apellidos.Contains(apellido.ToUpper())
                              select l).ToList();
                return filtro;
            }



        }

        public List<ListaEmpleadosActivos_Result> FiltroNolegajo(int nolegajo)
        {
            using (Context = new Entities())
            {
                var filtro = (from l in Context.ListaEmpleadosActivos()
                              where l.NoLegajo==nolegajo
                              select l).ToList();
                return filtro;
            }


        }

        public List<ListaEmpleadosActivos_Result> FiltroFechadeAlta(DateTime fechainicio,DateTime fechafin)
        {
            using (Context = new Entities())
            {
                var filtro = (from l in Context.ListaEmpleadosActivos()
                              where l.FechaIngreso >= fechainicio && l.FechaIngreso <=fechafin
                              select l).ToList();
                return filtro;
            }


        }

        public List<ReporteNominaTelecentro_Result> ReporteNominaTLC(DateTime fechafin)
        {
            using (Context = new Entities())
            {

                var list = Context.ReporteNominaTelecentro(fechafin);
                return list.ToList();
                
            }


        }

        public List<ListaEmpleadosActivos_Result> FiltroDNI(string dni)
        {
            using (Context = new Entities())
            {
                var filtro = (from l in Context.ListaEmpleadosActivos()
                              where l.DNI.Contains(dni.ToUpper())
                              select l).ToList();
                return filtro;
            }


        }

        public List<ListaEmpleadosActivos_Result> NominaTelecentro()
        {
            using (Context = new Entities())
            {
                var filtro = (from l in Context.ListaEmpleadosActivos()
                              where l.EmpresaCliente=="Telecentro"  select l).ToList();
                return filtro;
            }


        }

        public List<ListaEmpleadosActivos_Result> NominaCablevision()
        {
            using (Context = new Entities())
            {
                var filtro = (from l in Context.ListaEmpleadosActivos()
                              where l.EmpresaCliente == "Cablevision"
                              select l).ToList();
                return filtro;
            }


        }


        public void DarBaja(int legajo, DateTime fechabaja, string comentario)
        {
            using (Context=new Entities())
            {

                var query = (from e in Context.Empleados
                            where e.NoLegajo == legajo
                            select e).ToList();
                foreach (var item in query)
                {
                    bool activo = false;
                    Context.Empleados.Attach(item);
                    item.FechaCeseLaboral = fechabaja;
                    item.Comentario = comentario;
                    item.Activo = activo;


                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }
                


            }




        }

    

    } 








}
