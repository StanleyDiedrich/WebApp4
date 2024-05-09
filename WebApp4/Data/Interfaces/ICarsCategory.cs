using System;
using WebApp4.Data.Models;
namespace WebApp4.Data.Interfaces
{
	public interface ICarsCategory
	{
		IEnumerable<Category> AllCategories { get; }
	}
}

