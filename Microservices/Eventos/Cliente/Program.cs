using Cliente.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("evento", (client) =>
{
    client.BaseAddress = new Uri(builder.Configuration["EventoBase"]);
    
});
builder.Services.AddHttpClient("carrinho", (client) =>
{
    client.BaseAddress = new Uri(builder.Configuration["CarrinhoBase"]);
});

builder.Services.AddScoped<IEventoClient, EventoClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
