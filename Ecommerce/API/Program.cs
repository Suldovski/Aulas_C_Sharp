var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Funcionalidade - Requisições
// - URL
// - Um método HTTP

app.MapGet("/", () => "Minha segunda API em C#");

app.MapGet("/endereco", () => "Outra funcionalidade");

app.MapPost("/endereco", () => "funcionalidade do post");


app.Run();
