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
  public  class ImportarPadron
    {
        public Entities _context;
        public string  StreamReader{ get; set; }
        public PadronRgsRet _padron;

        public ImportarPadron()
        {
         
        }

        public void ImportarPadronMethod() {

            // If the file is small, read it all at once
            string[] lines = File.ReadAllLines(StreamReader.ToString());
            // TODO: if lines is empty, bail out
            _padron = new PadronRgsRet();
            using (_context = new Entities())
            {



                // for each line (no ifs or whiles here)
                foreach (var line in lines)
                {
                    string[] fields = line.Split(';');
                    // TODO: verify fields contains what you want
                    // SqlCommand implements IDisposable too

                    _padron.Regimen = fields[0];
                    _padron.FechaPublicacion = ConvertToDateTime(fields[1]);
                    _padron.FechaDesde = ConvertToDateTime(fields[2]);
                    _padron.FechaHasta = ConvertToDateTime(fields[3]);
                    _padron.Cuit = fields[4];
                    _padron.TipoContribuyenteInsc = fields[5];
                    _padron.MarcaAltaBaja = fields[6];
                    _padron.MarcaCambioAlicuota = fields[7];
                    _padron.Alicuota = float.Parse(fields[8]);
                    _padron.Grupo = int.Parse(fields[9]);
                    _context.PadronRgsRet.Add(_padron);
                    _context.SaveChangesAsync();
                }



            }
        }

        public DateTime ConvertToDateTime(string datetime) {

            DateTime date = new DateTime();
            
            date  = DateTime.ParseExact(datetime,
                                   "ddMMyyyy",
                                    CultureInfo.InvariantCulture);
                return date;

            }


        }


    }

