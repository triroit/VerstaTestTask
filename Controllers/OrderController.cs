using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IActionResult> DetailsAsync(string Id) 
        {
            var order = await _db.Orders.FirstOrDefaultAsync(u=>u.Id == Guid.Parse(Id));
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
        public async Task<IActionResult> AddOrderAsync(OrderDTO newOrderDTO)
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
                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "Order");
            }
            return View(newOrderDTO);
        }
    }
}
