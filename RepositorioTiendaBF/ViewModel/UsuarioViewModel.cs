using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTiendaBF.Models;

namespace RepositorioTiendaBF.ViewModel
{
    public class UsuarioViewModel:IViewModel<Usuario>
    {

        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Dni { get; set; }
        public string Domicilio { get; set; }
        public string Facturacion { get; set; }

        public Usuario ToBaseDatos()
        {
            return new Usuario();
        }

        public void FromBaseDatos(Usuario modelo)
        {
            idUsuario = modelo.idUsuario;
            Nombre = modelo.Nombre;
            Apellidos = modelo.Apellidos;
            Edad = modelo.Edad;
            Login = modelo.Login;
            Pass = modelo.Pass;
            Domicilio = modelo.Domicilio;
            Facturacion = modelo.Facturacion;
        }

        public void UpdateBaseDatos(Usuario modelo)
        {
            modelo.idUsuario = idUsuario;
            modelo.Nombre = Nombre;
            modelo.Apellidos = Apellidos;
            modelo.Edad = Edad;
            modelo.Login = Login;
            modelo.Pass = Pass;
            modelo.Domicilio = Domicilio;
            modelo.Facturacion = Facturacion;
        }

        public object[] Getkeys()
        {
            return new object[] {idUsuario};
        }
    }
}
