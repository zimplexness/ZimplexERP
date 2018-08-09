using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DL.Repositories
{
    public interface IProveedorRepository
    {

        IEnumerable<View_Proveedores> GetAll();
        View_Proveedores GetProveedoresByCuit(string cuit);
        IEnumerable<View_Proveedores> GetByRubro(string Rubro);
        IEnumerable<View_Proveedores> GetByRazon(string razon);
        IEnumerable<View_Proveedores> GetByNombre(string nombre);
        IEnumerable<View_Proveedores> GetByCuit(string cuit);
        void AddorUpdateProveedores(Proveedores proveedores);
        void DeleteProveedores(int ProveedorID);
        IEnumerable<RubroProveedor> GetRubroProveedors();

        



    }
}
