using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Entidades;

namespace Repositories
{
   public class ProvinciaRepository
    {

        public static List<Provincias> GetAllProvincias() {

            using (Entities _context=new Entities())
            {
                return _context.Provincias.ToList();
                
            }


        }
    }
}
