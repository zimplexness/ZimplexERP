using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
  public class ProveedoresModel
    {

        public int IdProveedores { get; set; }
        public string Nombre { get; set; }
        public string Razon { get; set; }
        public string Cuit { get; set; }
        public string IngresosBrutos { get; set; }
        public string Direccion { get; set; }
        public int IDProvincia { get; set; }
        public int IDLocalidad { get; set; }
        public string Telefono { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<int> IDRubro { get; set; }
        public Nullable<int> UserAltaID { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> UserUltModificacion { get; set; }
        public Nullable<System.DateTime> FechaUltimaModificacion { get; set; }



    }
}
