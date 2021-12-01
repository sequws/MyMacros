using System;
using System.Collections.Generic;

namespace Core.Abstractions
{
    public abstract class Parser : ErrorCollector
    {
        public bool TryParse(List<string> input, Action failAction)
        {
            if (!TryParse(input))
            {
                failAction();
                return false;
            }
            return true;
        }

        public abstract bool TryParse(List<string> input);
    }
}
