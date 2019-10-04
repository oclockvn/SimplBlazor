using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimplBlazor.Shared.Models;

namespace SimplBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await Task.Delay(1000); // show loading
            var products = await ProductSourceAsync();

            return Ok(products);
        }

        [HttpGet]
        [Route("{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            var products = await ProductSourceAsync();
            var product = products.SingleOrDefault(x => x.Slug == slug);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        private async Task<List<Product>> ProductSourceAsync()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "dell.jpg",
                    Name = "Dell XPS 15 9550",
                    OldPrice = 1500,
                    Price = 1499,
                    Specification = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    Rating = 3,
                    Thumbnail = "p1.jpg"
                },
                new Product
                {
                    Id = 2,
                    Details = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",
                    Image = "iphone.jpg",
                    Name = "iPhone 6S 16GB",
                    OldPrice = 500,
                    Price = 499,
                    Specification = "A 4.7-inch Retina HD display with 3D Touch. 7000 series aluminum and stronger cover glass. An A9 chip with 64-bit desktop-class architecture. All new 12MP iSight camera with Live Photos. Touch ID. Faster LTE and Wi-Fi. Long battery life and iOS 10 and iCloud. All in a smooth, continuous unibody design.",
                    Rating = 5,
                    Thumbnail = "p2.jpg"
                },
                new Product
                {
                    Id = 3,
                    Details = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.",
                    Image = "samsung.jpg",
                    Name = "Samsung Galaxy A5",
                    OldPrice = null,
                    Price = 399,
                    Specification = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora",
                    Rating = 4,
                    Thumbnail = "p3.jpg"
                },
                new Product
                {
                    Id = 4,
                    Details = "Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.",
                    Image = "ipad.jpg",
                    Name = "iPad Pro Wi-Fi 4G 128GB",
                    OldPrice = 0,
                    Price = 989,
                    Specification = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.",
                    Rating = 5,
                    Thumbnail = "p4.jpg"
                }
            };

            // generate slug
            products.ForEach(p => p.Slug = p.Name.GenerateSlug());

            return await Task.FromResult(products);
        }
    }
}
