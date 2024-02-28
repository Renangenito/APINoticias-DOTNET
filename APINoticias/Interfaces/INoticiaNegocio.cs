using APINoticias.Models;

namespace APINoticias.Interfaces.Noticia
{
    public interface INoticiaNegocio
    {
        Task<NoticiaModel> ObterUmaNoticia(int id);
        List<NoticiaModel> ObterLista();
        Task IncluirNoticia(NoticiaModel noticiaModel);
        Task AlterarNoticia(NoticiaModel noticiaModel);
        Task ExcluirNoticia(int id);
    }
}
