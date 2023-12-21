using System;
using System.ComponentModel.DataAnnotations;
using EntityLayer.Concrete;

namespace FurnitureEcommerce.Models
{
    public class Product
	{
		public Product()
		{
		}
        [Key]
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public bool ProductStatus { get; set; }
        public double ProductPrice { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public List<Comment> Comment { get; set; }
    }
}

