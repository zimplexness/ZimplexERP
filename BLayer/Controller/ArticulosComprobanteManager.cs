using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL.Model;

namespace BLayer
{
  public  class ArticulosComprobanteManager
    {

        public Entities Context;
        public DetallesComprobanteArticulos ComprobanteArticulo;

        public void InsertarArticuloComprobante(DetallesComprobanteArticulos comp)
        {
            using (Context = new Entities())
            {
                
                Context.DetallesComprobanteArticulos.Add(comp);
                Context.SaveChanges();
            }


        }

        public void InsertarTableArticuloComprobante(int idcomprobante,int idarticulo,double cant,double precio,double ivacompra,double ivacalculado,double importe)
        {
            using (Context = new Entities())
            {
                ComprobanteArticulo = new DetallesComprobanteArticulos();
                ComprobanteArticulo.IdComprobante = idcomprobante;
                ComprobanteArticulo.IdArticulo = idarticulo;
                ComprobanteArticulo.Cantidad = cant;
                ComprobanteArticulo.Precio = precio;
                ComprobanteArticulo.Iva = ivacompra;
                ComprobanteArticulo.IvaCalculado = ivacalculado;
                ComprobanteArticulo.Importe =importe;
                Context.DetallesComprobanteArticulos.Add(ComprobanteArticulo);
                Context.SaveChanges();
            }


        }

        public List<DetallesComprobanteArticulos> ListarArticulosComprobante(int idcomprobante)
        {

            using (Context = new Entities())
            {
                var query = (from artcomp in Context.DetallesComprobanteArticulos
                             where artcomp.IdComprobante==idcomprobante
                             select artcomp).ToList();
                return query;       
            }


        }

        public int EliminarArticuloComprobante(int idcomproart)
        {
            try
            {
                using (Context = new Entities())
                {
                   
                    var detallecompart = (from a in Context.DetallesComprobanteArticulos
                                       where a.idTable_DetallesComprobanteArticulos==idcomproart
                                       select a).First();


                    Context.DetallesComprobanteArticulos.Remove(detallecompart);
                    Context.SaveChanges();
                    int result = 1;
                    return result;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<SeleccionarDetalleComprobantesArticulos_Result> SeleccionarDetallesComprobantesArticulos(int idcomprobante)
        {
            using (Context = new Entities())
            {
                var query = Context.SeleccionarDetalleComprobantesArticulos(idcomprobante);
                return query.ToList();
            }

        }



    }
}
