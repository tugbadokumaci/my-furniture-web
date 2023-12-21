using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http; // Bu satırı ekleyin
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FurnitureWebAPI.Model;

namespace FurnitureWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        // GET: PRODUCT
        public ActionResult Index()
        {
            IEnumerable<Product> product = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:7035/api/");
                // HTTP GET
                var responseTask = client.GetAsync("product"); // "student" olması yerine "product" olmalı
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Product>>();
                    readTask.Wait();

                    product = readTask.Result;
                }
                else // web api sent error response 
                {
                    // log response status here..

                    product = Enumerable.Empty<Product>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            Debug.WriteLine(message: "Furniture Ecommerce Api - productcontroller -" + product.ToString); //assuming you have using System.Diagnostics

            return View(product);
        }
    }
}
