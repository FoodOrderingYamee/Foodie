using System.Xml.Linq;
using Foodi.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Foodi.Controllers
{
	public class FoodCategory : Controller
	{
		private readonly IFoodCategory _foodCategory;

		public FoodCategory(IFoodCategory foodCategory)
		{
			_foodCategory = foodCategory;
		}

		public async Task<IActionResult> Index()
		{
			var foodCategories = await _foodCategory.GetFoodCategories();
			return View(foodCategories);
		}
	}
}
