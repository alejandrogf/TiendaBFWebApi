using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTiendaBF.Models;

namespace RepositorioTiendaBF.ViewModel
{
    public class CompraViewModel:IViewModel<Compra>
    {

        public int IdCompra { get; set; }
        public string Nombre { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int idUsusario { get; set; }

        public Compra ToBaseDatos()
        {
            return new Compra();
        }

        public void FromBaseDatos(Compra modelo)
        {
            IdCompra = modelo.IdCompra;
            Nombre = modelo.Nombre;
            Fecha = modelo.Fecha;
            Total = modelo.Total;
            idUsusario = modelo.idUsusario;
        }

        public void UpdateBaseDatos(Compra modelo)
        {
            modelo.IdCompra = IdCompra;
            modelo.Nombre = Nombre;
            modelo.Fecha = Fecha;
            modelo.Total = Total;
            modelo.idUsusario = idUsusario;
        }

        public object[] Getkeys()
        {
            return new object[] {IdCompra};
        }
    }
}
