namespace Foodi.Models
{
	public class FoodCategory
	{
		public int FoodCategoryId { get; set; }
		public string Name { get; set; }

		//NP

		public List<FoodItem> foodItems { get; set; }
	}
}
