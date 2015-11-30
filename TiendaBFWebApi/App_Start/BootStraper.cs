using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioTiendaBF.Models;
using RepositorioTiendaBF.ViewModel;

namespace TiendaBFWebApi.App_Start
{
    public class BootStraper
    {
        public static void Init(UnityContainer container)
        {
            container.RegisterType<DbContext, PracticaTiendaEntities>();

            container.RegisterType<IRepositorio<Categoria, CategoriaViewModel>,
                                   RepositorioEntity<Categoria, CategoriaViewModel>>();

            container.RegisterType<IRepositorio<Producto, ProductoViewModel>,
                                   RepositorioEntity<Producto, ProductoViewModel>>();

            container.RegisterType<IRepositorio<Compra, CompraViewModel>,
                                   RepositorioEntity<Compra, CompraViewModel>>();

            container.RegisterType<IRepositorio<Usuario, UsuarioViewModel>,
                                   RepositorioEntity<Usuario, UsuarioViewModel>>();

            container.RegisterType<IRepositorio<CompraProducto, CompraProductoViewModel>,
                                   RepositorioEntity<CompraProducto, CompraProductoViewModel>>();
        }
    }
}
