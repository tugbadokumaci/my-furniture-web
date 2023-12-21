using System;
using System.ComponentModel.DataAnnotations;
using EntityLayer.Concrete;

namespace FurnitureEcommerce.Models
{
    public class Comment
	{
		public Comment()
		{
		}

		[Key]
        public int CommentID { get; set; }
        public String CommentContent { get; set; }
        public int UserID { get; set; }
        public User Users { get; set; }
		public int ProductID { get; set; }
		public Product Product { get; set; }

    }


}

