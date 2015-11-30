using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTiendaBF.Models;

namespace RepositorioTiendaBF.ViewModel
{
    public class ProductoViewModel : IViewModel<Producto>
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Nullable<decimal> PrecioOferta { get; set; }
        public string Descripcion { get; set; }

        public Producto ToBaseDatos()
        {
            return new Producto();
        }

        public void FromBaseDatos(Producto modelo)
        {
            idProducto = modelo.idProducto;
            Nombre = modelo.Nombre;
            Precio = modelo.Precio;
            PrecioOferta = modelo.PrecioOferta;
            Descripcion = modelo.Descripcion;
        }

        public void UpdateBaseDatos(Producto modelo)
        {
            modelo.idProducto = idProducto;
            modelo.Nombre = Nombre;
            modelo.Precio = Precio;
            modelo.PrecioOferta = PrecioOferta;
            modelo.Descripcion = Descripcion;
        }

        public object[] Getkeys()
        {
            return new object[] {idProducto};
        }
    }
}
