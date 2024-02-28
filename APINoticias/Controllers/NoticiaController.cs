using APINoticias.Interfaces.Noticia;
using APINoticias.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APINoticias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NoticiaController : ControllerBase
    {
        private readonly INoticiaNegocio _noticia;

        public NoticiaController(INoticiaNegocio noticia)
        {
            _noticia = noticia;
        }

        [HttpGet("ObterDadosNoticia")]
        public async Task<NoticiaModel> Get([FromQuery] int id)
        {

            return await _noticia.ObterUmaNoticia(id);
        }

        [HttpGet("ObterTodasNoticias")]
        public async Task<List<NoticiaModel>> Get()
        {
            return _noticia.ObterLista();

        }

        [HttpPost()]
        public async Task Post([FromBody] NoticiaModel noticiaModel)
        {
            noticiaModel.DataPublicacao = DateTime.Now;
            await _noticia.IncluirNoticia(noticiaModel);
        }

        [HttpPut()]
        public async Task Put([FromBody] NoticiaModel noticiaModel)
        {
            await _noticia.AlterarNoticia(noticiaModel);
        }
        [HttpDelete()]
        public async Task ExcluirCliente(int id)
        {
            await _noticia.ExcluirNoticia(id);
        }
    }
}
