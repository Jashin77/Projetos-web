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
            // Buscar a primeira pergunta
            var pergunta = _context.Perguntas
                .OrderBy(p => p.PerguntasId) // Ordenando pela ID da pergunta
                .FirstOrDefault(); // Pegando a primeira pergunta

            if (pergunta == null)
            {
                return View("Error"); // Caso não encontre perguntas no banco
            }
            if (TempData["Acertos"] == null)
            {
                TempData["Acertos"] = 0;
            }


            return View(pergunta); // Passando a pergunta para a view
        }
        public IActionResult ProximaPergunta(int perguntaId, string resposta)
        {
            var pergunta = _context.Perguntas
                .Where(p => p.PerguntasId == perguntaId)
                .FirstOrDefault();

            if (pergunta == null)
            {
                return View("FimQuiz"); // Caso o usuário tenha terminado o quiz
            }

            bool isRespostaCorreta = int.TryParse(resposta, out int respostaEscolhida) && respostaEscolhida == pergunta.RespostaCorreta;

            // Aqui você pode exibir uma mensagem se a resposta estiver certa ou errada
            ViewBag.Resultado = isRespostaCorreta ? "Resposta correta!" : "Resposta errada!";

            // Incrementa os acertos se a resposta for correta
            if (isRespostaCorreta)
            {
                TempData["Acertos"] = (int)TempData["Acertos"] + 1;
            }

            // Carregar a próxima pergunta
            var proximaPergunta = _context.Perguntas
                .Where(p => p.PerguntasId == perguntaId + 1)
                .FirstOrDefault();

            if (proximaPergunta == null)
            {
                return FimDoQuiz();
            }

            return View("Index", proximaPergunta); // Passando a próxima pergunta
        }
        public IActionResult FimDoQuiz()
        {
            // Ao terminar o quiz, exibe o número de acertos
            var acertos = TempData["Acertos"];
            var totalPerguntas = _context.Perguntas.Count();

            // Passa essas informações para a View (Index.cshtml)
            ViewBag.Acertos = acertos;
            ViewBag.TotalPerguntas = totalPerguntas;

            // Retorna a View "Index" com o resultado final
            return View("Index");
        }
        public IActionResult RefazerQuiz()
        {
            // Reseta os acertos
            TempData["Acertos"] = 0;

            // Redireciona de volta para a primeira pergunta
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
