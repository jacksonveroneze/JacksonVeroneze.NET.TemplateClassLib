using JacksonVeroneze.NET.TemplateClassLib.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTemplateClassLibService(conf =>
    conf.Property = string.Empty);

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

app.UseAuthorization();

app.MapControllers();

app.Run();