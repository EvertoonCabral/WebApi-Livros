using WebApi_Livros.Models;

namespace WebApi_Livros.Services.Autor
{
    public interface IAutorInterface
    {

        Task<ResponseModel<List<AutorModel>>> GetAllAutor();
        Task<ResponseModel<AutorModel>> GetAutorById(int idAutor);
        Task<ResponseModel<AutorModel>> GetAutorByLivroId(int idLivro);
    }
}
