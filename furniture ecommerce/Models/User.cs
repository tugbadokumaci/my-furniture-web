﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FurnitureEcommerce.Models
{
	public class User
	{
		public User()
		{
		}

		[Key]
		public int UserID { get; set; }
		public string UserName { get; set; }	
		public string UserSurname { get; set; }

        public List<Product> Products { get; set; }

    }
}

