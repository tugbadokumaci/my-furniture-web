using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class User
	{
		public User()
		{
		}

		[Key]
		public object UserID { get; set; }
		public string UserName { get; set; }	
		public string UserSurname { get; set; }

        public List<Product> Products { get; set; }

    }
}

