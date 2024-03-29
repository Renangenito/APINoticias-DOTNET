using APINoticias.Extensoes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurarServicos(builder.Configuration);

builder.Services.ConfigurarJWT();
builder.Services.ConfigurarSwagger();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
