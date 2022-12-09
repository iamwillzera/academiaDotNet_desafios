using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlannerSemanal.Models;
using Microsoft.AspNetCore;

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
            DateTime dataAtual = DateTime.Now; //dataAtual sempre será valor do dia de hoje
            DateTime dataLimite = DateTime.Now.AddDays(8); //adicionando 7 dias para exibição, além da data atual
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

        [HttpGet]
        public IActionResult CriarAtividade(string dataAtividade)
        {
            Atividade atividade = new Atividade
            {
                Data = dataAtividade
            };
            return View(atividade);
        }

        [HttpPost]
        public async Task<IActionResult> CriarAtividade(Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                _contexto.Atividades.Add(atividade);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(atividade);
        }
        [HttpGet]
        public async Task<IActionResult> AtualizarAtividade(int atividadeId)
        {
            Atividade atividade = await _contexto.Atividades.FindAsync(atividadeId);

            if (atividade == null)
                return NotFound();

            return View(atividade);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarAtividade(Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(atividade);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(atividade);
        }

        [HttpPost]
        public async Task<JsonResult> ExcluirAtividade(int atividadeId)
        {
            Atividade atividade = await _contexto.Atividades.FindAsync(atividadeId);

            _contexto.Atividades.Remove(atividade);
            await _contexto.SaveChangesAsync();
            return Json(true);
        }
    }
}