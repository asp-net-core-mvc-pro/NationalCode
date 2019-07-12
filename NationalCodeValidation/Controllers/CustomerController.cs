using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NationalCodeValidation.Models;
using System.Collections.Generic;
using System.Linq;

namespace NationalCodeValidation.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Create()
        {
            var model = new CustomerModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CustomerModel model)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                ViewBag.Errors = allErrors;

                return View(model);
            }

            return RedirectToAction(nameof(Create));
        }
    }
}
