using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Entidades;
using System.IO;
using System.Globalization;

namespace BLayer.Controller
{
    public class ImportarPadron
    {
        public Entities _context;
        public string StreamReader { get; set; }
        public PadronRgsRet _padron;

        public ImportarPadron()
        {

        }

        public void ImportarPadronMethod(string regimen, DateTime fecha,
            DateTime fechadesde, DateTime fechahasta, string cuit, string tipo,
            string marcaalta, string marcacambio, float alicuota, int grupo

            ) {
            // TODO: if lines is empty, bail out
            _padron = new PadronRgsRet();
            using (_context = new Entities())
            {


                _padron.Regimen = regimen;
                _padron.FechaPublicacion = fecha;
                _padron.FechaDesde = fechadesde;
                _padron.FechaHasta = fechahasta;
                _padron.Cuit = cuit;
                _padron.TipoContribuyenteInsc = tipo;
                _padron.MarcaAltaBaja = marcaalta;
                _padron.MarcaCambioAlicuota = marcacambio;
                _padron.Alicuota = alicuota;
                _padron.Grupo = grupo;
                _context.PadronRgsRet.Add(_padron);
                _context.SaveChanges();
            }
        }



        public DateTime ConvertToDateTime(string datetime) {

            DateTime date = new DateTime();

            date = DateTime.ParseExact(datetime,
                                   "ddMMyyyy",
                                    CultureInfo.InvariantCulture);
            return date;

        }

        public List<PadronRgsRet> GetAllPadron() {
            using (_context = new Entities())
            {
                return _context.PadronRgsRet.ToList();

            }



        }

        public Retenciones CalcularRetenciones(string NombreProveedor,float ImporteFacturas) {
            Proveedores proveedores;
            Retenciones retenciones=new Retenciones();
            using (_context = new Entities())
            {
                proveedores = _context.Proveedores.Where(x => x.Nombre == NombreProveedor).FirstOrDefault();
                retenciones = new Retenciones();


                if (proveedores.Proveedores1.IDProvincia != 1 || proveedores.IDLocalidad == 8)
                {
                    retenciones = null;
                }
                else
                {
                    PadronRgsRet Padron = _context.PadronRgsRet.Where(x => x.Cuit == proveedores.Cuit).FirstOrDefault();
                    retenciones.Importe = (ImporteFacturas * Padron.Alicuota) / 100;
                    retenciones.Alicuota = Padron.Alicuota;
                    retenciones.Fecha = DateTime.Now;
                    retenciones.EmpresaID = 1;
                    _context.Retenciones.Add(retenciones);
                    _context.SaveChanges();


                }
                return retenciones;
                
            }
           

        }

        public void DeleteRetencion(int id) {
            using (_context=new Entities())
            {
                var Ret = _context.Retenciones.Where(x => x.IDRetencion == id).FirstOrDefault();

                _context.Retenciones.Remove(Ret);
                _context.SaveChanges();




            }


        }


    }


}

