using Foodi.Models.DTOs;

namespace Foodi.Models.Interfaces
{
	public interface IFoodCategory
	{
		Task<FoodCategoryDTO> Create(CreatFoodCategoryDTO creatFoodCategoryDTO);

		Task<List<FoodCategoryDTO>> GetFoodCategories();
		Task<FoodCategoryDTO> GetFoodCategory(int foodCategoryId);
		Task<FoodCategoryDTO> Update(CreatFoodCategoryDTO creatFoodCategoryDTO, int foodCategoryId);
		Task Delete(int foodCategoryId);
	}
}
