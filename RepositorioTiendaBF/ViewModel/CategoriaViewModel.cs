using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTiendaBF.Models;

namespace RepositorioTiendaBF.ViewModel
{
    public class CategoriaViewModel : IViewModel<Categoria>
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public Categoria ToBaseDatos()
        {
            return new Categoria();
        }

        public void FromBaseDatos(Categoria modelo)
        {
            IdCategoria = modelo.IdCategoria;
            Nombre = modelo.Nombre;
        }

        public void UpdateBaseDatos(Categoria modelo)
        {
            modelo.IdCategoria = IdCategoria;
            modelo.Nombre = Nombre;
        }

        public object[] Getkeys()
        {
            return new object[] {IdCategoria};
        }
    }
}
