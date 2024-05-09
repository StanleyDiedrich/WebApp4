using System;
using Microsoft.AspNetCore.Mvc;
using WebApp4.Data.Interfaces;
namespace WebApp4.Controllers
{
	public class CarsController:Controller
	{
		private readonly IAllCars _allcars;
		private readonly ICarsCategory _allCategories;

		public CarsController (IAllCars iAllcars, ICarsCategory icarscat)
		{
			_allcars = iAllcars;
			_allCategories = icarscat;
		}

		public ViewResult List()
		{
			ViewBag.Category = "Some New";
			var cars = _allcars.Cars;
			return View(cars);
		}
	}
}

