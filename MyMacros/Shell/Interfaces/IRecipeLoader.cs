using Shell.Models;
using System.Collections.Generic;

namespace Shell.Interfaces
{
    public interface IRecipeLoader
    {
        IEnumerable<Recipe> LoadData();
    }
}