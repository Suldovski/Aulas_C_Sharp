using API.Models;

Console.Clear();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Lista de produtos fakes
List<Produto> produtos = new List<Produto>
{
    // new Produto { Nome = "Camiseta Básica", Quantidade = 50, Preco = 29.99 },
    // new Produto { Nome = "Calça Jeans", Quantidade = 30, Preco = 99.90 },
    // new Produto { Nome = "Tênis Esportivo", Quantidade = 20, Preco = 149.50 },
    // new Produto { Nome = "Mochila Escolar", Quantidade = 15, Preco = 79.99 },
    // new Produto { Nome = "Relógio Digital", Quantidade = 10, Preco = 199.90 },
    // new Produto { Nome = "Óculos de Sol", Quantidade = 25, Preco = 59.90 },
    // new Produto { Nome = "Boné Aba Curva", Quantidade = 40, Preco = 39.99 },
    // new Produto { Nome = "Jaqueta de Couro", Quantidade = 5, Preco = 299.99 },
    // new Produto { Nome = "Meias Esportivas", Quantidade = 100, Preco = 9.90 },
    // new Produto { Nome = "Cinto de Couro", Quantidade = 35, Preco = 49.90 }
};

//Funcionalidade - Requisições
// - URL/Caminho/Endereço
// - Um método HTTP

// Métodos HTTP:
// GET    - Recupera dados do servidor
// POST   - Envia dados para criar um recurso
// PUT    - Atualiza um recurso existente
// DELETE - Remove um recurso
// PATCH  - Atualiza parcialmente um recurso

app.MapGet("/", () => "API de Produtos");

//GET: /api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
    //Validar a lista de produtos para saber se existe algo dentro
    if (produtos.Any())
    {
            return Results.Ok(produtos) ;
    }
    return Results.NotFound("Lista vazia!");
});

//POST: /api/produto/cadastrar
app.MapPost("/api/produto/cadastrar",
    (Produto produto) =>
{
    produtos.Add(produto);
});


app.Run();
