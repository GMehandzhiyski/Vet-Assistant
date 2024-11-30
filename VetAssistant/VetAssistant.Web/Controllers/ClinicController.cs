using Microsoft.AspNetCore.Mvc;
using VetAssistant.Service.Data.Contracts;
using VetAssistant.Web.ViewModels.Clinic;

namespace VetAssistant.Web.Controllers
{
    public class ClinicController : Controller
    {
        private readonly IClinicService data;

        public ClinicController(IClinicService _data)
        {
            data = _data;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new AddClinicFormModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var model = new AddClinicFormModel();
            return View(model);
        }
    }
}
