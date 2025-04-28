using DesignPattern.Facade.DataAccessLayer;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();

        public IActionResult OrderList()
        {
            var values = context.Orders.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderDetailStart(int customerID, int productID, int orderID, int productCount, decimal productPrice)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrderDetail(customerID, productID, orderID, productCount, productPrice);

            return RedirectToAction("OrderList");
        }

        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderStart(int customerID)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerID);
            return RedirectToAction("OrderList");
        }

    }
}
