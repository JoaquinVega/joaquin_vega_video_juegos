using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using api_videojuegos.Models;

namespace api_videojuegos.Controllers
{
    public class apiConsolasController : ApiController
    {
        video_juegos_bd bd = new video_juegos_bd();
        public IEnumerable<consola> Get()
        {
            return bd.consolas;
        }

    }
}
