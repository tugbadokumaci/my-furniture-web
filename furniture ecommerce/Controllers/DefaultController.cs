using System;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class DefaultController : Controller
	{
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
        public ActionResult Detail()
        {
            return View();
        }

    }
}

