using AutoMapper;
using AvaliacaoSistemasWeb.Aplicacao;
using AvaliacaoSistemasWeb.Dominio.Core.Interfaces;
using AvaliacaoSistemasWeb.Infraestrutura.Dados.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Injeção de Dependência
//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSingleton<IEstacaoRecargaApp, EstacaoRecargaApp>();
builder.Services.AddSingleton(typeof(IBase<>), typeof(RepositorioBase<>));
builder.Services.AddSingleton<IEstacaoRecarga, EstacaoRecargaRepositorio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
