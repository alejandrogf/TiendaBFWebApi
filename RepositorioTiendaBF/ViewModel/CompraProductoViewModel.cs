using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTiendaBF.Models;

namespace RepositorioTiendaBF.ViewModel
{
    public class CompraProductoViewModel:IViewModel<CompraProducto>
    {
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public int Unidades { get; set; }
        public decimal SubTotal { get; set; }

        public CompraProducto ToBaseDatos()
        {
            return new CompraProducto();
        }

        public void FromBaseDatos(CompraProducto modelo)
        {
            idCompra = modelo.idCompra;
            idProducto = modelo.idProducto;
            Unidades = modelo.Unidades;
            SubTotal = modelo.SubTotal;
        }

        public void UpdateBaseDatos(CompraProducto modelo)
        {
            modelo.idCompra = idCompra;
            modelo.idProducto = idProducto;
            modelo.Unidades = Unidades;
            modelo.SubTotal = SubTotal;
        }

        public object[] Getkeys()
        {
            return new object[] {idCompra, idProducto};
        }
    }
}
