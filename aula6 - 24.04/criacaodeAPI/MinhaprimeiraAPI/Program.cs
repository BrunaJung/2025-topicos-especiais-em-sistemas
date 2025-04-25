var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.MapGet("/agora", () => $"Data e hora atual: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");

app.MapGet("/", () => {
    int ano = DateTime.Now.Year;
    string anoPorExtenso = ano switch
    {
        2023 => "dois mil e vinte e três",
        2024 => "dois mil e vinte e quatro",
        2025 => "dois mil e vinte e cinco",
        2026 => "dois mil e vinte e seis",
        _ => $"ano de {ano}."
    };
    return $"Estamos no ano de {anoPorExtenso}.";
});

app.Run();
