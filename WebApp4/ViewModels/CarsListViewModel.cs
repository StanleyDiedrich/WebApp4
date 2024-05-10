using System;
using WebApp4.Data.Models;

namespace WebApp4.ViewModels
{
	public class CarsListViewModel
	{
		public IEnumerable<Car> Allcars { get; set; }
		public string currCategoty { get; set; }
	}
}

