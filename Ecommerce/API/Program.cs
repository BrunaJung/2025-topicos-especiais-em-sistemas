using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// /testarurl
app.MapGet("/testarurl", () => "Primeira API!");

// /parametro/param
app.MapGet("/parametro/{param1}", ([FromRoute]string param1) => {
    string result = param1 + " " + DateTime.Now;
    return result;
});

app.Run();
