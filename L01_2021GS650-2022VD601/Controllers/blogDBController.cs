using L01_2021GS650_2022VD601.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2021GS650_2022VD601.models.usuarios;

namespace L01_2021GS650_2022VD601.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class blogDBController : ControllerBase
    {
        private readonly blogDBContext _blogDBContexto;

        public blogDBController(blogDBContext blogDBContexto)
        {
            _blogDBContexto = blogDBContexto;
        }

        //Controlador de usuarios

        [HttpGet]
        [Route("Find/{filtro]")]

        public IActionResult FindByDescription(string filtro) 
        {
        usuarios? usuarios=(from b in _blogDBContexto.usuarios
                          where b.nombre.Contains(filtro)
                          select b).ToList();
        }

        //public IActionResult FindByDescription(string filtro)
        //{
        //    usuarios? usuarios = (from b in _blogDBContexto.usuarios
        //                          where b.nombre.Contains(filtro)
        //                          select b).ToList();
        //}










    }
}
