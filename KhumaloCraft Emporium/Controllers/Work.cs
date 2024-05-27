using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft_Emporium.Controllers
{
    public class Work : Controller
    {
        public string ImagePath { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public IActionResult Add()
        {
            var craftworks = new List<Work>
        {
            new Work { ImagePath = "/images/item1.jfif", Description = "Craftwork 1 description", Price = 100.00m },
            new Work { ImagePath = "/images/item2.jfif", Description = "Craftwork 2 description", Price = 150.00m },
            new Work { ImagePath = "/images/item3.jfif", Description = "Craftwork 3 description", Price = 120.00m }
        };
            return View();
        }
    }
}
