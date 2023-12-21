using System;
using System.ComponentModel.DataAnnotations;

namespace FurnitureWebAPI.Model
{
	public class Category
	{
		// property
		// Erişim Belirleyici Türü - Değişken türü isim {get set}

		[Key]
		public int CategoryID { get; set; }
		public String CategoryName { get; set; }
		public String CategoryDescription { get; set; }
		public bool CategoryStatus { get; set; }
		public List<Product> Products { get; set; }
    }
}

