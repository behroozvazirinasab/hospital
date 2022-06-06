using H.DataLayer.Context;
using H.DataMdel.Models;
using H.DataMdel.ViewModel;
using H.Services.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HospitalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        private readonly IUnitOfWork _uow;
        private readonly IDaroService _daroService;

        public ValuesController(
            IUnitOfWork uow,
            IDaroService daroService)
        {
            
            _uow = uow;
            _daroService = daroService;
        }




        [HttpGet]
        public async Task<IActionResult> AddDaro(DaroViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "فیلد ها خالی هست");
                return (IActionResult)viewModel;
            }
            _daroService.Add(new DaroModel()
            {
                Title = viewModel.Title,
                Description = viewModel.Description
            });
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        public void Post([FromBody] string value)
        {
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
