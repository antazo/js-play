var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.UseKestrel();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.MapGet("/", () => "OK")
    .WithName("GetHome")
    .WithOpenApi();

app.MapGet("/foobar", () => "Test2!")
    .WithName("GetFoobar")
    .WithOpenApi();

app.Run();