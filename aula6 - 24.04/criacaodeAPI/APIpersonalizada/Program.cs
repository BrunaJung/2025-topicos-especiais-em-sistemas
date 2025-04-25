var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá!Seja bem-vindo a primeira API da Bruna!");

app.MapGet("/sobre", () => "Eu sou a bruna e estudo Análise e Desenvolvimento de Sistemas na Universidade Positivo.");

app.MapGet("/localizacao", () => "A localização da Universidade é na Praça Osório.");

app.MapGet("/contato", () => "Telefone: (41)3345-8213\nE-mai:bruna@gmail.com");

app.MapGet("/produtos", () => "Nossos produtos:\n1- Tablet.\n2- Notebook.\n3- Smartphone.");

app.Run();

