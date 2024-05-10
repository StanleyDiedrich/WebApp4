using System;
using Microsoft.AspNetCore.Mvc;
using WebApp4.Data.Interfaces;
using WebApp4.ViewModels;
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
			CarsListViewModel obj = new CarsListViewModel();
			obj.Allcars = _allcars.Cars;
			obj.currCategoty = "Автомобили";

			return View(obj);
		}
	}
}

