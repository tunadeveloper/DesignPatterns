﻿using DesignPattern.ChainOfResponsibility.ChainOfResponsbility;
using DesignPattern.ChainOfResponsibility.DataAccessLayer;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);

            var context = new Context();
            var result = context.CustomerProcesses
                .OrderByDescending(x=>x.CustomerProcessID)
                .FirstOrDefault(x=>x.Name == model.Name && x.Amount == model.Amount.ToString());
            ViewBag.Result = result?.Description;

            using (var context2 = new Context())
            {
                var history = context2.CustomerProcesses
                    .Where(x => x.Name == model.Name)
                    .OrderByDescending(x => x.CustomerProcessID)
                    .Take(10)
                    .ToList();
                ViewBag.History = history;
            }
            return View();
        }
    }
}
