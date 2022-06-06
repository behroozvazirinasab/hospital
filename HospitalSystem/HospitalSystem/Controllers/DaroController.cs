using H.DataLayer.Context;
using H.DataMdel.Models;
using H.DataMdel.ViewModel;
using H.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    public class DaroController : Controller
    {
        private readonly ILogger<DaroController> _logger;
        private readonly IUnitOfWork _uow;
        private readonly IDaroService _daroService;

        public DaroController(ILogger<DaroController> logger,
            IUnitOfWork uow,
            IDaroService daroService)
        {
            _logger = logger;
            _uow = uow;
            _daroService = daroService;
        }




        public IActionResult CreateDaro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDaro(DaroViewModel viewModel)
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


        [HttpGet]
        public async Task<IActionResult> GetAllDaro()
        {
            var daros = await _daroService.GetAllAsync();
            return Ok(daros);
        }


        [HttpGet]
        public IActionResult GetDaroById(int id)
        {
            var daro = _daroService.FindById(id);
            return Ok(daro);
        }


        [HttpPut]
        public IActionResult UpdateDaro(DaroViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                //ModelState.AddModelError(string.Empty, "فیلد ها خالی هست");
                return View(viewModel);
            }
            _daroService.Update(new DaroModel()
            {
                Title = viewModel.Title,
                Description = viewModel.Description
            });
            _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


  
        [HttpDelete]
        public IActionResult DeleteDaro(int id)
        {
            var daro = _daroService.FindById(id);
            if (daro == null)
            {
                return NotFound();
            }
            _daroService.Remove(id);
            _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Index()
        {
            //var daros = await _daroService.GetAllAsync();
            return RedirectToAction(nameof(GetAllDaro));
        }
     
    }
}
