using Core.Abstractions;
using Core.Interfaces;
using Shell.Interfaces;
using Shell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell.DataAccess
{
    public class RecipeParser : Parser, IParser<Recipe>
    {
        public Recipe GetData()
        {
            throw new NotImplementedException();
        }

        public override bool TryParse(List<string> input)
        {
            throw new NotImplementedException();
        }
    }


}
