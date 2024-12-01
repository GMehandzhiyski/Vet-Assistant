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
        public async Task<IActionResult> Add()
        {
            try
            {
                AddClinicFormModel model = new AddClinicFormModel();
                model.Countries = await data.GetCountryAsync();

                return View(model);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "An error occurred while processing your request.");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Add(AddClinicFormModel model)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    model.Countries = await data.GetCountryAsync();
                    return View(model);
                }

                bool isCountryValid = await data.IsCountryValid(model.CountryId);
                if (isCountryValid == false)
                {
                    model.Countries = await data.GetCountryAsync();
                    ModelState.AddModelError("Country", "The selected event category is invalid");
                    return View(model);
                }

                await data.AddClinicAsync(model);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "An error occurred while processing your request.");
            }

        }

        [HttpGet]
        public IActionResult Edit()
        {
            var model = new AddClinicFormModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete()
        {
            var model = new AddClinicFormModel();
            return View(model);
        }
    }
}
