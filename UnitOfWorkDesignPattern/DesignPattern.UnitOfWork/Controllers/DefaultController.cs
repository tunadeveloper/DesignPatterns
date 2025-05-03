using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var value1 = _customerService.TGetByID(model.SenderID);
            var value2 = _customerService.TGetByID(model.ReceiverID);

            if (value1 == null || value2 == null)
            {
                ViewBag.Message = "Müşteri bilgileri geçersiz.";
                ViewBag.AlertClass = "alert-danger";
                return View();
            }

            if (value1.CustomerBalance < model.Amount)
            {
                ViewBag.Message = "Yetersiz bakiye.";
                ViewBag.AlertClass = "alert-danger"; 
                return View();
            }

            value1.CustomerBalance -= model.Amount;
            value2.CustomerBalance += model.Amount;

            List<Customer> modifiedCustomers = new List<Customer>()
            {
                value1,
                value2
            };

            _customerService.TMultiUpdate(modifiedCustomers);
            ViewBag.Message = "İşlem başarıyla gerçekleşti!";
            ViewBag.AlertClass = "alert-success"; 
            return View();
        }
    }
}
