using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Web.Mvc;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioTiendaBF.Models;
using RepositorioTiendaBF.ViewModel;

namespace TiendaBFWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoriaController : ApiController
    {
        [Dependency]
        public IRepositorio<Categoria, CategoriaViewModel> Repositorio { get; set; }

        public ICollection<CategoriaViewModel> Get()
        {
            return Repositorio.Get();
        }

        [ResponseType(typeof (CategoriaViewModel))]
        public IHttpActionResult Get(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [ResponseType(typeof (CategoriaViewModel))]
        public IHttpActionResult Get(String contenido)
        {
            var resultado = Repositorio.Get(o => o.Nombre.Contains(contenido));

            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }
    }
}
