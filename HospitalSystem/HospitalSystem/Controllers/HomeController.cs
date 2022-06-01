using H.DataLayer.Context;
using H.DataMdel.Models;
using H.DataMdel.ViewModel;
using H.Services.IServices;
using HospitalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HospitalSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _uow;
        private readonly IDaroService _daroService;

        public HomeController(ILogger<HomeController> logger,
            IUnitOfWork uow,
            IDaroService daroService)
        {
            _logger = logger;
            _uow = uow;
            _daroService = daroService;
        }


        public IActionResult AddDaro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDaro(DaroViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "فیلد ها خالی هست");
                return View(viewModel);
            }
            _daroService.Add(new DaroModel()
            {
                Title = viewModel.Title,
                Description = viewModel.Description
            });
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}