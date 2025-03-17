using Microsoft.AspNetCore.Mvc;
using QuizCarros.Data;
using QuizCarros.Models;
using System.Diagnostics;

namespace QuizCarros.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var pergunta = _context.Perguntas.OrderBy(p => p.PerguntasId).FirstOrDefault();
            if (pergunta == null)
            {
                return View("Error");
            }
            if (TempData["Acertos"] == null || !(TempData["Acertos"] is int))
            {
                TempData["Acertos"] = 0;
            }
            TempData.Keep("Acertos");
            return View(pergunta);
        }

        public IActionResult ProximaPergunta(int perguntaId, string resposta)
        {
            var pergunta = _context.Perguntas.Where(p => p.PerguntasId == perguntaId).FirstOrDefault();
            if (pergunta == null)
            {
                return View("FimQuiz");
            }

            bool isRespostaCorreta = int.TryParse(resposta, out int respostaEscolhida) && respostaEscolhida == pergunta.RespostaCorreta;
            if (isRespostaCorreta)
            {
                TempData["Acertos"] = (int)TempData["Acertos"] + 1;
            }

            var proximaPergunta = _context.Perguntas.Where(p => p.PerguntasId == perguntaId + 1).FirstOrDefault();
            if (proximaPergunta == null)
            {
                return FimDoQuiz();
            }
            return View("Index", proximaPergunta);
        }

        public IActionResult FimDoQuiz()
        {
            var acertos = TempData["Acertos"];
            var totalPerguntas = _context.Perguntas.Count();
            ViewBag.Acertos = acertos;
            ViewBag.TotalPerguntas = totalPerguntas;

            return View("Index", model: null);
        }

        public IActionResult RefazerQuiz()
        {
            TempData["Acertos"] = 0;
            TempData.Keep("Acertos");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
