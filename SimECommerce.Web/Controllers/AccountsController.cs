using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SimECommerce.Application.Services;
using SimECommerce.Application.ViewModels.Users;

namespace SimECommerce.Web.Controllers
{
    [Route("[controller]")]
    public class AccountsController : Controller
    {
        readonly IRegistrationService _registrationService;
        public AccountsController(IRegistrationService registrationService)
        {
            this._registrationService = registrationService;
        }

        [HttpGet]
        public IActionResult RegistrationForm()
        {
            return View();
        }
        public async Task<IActionResult> Register(NewUserViewModel newUserViewModel, CancellationToken token)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this._registrationService.RegisterUser(newUserViewModel, token);
                    return View("SuccessfullyRegistered");

                }
                catch (ValidationException ex)
                {
                    ModelState.AddModelError(nameof(newUserViewModel.UserName), ex.Message);
                    SetSkippedValid(nameof(newUserViewModel.Password));

                    void SetSkippedValid(string key)
                    {
                        if (ModelState.GetFieldValidationState(key) == ModelValidationState.Valid)
                        {
                            ModelState.MarkFieldSkipped(key);
                        }
                    }


                }
            }
            return View(nameof(RegistrationForm));
        }
    }
}