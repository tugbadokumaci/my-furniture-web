using System;
using EntityLayer.Concrete;
using FurnitureWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Diagnostics;

namespace UI.Controllers
{
	public class DefaultController : Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public ActionResult Home()
		{
			return View();
		}
        public ActionResult LivingRooms()
        {
            return View();
        }
        public ActionResult DiningRooms()
        {
            return View();
        }
        public ActionResult Bedrooms()
        {
            return View();
        }
        public ActionResult HomeDecor()
        {
            return View();
        }
        public async Task<IActionResult> DetailAsync(int id)
        {
            Product product = null;

            using (var client = _httpClientFactory.CreateClient())
            {
                client.BaseAddress = new Uri("https://localhost:7119/"); // Your API base address

                var response = await client.GetAsync($"/products/{id}"); // Your API endpoint
                if (response.IsSuccessStatusCode)
                {
                    var products = await response.Content.ReadFromJsonAsync<Product>(); // Adjust Product type accordingly
                    return View(products);
                }
                else
                {
                    // Handle error
                    return View(product); // Adjust Product type accordingly
                }
            }
        }

    }
}

