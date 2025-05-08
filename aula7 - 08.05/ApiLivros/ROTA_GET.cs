using ApiLivros.Models;

namespace ApiLivros.Routes;

public static void class ROTA_GET{

    public static void MapGetRoutes(this WebApplication app){
        List<Livros> livros = new List<Livros>
        {
            new Livros{Id = 1, Titulo = "Dom Casmurro", Autor = "Machado de Assis", AnoPublicacao = 1899},
            new Livros{Id = 2, Titulo = "1984", Autor = "George Orwell", AnoPublicacao = 1949},
            new Livros{Id = 3, Titulo = "O hobbit", Autor = "J. R. R. Tolkien", AnoPublicacao = 1937}
        };

        //rota get raiz
        app.MapGet("/", () => "Api de livros está em funcionamento");

        //rota get - listar todos os livros
        app.MapGet("api/livros", () => livros);

        //rota get - buscar livro por id
        app.MapGet("/api/livros/{id()", (int id) =>
        {
            var livro = livros.FirstOrDefault(l => l.Id == id);
            return livros != null ? Results.Ok (livros): Results.NotFound ("Livro não encontrado.");
        });
    }
}