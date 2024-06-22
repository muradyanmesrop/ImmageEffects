using ImmageEffects.BLL.Operation;
using ImmageEffects.Core.Abstraction;
using ImmageEffects.Core.Model;
using ImmageEffects.Core.Operations;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IImageAbstraction, ImageModel>();
builder.Services.AddScoped<IEffectAbstraction, EffectModel>();
builder.Services.AddScoped<IAddFileOperation, UploadFile>();
builder.Services.AddScoped<IChangeImage, ChangeImage>();

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
