using System.Collections.Generic;

namespace BlazorShoppingList.DTO
{
    public class RecipeDto
    {
        public RecipeDto()
        {
            Ingredients = new List<IngredientDto>();
        }

        public string Name { get; set; }

        public List<IngredientDto> Ingredients { get; set; }
    }
}
