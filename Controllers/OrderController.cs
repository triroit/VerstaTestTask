using Microsoft.AspNetCore.Mvc;
using VerstaTestTask.Data;
using VerstaTestTask.Models;
using VerstaTestTask.Models.DTOs;

namespace VerstaTestTask.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var orders = _db.Orders.ToList();
            return View(orders);
        }

        public IActionResult Details(string Id) 
        {
            var order = _db.Orders.FirstOrDefault(u=>u.Id == Guid.Parse(Id));
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        public IActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(OrderDTO newOrderDTO)
        {
            if (ModelState.IsValid)
            {
                Order newOrder = new()
                {
                    Id = Guid.NewGuid(),
                    SenderCity = newOrderDTO.SenderCity,
                    SenderAddress = newOrderDTO.SenderAddress,
                    RecipientCity = newOrderDTO.RecipientCity,
                    RecipientAddress = newOrderDTO.RecipientAddress,
                    Weight = newOrderDTO.Weight,
                    DateOfReceipt = DateTime.Now
                };
                _db.Orders.Add(newOrder);
                _db.SaveChanges();
                return RedirectToAction("Index", "Order");
            }
            return View(newOrderDTO);
        }
    }
}
