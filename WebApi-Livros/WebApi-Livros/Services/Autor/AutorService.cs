using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi_Livros.Data;
using WebApi_Livros.Models;

namespace WebApi_Livros.Services.Autor
{
    public class AutorService : IAutorInterface

    {

        private readonly AppDBContext _context;

        public AutorService(AppDBContext context)
        {

            _context = context;

        }


        public async Task<ResponseModel<List<AutorModel>>> GetAllAutor()
        {

            ResponseModel<List<AutorModel>> response = new ResponseModel<List<AutorModel>>();
            try
            {

                var autores = await _context.Autores.ToListAsync();

                response.Dados = autores;
                response.Message = "Todos os autores listados";

            } catch (Exception ex) {

                response.Message = ex.Message;
                response.Status = false;

                return response;

            }

            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> GetAutorById(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> GetAutorByLivroId(int idLivro)
        {
            throw new NotImplementedException();
        }
    }
}
