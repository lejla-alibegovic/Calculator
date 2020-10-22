using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CalculationModel model)
        {
            switch (model.Operations)
            {
                case Operation.Add:
                    {
                        model.Result = model.FirstNumber + model.SecondNumber;
                        break;
                    }
                case Operation.Substract:
                    {
                        model.Result = model.FirstNumber - model.SecondNumber;
                        break;
                    }
                case Operation.Multiply:
                    {
                        model.Result = model.FirstNumber * model.SecondNumber;
                        break;
                    }
            }
            return View(model);
        }


    }
}
