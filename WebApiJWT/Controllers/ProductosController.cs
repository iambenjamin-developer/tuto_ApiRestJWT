using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApiJWT.Models;

namespace WebApiJWT.Controllers
{
    [Authorize]
    [RoutePrefix("api/productos")]
    public class ProductosController : ApiController
    {
        public IEnumerable<PRODUCTOS> Get()
        {

            var lista = new List<PRODUCTOS>();
            using (var db = new dbTestEntities()) {

                lista = db.PRODUCTOS.ToList();
            }

            return lista;
        }

    }
}
