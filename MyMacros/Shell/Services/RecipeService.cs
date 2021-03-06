using Core.Interfaces;
using Shell.Interfaces;
using Shell.Models;
using System.Collections.Generic;

namespace Shell.Services
{
    public class RecipeService : IRecipeService
    {
        ILoader<Recipe> _recipeLoader;
        IParser<Recipe> _recipeParser;
        public RecipeService(ILoader<Recipe> recipeLoader, IParser<Recipe> recipeParser)
        {
            _recipeLoader = recipeLoader;
            _recipeParser = recipeParser;
        }

        public List<Recipe> GetAllRecipes()
        {
            var recipes = new List<Recipe>();

            var data = _recipeLoader.LoadData();

            return recipes;
        }
    }
}
