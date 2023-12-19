using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FurnitureWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            // API URL'sini belirtin
            string apiUrl = "https://localhost:7035/api/product";

            // HTTP istemcisini alın
            var client = _httpClientFactory.CreateClient();

            // GET isteği gönderin
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            // Başarılı bir yanıt alındıysa
            if (response.IsSuccessStatusCode)
            {
                // Yanıttan içeriği okuyun
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Content received: " + content);

                // İçeriği işleyin (örneğin, JSON'u deserialize edin)

                List<Product> products = JsonSerializer.Deserialize<List<Product>>(content);

                // View'e verileri taşıyın
                return View(products);
            }
            Console.WriteLine("Error response: " + response.StatusCode);

            // Hata durumunda bir şeyler yapabilirsiniz (örneğin, hata sayfasına yönlendirme)
            return View("Error");
        }
    }
}
