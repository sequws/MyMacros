using Core.Abstractions;
using Core.Interfaces;
using Shell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell.DataAccess
{
    public class RecipeLoader : Loader, ILoader<Recipe>
    {
        public RecipeLoader() : base("recipes")
        {

        }

        public IEnumerable<Recipe> LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
