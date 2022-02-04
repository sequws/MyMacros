using Shell.Interfaces;
using Shell.Models;
using System.Collections.Generic;

namespace Shell.Services
{
    public class RecipeService : IRecipeService
    {
        IRecipeLoader _recipeLoader;

        public RecipeService(IRecipeLoader recipeLoader)
        {
            _recipeLoader = recipeLoader;
        }

        public List<Recipe> GetAllRecipes()
        {
            var recipes = new List<Recipe>();

            var data = _recipeLoader.LoadData();

            return recipes;
        }
    }
}
