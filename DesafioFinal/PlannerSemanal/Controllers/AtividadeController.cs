using Microsoft.AspNetCore.Mvc;
using PlannerSemanal.Models;

namespace PlannerSemanal.Controllers
{
    public class AtividadeController : Controller
    {
        private readonly Contexto _contexto;

        public AtividadeController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View(BuscarDatas());
        }

        private List<DataViewModel> BuscarDatas()
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataLimite = DateTime.Now.AddDays(10);
            int qtdeDias = 0;
            DataViewModel data;
            List<DataViewModel> listaDatas = new List<DataViewModel>();

            while (dataAtual < dataLimite)
            {
                data = new DataViewModel();
                data.Data = dataAtual.ToShortDateString();
                data.Identificadores = "collapse" + dataAtual.ToShortDateString().Replace("/", "");
                listaDatas.Add(data);
                qtdeDias = qtdeDias + 1;
                dataAtual = DateTime.Now.AddDays(qtdeDias);
            }

            return listaDatas;
        }

    }
}