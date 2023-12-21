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
        public async Task<IActionResult> LivingRooms()
        {

            ViewBag.SofaModel = await FetchCategoryData(3);
            ViewBag.ChairModel = await FetchCategoryData(1);


            return View();
        }

        // Method to fetch category data from the API
        private async Task<List<Product>> FetchCategoryData(int categoryId)
        {
            List<Product> categoryData = null;

            using (var client = _httpClientFactory.CreateClient())
            {
                client.BaseAddress = new Uri("https://localhost:7119/"); // Update with your API base address

                var response = await client.GetAsync($"/categories/{categoryId}");
                if (response.IsSuccessStatusCode)
                {
                    categoryData = await response.Content.ReadFromJsonAsync<List<Product>>(); // Update with your Product model
                }
                else
                {
                    // Handle error
                }
            }

            return categoryData;
        }
        public async Task<IActionResult> DiningRooms()
        {
            ViewBag.DiningTableModel = await FetchCategoryData(7);
            ViewBag.SideboardsModel = await FetchCategoryData(8);
            ViewBag.KitchenTableModel = await FetchCategoryData(9);


            return View();
        }
        public async Task<IActionResult> Bedrooms()
        {
            ViewBag.BedModel = await FetchCategoryData(4);
            ViewBag.MirrorModel = await FetchCategoryData(6);


            return View();
        }
        public async Task<IActionResult> HomeDecor()
        {
            ViewBag.PillowModel = await FetchCategoryData(10);


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

