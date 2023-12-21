//// MVC Controller içinde
//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;

//public class HomeController : Controller
//{
//    private readonly IHttpClientFactory _httpClientFactory;

//    public HomeController(IHttpClientFactory httpClientFactory)
//    {
//        _httpClientFactory = httpClientFactory;
//    }

//    public async Task<IActionResult> Index()
//    {
//        var client = _httpClientFactory.CreateClient();
//        var response = await client.GetAsync("https://localhost:7119/products");

//        if (response.IsSuccessStatusCode)
//        {
//            var data = await response.Content.ReadAsStringAsync();
//            // Verileri kullanın (örneğin, bir modelde deserialize edebilirsiniz)
//            var model = JsonConvert.DeserializeObject<List<string>>(data);
//            return View(model);
//        }

//        return View("Error");
//    }
//}











using FurnitureWebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace FurnitureWebAPI.Controllers;
public class HomeController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HomeController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        using (var client = _httpClientFactory.CreateClient())
        {
            client.BaseAddress = new Uri("https://localhost:7119/"); // Your API base address

            var response = await client.GetAsync("/products"); // Your API endpoint
            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadFromJsonAsync<List<Product>>(); // Adjust Product type accordingly
                return View(products);
            }
            else
            {
                // Handle error
                return View(new List<Product>()); // Adjust Product type accordingly
            }
        }
    }
}
