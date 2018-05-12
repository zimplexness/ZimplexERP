using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace BLayer
{
  public  class Afectado_a_Cliente
    {

        private Entities Context;
        private EmpresasClientes objempresasclientes;
        private AfectadoEmpresaCliente afectadoempresa;

        public List<EmpresasClientes> ListarEmpresasClientes()
        {
            using (Context=new Entities())
            {
                var query = Context.EmpresasClientes.ToList();
                return query;
            

            }
        }

        public void InsertarEmpleadoAfectadoCliente(int idempleado, int idempresacliente)
        {

            using (Context = new Entities())
            {
                afectadoempresa = new AfectadoEmpresaCliente();
                afectadoempresa.IdEmpleado = idempleado;
                afectadoempresa.IdEmpresaCliente = idempresacliente;
                Context.AfectadoEmpresaCliente.Add(afectadoempresa);
                Context.SaveChanges();




            }


        }

    }
}
