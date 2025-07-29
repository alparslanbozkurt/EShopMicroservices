var builder = WebApplication.CreateBuilder(args);

// servisleri konteynere ekleyin
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
var app = builder.Build();

// HTTP istek hatt�n� yap�land�rma
app.MapCarter();

app.Run();
