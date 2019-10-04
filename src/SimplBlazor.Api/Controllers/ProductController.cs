using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimplBlazor.Shared.Models;

namespace SimplBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = ProductSource();

            return Ok(products);
        }

        private static List<Product> ProductSource()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Details = "",
                    Image = "dell.jpg",
                    Name = "Dell XPS 15 9550",
                    OldPrice = 1500,
                    Price = 1499,
                    Specification = "",
                    Star = 3,
                    Thumbnail = "p1.jpg"
                },
                new Product
                {
                    Id = 2,
                    Details = "",
                    Image = "",
                    Name = "iPhone 6S 16GB",
                    OldPrice = 500,
                    Price = 499,
                    Specification = "",
                    Star = 5,
                    Thumbnail = "p2.jpg"
                },
                new Product
                {
                    Id = 3,
                    Details = "",
                    Image = "samsung.jpg",
                    Name = "Samsung Galaxy A5",
                    OldPrice = null,
                    Price = 399,
                    Specification = "",
                    Star = 4,
                    Thumbnail = "p3.jpg"
                },
                new Product
                {
                    Id = 4,
                    Details = "",
                    Image = "ipad.jpg",
                    Name = "iPad Pro Wi-Fi 4G 128GB",
                    OldPrice = 0,
                    Price = 989,
                    Specification = "",
                    Star = 5,
                    Thumbnail = "p4.jpg"
                }
            };
        }
    }
}
