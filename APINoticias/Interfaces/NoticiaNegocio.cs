using APINoticias.Context;
using APINoticias.Models;
using Microsoft.EntityFrameworkCore;


namespace APINoticias.Interfaces.Noticia
{
    public class NoticiaNegocio : INoticiaNegocio
    {
        private readonly NoticiasDBContext _context;

        public NoticiaNegocio(NoticiasDBContext context)
        {
            _context = context;
        }

        public async Task<NoticiaModel> ObterUmaNoticia(int id)
        {
            return await _context.Noticia.SingleAsync(x => x.Id.Equals(id));
        }
        public List<NoticiaModel> ObterLista()
        {
            return _context.Noticia.ToList();
        }
        public async Task IncluirNoticia(NoticiaModel noticiaModel)
        {
            _context.Noticia.Add(noticiaModel);
            await _context.SaveChangesAsync();

        }
        public async Task AlterarNoticia(NoticiaModel noticiaModel)
        {
            _context.Noticia.Update(noticiaModel);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirNoticia(int id)
        {
            var idRetorno = await _context.Noticia.SingleAsync(x => x.Id.Equals(id));
            _context.Noticia.Remove(idRetorno);
            await _context.SaveChangesAsync();
        }
    }
}
