using PlannerSemanal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace PlannerSemanal.ViewComponents
{
    public class ListaAtividadesViewComponent : ViewComponent
    {
        private readonly Contexto _contexto;
        public ListaAtividadesViewComponent(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(string data)
        {
            return View(await _contexto.Atividades
                .OrderBy(t => t.Horario).Where(t => t.Data == data).ToListAsync());
        }
    }
}