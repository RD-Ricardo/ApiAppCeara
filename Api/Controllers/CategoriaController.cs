using System;
using System.Threading.Tasks;
using Application.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{   
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService =categoriaService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            try{
                var categoria =  await _categoriaService.GettAllCategoriaAsync();
                return Ok(categoria);
            }
            catch(Exception){
                return this.BadRequest();
            }
        }

    }
}