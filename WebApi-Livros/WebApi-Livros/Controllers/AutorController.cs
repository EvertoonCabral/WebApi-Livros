using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Livros.Models;
using WebApi_Livros.Services.Autor;

namespace WebApi_Livros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {

        private readonly IAutorInterface _autorInterface;

        public AutorController(IAutorInterface autorInterface)
        {

             _autorInterface = autorInterface;

        }


        [HttpGet("GetAllAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> GetAllAutor()
        {

            var autores = await _autorInterface.GetAllAutor();
            return Ok(autores);

        }


    }
}
